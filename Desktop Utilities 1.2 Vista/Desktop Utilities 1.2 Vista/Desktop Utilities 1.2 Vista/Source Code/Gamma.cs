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
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;

namespace DesktopUtilities
{
    class Gamma
    {
        [DllImport("gdi32.dll")]
        public static extern bool SetDeviceGammaRamp(IntPtr hDC, ref RAMP lpRamp);
        [DllImport("user32")]
        private static extern int ReleaseDC(IntPtr Handle, IntPtr DeviceContext);
        [DllImport("user32.dll")]
        static extern IntPtr GetDC(IntPtr hWnd);
        private MainForm GUI;
        private int gammaValue;
        private int currentSliderPosition;
        private int defaultGammaValue = 34; // Equates to 80% bang on
        TrackBar gammaSlider;
        Button btnDefault;

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct RAMP
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Red;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Green;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Blue;
        }

        public Gamma(MainForm GUI)
        {
            this.GUI = GUI;
        }

        public void initGamma()
        {
            // Want to grab value or set default only.
            btnDefault = (Button)GUI.tabGamma.Controls["btnGammaDefault"];
            gammaSlider = (TrackBar)GUI.tabGamma.Controls["sliderGamma"];
            int loadedGamma = loadGammaValue();
            currentSliderPosition = loadedGamma == -1 ? defaultGammaValue : loadedGamma;
            gammaSlider.Value = currentSliderPosition;
            gammaSlider.ValueChanged += new EventHandler((object sender, EventArgs e) => updateGamma());            
            btnDefault.Click += new EventHandler((object sender, EventArgs e) => resetDefaults());
            updateGamma();
        }

        public void updateGamma()
        {
            gammaSlider = (TrackBar)GUI.tabGamma.Controls["sliderGamma"];
            currentSliderPosition = gammaSlider.Value;
            gammaValue = 45 - currentSliderPosition;
            setGamma(44);
            setGamma(gammaValue);
            updateGammaLabel();
        }

        private void updateGammaLabel()
        {
            Label gammaLabel = (Label)GUI.tabGamma.Controls["lblGamma"];
            double gammaPercent = 100 - ((gammaValue - 3) * 2.5d);
            gammaLabel.Text = "Gamma: " + String.Format("{0:0.0}", gammaPercent) + "%";
        }

        private void setGamma(int gamma)
        {
            RAMP ramp = new RAMP();
            IntPtr gammaDC = GetDC(IntPtr.Zero);
            ramp.Red = new ushort[256];
            ramp.Green = new ushort[256];
            ramp.Blue = new ushort[256];
            for (int i = 1; i < 256; i++)
            {
                // gamma is a value between 3 and 44
                ramp.Red[i] = ramp.Green[i] = ramp.Blue[i] = (ushort)(Math.Min(65535, Math.Max(0, Math.Pow((i + 1) / 256.0, gamma * 0.1) * 65535 + 0.5)));
            }
            SetDeviceGammaRamp(gammaDC, ref ramp);
            ReleaseDC(IntPtr.Zero, gammaDC);
        }

        public bool saveGammaValue()
        {
            try
            {
                TextWriter tw = new StreamWriter("gamma.dat");
                tw.WriteLine(currentSliderPosition.ToString());
                tw.Flush();
                tw.Close();
                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }

        public int loadGammaValue()
        {
            int loadedGamma = -1;
            string fileLine = null;
            try
            {
                TextReader tr = new StreamReader("gamma.dat");
                fileLine = tr.ReadLine();
                if (String.IsNullOrEmpty(fileLine))
                {
                    return -1;
                }
                loadedGamma = Convert.ToInt32(fileLine);
                tr.Close();
            }
            catch (Exception)
            {
                return -1;
            }
            return loadedGamma;
        }
    
        private void resetDefaults()
        {
            currentSliderPosition = defaultGammaValue;
            TrackBar gammaSlider = (TrackBar)GUI.tabGamma.Controls["sliderGamma"];
            gammaSlider.Value = currentSliderPosition;
            updateGamma();
        }

    }
}
