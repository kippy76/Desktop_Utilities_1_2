/*
 Copyright (C) 2012  Christopher Walker

 This program is free software: you can redistribute it and/or modify
 it under the terms of the GNU General Public License version 3 as
 published by the Free Software Foundation.

 This program is distributed in the hope that it will be useful,
 but WITHOUT ANY WARRANTY; without even the implied warranty of
 MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 GNU General Public License for more details.

 You should have received a copy of the GNU General Public License
 along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace DesktopUtilities
{
    class Lorem
    {
        private MainForm GUI;
        private string loremFull;
        private enum SELECTIONTYPE { Words, Paragraphs };
        private int selectionType;
        private TrackBar slider;
        private ComboBox comboSelected;
        private Label labelValue;
        private Button btnGenerate;
        private TextBox txtOut;
        private ProgressBar progressBar;
        private int sliderValue;

        public Lorem(MainForm GUI)
        {
            this.GUI = GUI;
        }

        public void initLorem()
        {
            // First, load up 100 paragraphs of Lorem Ipsum text...
            loremFull = "";
            try
            {
                TextReader tr = new StreamReader("Lorem.dat");
                loremFull = tr.ReadToEnd();
                tr.Close();
            }
            catch (Exception)
            {
                MainForm.MessageBox("'Lorem.dat' file is missing from\ninstallation directory!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainForm.initError = true;
                return;
            }
            // Event handlers & GUI setup
            slider = (TrackBar)GUI.tabLorem.Controls["trackBarLorem"];
            comboSelected = (ComboBox)GUI.tabLorem.Controls["cmbLoremSelected"];
            labelValue = (Label)GUI.tabLorem.Controls["lblLoremValue"];
            btnGenerate = (Button)GUI.tabLorem.Controls["btnLoremGo"];
            txtOut = (TextBox)GUI.tabLorem.Controls["txtLoremOutput"];
            progressBar = (ProgressBar)GUI.tabLorem.Controls["prgLorem"];
            sliderValue = 1;
            slider.Value = sliderValue;
            comboSelected.Items.Add(SELECTIONTYPE.Words.ToString());
            comboSelected.Items.Add(SELECTIONTYPE.Paragraphs.ToString());
            comboSelected.SelectedIndex = 0;
            comboValueChange();
            slider.Value = 1;
            sliderMoveEvent();
            selectionType = (int)SELECTIONTYPE.Words;
            labelValue.Text = sliderValue.ToString();
            progressBar.Value = 0;
            slider.ValueChanged += new EventHandler((object sender, EventArgs e) => sliderMoveEvent());
            comboSelected.SelectedIndexChanged += new EventHandler((object sender, EventArgs e) => comboValueChange());
            btnGenerate.Click += new EventHandler((object sender, EventArgs e) => generate());
            txtOut.Click += new EventHandler((object sender, EventArgs e) => copyToClipBoard());
            // Amend text box to take up greatest height possible
            int heightDiff = GUI.Height - 233;
            txtOut.Height = heightDiff + 68;
            progressBar.Top = heightDiff + 155;
        }

        private void sliderMoveEvent()
        {
            labelValue.Text = slider.Value.ToString();
            sliderValue = slider.Value;
        }

        private void comboValueChange()
        {
            int oldSliderValue = slider.Value;
            selectionType = comboSelected.SelectedIndex;
            int oldMax = slider.Maximum;
            slider.Maximum = selectionType == (int)SELECTIONTYPE.Words ? 9000 : 100;
            slider.SmallChange = slider.Maximum / 100;
            slider.TickFrequency = slider.Maximum / 10;
            if (oldMax != slider.Maximum)
            {
                // scale new slider value so it holds roughly same position on scale, and constrain to slider limits.
                int newValue = oldMax > slider.Maximum ? (int)(((float)oldSliderValue / 9000) * 100) : (int)(((float)oldSliderValue / 100) * 9000);
                newValue = newValue < slider.Minimum ? slider.Minimum : newValue;
                newValue = newValue > slider.Maximum ? slider.Maximum : newValue;
                slider.Value = newValue;
            }
        }

        private void generate()
        {
            string delimiter = (selectionType == (int)SELECTIONTYPE.Paragraphs) ? "\n" : " ";
            string[] stringArray;
            string generated = "";
            stringArray = loremFull.Split(delimiter.ToCharArray());
            for (int item = 0; item < sliderValue; item++)
            {
                progressBar.Value = (100 / sliderValue) * item;
                if (selectionType == (int)SELECTIONTYPE.Paragraphs)
                {
                    generated += stringArray[2 * item];
                    if (sliderValue - item != 1)
                    {
                        generated += "\r\n\r\n";
                    }
                }
                else
                {
                    generated += stringArray[item];
                    if (sliderValue - item != 1)
                    {
                        generated += " ";
                    }
                }
            }
            progressBar.Value = 100;
            // Add trailing full stop if required
            if (selectionType == (int)SELECTIONTYPE.Words)
            {
                if (generated[generated.Length - 1].Equals(','))
                {
                    // remove trailing comma, and replace with full stop.
                    generated = generated.Substring(0, generated.Length - 1);
                }
                generated += ".";
            }
            txtOut.Text = generated;            
            copyToClipBoard();
        }

        private void copyToClipBoard()
        {
            Clipboard.SetDataObject(txtOut.Text, true);
            MainForm.MessageBox("Text copied to clipboard!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
