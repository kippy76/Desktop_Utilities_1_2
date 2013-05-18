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
using System.Windows.Forms;
using System.Drawing;

namespace DesktopUtilities
{
    class Colour
    {
        MainForm GUI;
        Color color;

        public Colour(MainForm GUI)
        {
            this.GUI = GUI;
            color = Color.Transparent;
        }


        public void initColour()
        {
            Label colourPicker = (Label)GUI.tabColourPicker.Controls["lblColourSample"];
            colourPicker.Click += new EventHandler((object sender, EventArgs e) => getColour());
        }

        private void getColour()
        {
            int r, g, b = 0;
            DialogResult result = GUI.colorDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                color = GUI.colorDialog.Color;
                r = color.R;
                g = color.G;
                b = color.B;
                GUI.txtColourRGBdecimal.Text = r + ", " + g + ", " + b;
                GUI.txtColourRGB.Text = String.Format("{0:X2}", r) + String.Format("{0:X2}", g) + String.Format("{0:X2}", b);
                GUI.txtColourRGBcss.Text = "#" + String.Format("{0:X2}", r) + String.Format("{0:X2}", g) + String.Format("{0:X2}", b);
                GUI.txtColourRdec.Text = r.ToString();
                GUI.txtColourGdec.Text = g.ToString();
                GUI.txtColourBdec.Text = b.ToString();
                GUI.txtColourRhex.Text = String.Format("{0:X2}", r);         
                GUI.txtColourGhex.Text = String.Format("{0:X2}", g);
                GUI.txtColourBhex.Text = String.Format("{0:X2}", b);
                GUI.lblColourSample.BackColor = color;
                GUI.lblColourSample.Image = null;
                // RGB ->HSL conversion                
                decimal h = decimal.Round(((decimal)(color.GetHue() / 360) * 240), MidpointRounding.AwayFromZero);
                decimal s = decimal.Round(((decimal)color.GetSaturation() * 240), MidpointRounding.AwayFromZero);
                decimal l = decimal.Round(((decimal)color.GetBrightness() * 240), MidpointRounding.AwayFromZero);
                GUI.txtColourH.Text = h.ToString();
                GUI.txtColourS.Text = s.ToString();
                GUI.txtColourL.Text = l.ToString();
            }
        }

        private struct HSL
        {
            public static readonly HSL Empty = new HSL();
            private double hue;
            private double saturation;
            private double luminance;
            private double maxValue;

            public double Hue
            {
                get
                {
                    return hue;
                }
                set
                {
                    hue = (value > maxValue) ? maxValue : ((value < 0) ? 0 : value);
                }
            }

            public double Saturation
            {
                get
                {
                    return saturation;
                }
                set
                {
                    saturation = (value > maxValue) ? maxValue : ((value < 0) ? 0 : value);
                }
            }

            public double Luminance
            {
                get
                {
                    return luminance;
                }
                set
                {
                    luminance = (value > maxValue) ? maxValue : ((value < 0) ? 0 : value);
                }
            }

            public HSL(double h, double s, double l, int maxVal)
            {
                this.maxValue = maxVal;
                this.hue = (h > maxVal) ? maxVal : ((h < 0) ? 0 : h);
                this.saturation = (s > maxVal) ? maxVal : ((s < 0) ? 0 : s);
                this.luminance = (l > maxVal) ? maxVal : ((l < 0) ? 0 : l);
            }
        }


    }
}
