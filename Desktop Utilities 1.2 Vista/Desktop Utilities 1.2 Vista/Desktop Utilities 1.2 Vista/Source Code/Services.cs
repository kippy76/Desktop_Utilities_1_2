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
using System.ServiceProcess;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Drawing;

namespace DesktopUtilities
{
    class Services
    {
        Dictionary<string, string> services;
        Assembly assembly;
        MainForm GUI;
        System.Windows.Forms.Timer syncTimer;

        public Services(MainForm GUI)
        {
            assembly = Assembly.GetExecutingAssembly();
            this.GUI = GUI;
        }

        public void initServices()
        {
            string result = parseTextFile();
            if (!(String.IsNullOrEmpty(result)))
            {
                if (result.StartsWith("System.IndexOutOfRangeException"))
                {
                    MainForm.MessageBox("Error: Format error found in 'services.dat'\nProgram will now exit...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MainForm.initError = true;
                    return;
                }
                if (result.StartsWith("System.ArgumentException"))
                {
                    MainForm.MessageBox("Error: Duplicate service names found in\n'services.dat'\nProgram will now exit...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MainForm.initError = true;
                    return;
                }
                if (result.StartsWith("Error:"))
                {
                    MainForm.MessageBox(result + "\nProgram will now exit...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MainForm.initError = true;
                    return;
                }
                MainForm.MessageBox("Error: An unknown error occurred.\nProgram will now exit...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainForm.initError = true;
                return;
            }
            initControls();
            // Finally, a timer that keeps service status labels sync'd every second.
            syncTimer = new System.Windows.Forms.Timer();
            syncTimer.Interval = 500;
            syncTimer.Tick += new EventHandler((object sender, EventArgs e) => refreshStatus());
            syncTimer.Start();
        }

        private void initControls()
        {
            int x = 10;
            int currentX = x;
            int y = 10;
            int currentY = y;
            int yGap = 25;
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
            // Do headers first...
            Label lblH1 = new Label();
            lblH1.Text = "Services:";
            lblH1.Left = currentX;
            lblH1.Top = currentY;
            Label lblH2 = new Label();
            lblH2.Text = "Status:";
            lblH2.Left = currentX + 204;
            lblH2.Top = currentY;
            GUI.tabServices.Controls.Add(lblH1);
            GUI.tabServices.Controls.Add(lblH2);
            currentY += yGap + 10;
            foreach (string item in services.Keys)
            {
                string serviceVerboseName = item;
                Label label = new Label();
                Button btnPlay = new Button();
                Button btnStop = new Button();
                Label labelStatus = new Label();
                label.Text = serviceVerboseName.ToString();
                label.Width = 110;  // room for 17 characters
                label.Left = currentX;
                label.Top = currentY;
                currentX += 125;
                btnPlay.Name = "btn" + services[serviceVerboseName] + "Start";
                btnPlay.BackgroundImage = new Bitmap(assembly.GetManifestResourceStream("DesktopUtilities.Resources.play.png"));
                btnPlay.BackgroundImageLayout = ImageLayout.Stretch;
                btnPlay.Click += new EventHandler((object sender, EventArgs e) => startService(services[serviceVerboseName]));
                btnPlay.Left = currentX;
                btnPlay.Top = currentY - 5;
                btnPlay.Width = 28;
                btnPlay.Height = 23;
                currentX += 34;
                btnStop.Name = "btn" + services[serviceVerboseName] + "Stop";
                btnStop.BackgroundImage = new Bitmap(assembly.GetManifestResourceStream("DesktopUtilities.Resources.stop.png"));
                btnStop.BackgroundImageLayout = ImageLayout.Stretch;
                btnStop.Click += new EventHandler((object sender, EventArgs e) => stopService(services[serviceVerboseName]));
                btnStop.Left = currentX;
                btnStop.Top = currentY - 5;
                btnStop.Width = 28;
                btnStop.Height = 23;
                currentX += 45;
                labelStatus.Left = currentX;
                labelStatus.Top = currentY;
                labelStatus.Width = 55;
                labelStatus.Name = "lblStatus" + services[serviceVerboseName];
                GUI.tabServices.Controls.Add(label);
                GUI.tabServices.Controls.Add(btnPlay);
                GUI.tabServices.Controls.Add(btnStop);
                GUI.tabServices.Controls.Add(labelStatus);
                currentX = x;
                currentY += yGap;
                refreshStatus();
            }
            currentY += 10;
            Label footer = new Label();
            footer.Name = "lblServicesFooter";
            footer.Text = "(C) Christopher Walker 2012. License: GNU GPL 3";
            footer.Left = currentX - 10;
            footer.Top = currentY;
            footer.Width = 280;
            GUI.tabServices.Controls.Add(footer);          
        }

        private void startService(string serviceName)
        {
            ServiceController service = new ServiceController(serviceName);
            try
            {                                
                service.Start();               
            }
            catch
            {                
            }
        }

        private void stopService(string serviceName)
        {
            ServiceController service = new ServiceController(serviceName);
            try
            {
                service.Stop();
            }
            catch
            {                
            }
        }

        private bool getServiceStatus(string serviceName)
        {
            try
            {
                ServiceController service = new ServiceController(serviceName);
                if (service.Status.Equals(ServiceControllerStatus.Running))
                {
                    return true;
                }
            }
            catch (Exception)
            {
                // If service name is wrong, an exception will be thrown!
                MainForm.MessageBox("Error: 'services.dat' contains an unknown service name.\nProgram will now exit...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainForm.initError = true;
            }
            return false;
        }

        public void refreshStatus()
        {          
                foreach (Control ctl in this.GUI.tabServices.Controls)
                {
                    if (ctl.Name.StartsWith("lblStatus"))
                    {
                        string serviceName = ctl.Name.Substring(9);
                        bool running = getServiceStatus(serviceName);
                        ctl.Text = running ? "Running" : "Stopped";
                        ctl.ForeColor = running ? Color.Green : Color.Red;
                    }
                }
        }

        private string parseTextFile()
        {
            string fileLine = null;
            string[] args;
            char[] delimiters = { ',', '.', ':', '\t' };
            string verboseName = null;
            string serviceName = null;
            services = new Dictionary<string, string>();
            try
            {
                TextReader tr = new StreamReader("services.dat");
                fileLine = tr.ReadLine();
                if (String.IsNullOrEmpty(fileLine))
                {
                    return "Error: No services found in 'services.dat'";
                }
                do
                {
                    args = fileLine.Split(delimiters);
                    verboseName = args[0];
                    // Allow comments in source file...
                    if ((verboseName[0].Equals('#')) || (verboseName[0].Equals('/')))
                    {
                        fileLine = tr.ReadLine();
                        continue;
                    }
                    serviceName = args[1];
                    if (args.Length != 2)
                    {
                        return "Error: No valid service name found for :" + verboseName;
                    }
                    services.Add(verboseName, serviceName);
                    fileLine = tr.ReadLine();
                } while (!String.IsNullOrEmpty(fileLine));
                tr.Close();
            }
            catch (Exception e)
            {
                return e.ToString();
            }
            return null;
        }

    }
}
