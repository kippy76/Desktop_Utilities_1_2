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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.ServiceProcess;

/*
 * Ver 1.2  Addition of Lorem Ipsum generator tab. 13/04/2012
 * Ver 1.1  Addition of 'Timer' tab to track time spent on development project phases for
 *              accurate client billing.
 *              Added '-gamma' command line option to silently apply last gamma setting.
 * Ver 1.0  Basic functionality.
 */

namespace DesktopUtilities
{
    public partial class MainForm : Form
    {
        private static int MAJOR_REVISION = 1;
        private static int MINOR_REVISION = 2;
        internal static bool initError = false;
        Services services;
        Gamma gamma;
        Colour colour;
        Timer timer;
        Lorem lorem;

        public MainForm(string[] args)
        {
            InitializeComponent();
            services = new Services(this);
            gamma = new Gamma(this);
            colour = new Colour(this);
            timer = new Timer(this);
            lorem = new Lorem(this);
            if ((args.Length > 0) && (args[0].ToLower().Equals("-gamma")))
            {
                gamma.initGamma();
                Environment.Exit(0);
            }
        }

        private void DesktopUtilities_Load(object sender, EventArgs e)
        {
            this.Text = "Desktop Utilities " + MAJOR_REVISION + "." + MINOR_REVISION;
            services.initServices();
            setFormPosition();
            gamma.initGamma();
            colour.initColour();
            lorem.initLorem();
            if (initError)
            {
                Environment.Exit(0);
            }
        }

        private void DesktopUtilities_Closing(object sender, FormClosingEventArgs e)
        {
            if (gamma != null)
            {
                gamma.saveGammaValue();
            }
        }

        private void setFormPosition()
        {
            int screenHeight, screenWidth, formWidth, formHeight, x, y;
            screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            // Find if form needs to be extended in length...
            int largestY = 0;
            Control.ControlCollection serviceControls = this.tabControl.TabPages[0].Controls;
            foreach (Control ctl in serviceControls)
            {
                if (ctl.Top > largestY)
                {
                    largestY = ctl.Top;
                }
            }
            int ctlCount = serviceControls.Count;
            int lineHeight = 3;
            formWidth = 295;
            formHeight = largestY < 204 + (lineHeight * ctlCount) ? 204 + (lineHeight * ctlCount) : largestY + (2 * lineHeight);
            this.Height = formHeight;
            this.Width = formWidth;
            this.tabControl.Height = formHeight;
            x = screenWidth - formWidth - 80;
            y = screenHeight - formHeight - 92;
            this.Location = new Point(x, y);
            this.Focus();
        }

        internal static DialogResult MessageBox(string message, MessageBoxButtons buttons, MessageBoxIcon iconType)
        {
            DialogResult result = System.Windows.Forms.MessageBox.Show(message, "", buttons, iconType);
            return result;
        }

    }
}
