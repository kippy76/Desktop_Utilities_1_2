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
using System.Reflection;
using System.Drawing;

namespace DesktopUtilities
{
    class Timer
    {
        private MainForm GUI;
        private enum state { START, STOP, PAUSE, RESET };
        private int CURRENTSTATE;
        private DateTime startTime;
        private DateTime stopTime;
        private TimeSpan timeElapsed;
        private int hours, mins, secs, msecs = 0;
        Assembly assembly;

        public Timer(MainForm GUI)
        {
            this.GUI = GUI;
            initHandlers();
            timeElapsed = TimeSpan.Zero;
            CURRENTSTATE = (int)state.STOP;
        }

        private void initHandlers()
        {
            GUI.btnTimerStart.Click += new EventHandler((object sender, EventArgs e) => start());
            GUI.btnTimerStop.Click += new EventHandler((object sender, EventArgs e) => stop());
            GUI.btnTimerPause.Click += new EventHandler((object sender, EventArgs e) => pause());
            GUI.btnTimerReset.Click += new EventHandler((object sender, EventArgs e) => reset());
            GUI.timerTimer.Interval = 50;
            GUI.timerTimer.Enabled = false;
            GUI.timerTimer.Tick += new EventHandler((object sender, EventArgs e) => updateTicker());
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
            assembly = Assembly.GetExecutingAssembly();
        }

        private void start()
        {
            if ((CURRENTSTATE == (int)state.STOP) || (CURRENTSTATE == (int)state.RESET))
            {
                timeElapsed = TimeSpan.Zero;
                startTime = DateTime.Now;
                stopTime = DateTime.Now;
            }
            if (CURRENTSTATE == (int)state.PAUSE)
            {
                TimeSpan lastCount = new TimeSpan(hours, mins, secs);
                lastCount += TimeSpan.FromMilliseconds(msecs);
                stopTime = DateTime.Now - lastCount;
                startTime = DateTime.Now;
            }
            CURRENTSTATE = (int)state.START;
            updateButtons();
            GUI.timerTimer.Enabled = true;
        }

        private void stop()
        {
            if ((CURRENTSTATE == (int)state.PAUSE) || (CURRENTSTATE == (int)state.START))
            {
                stopTime = DateTime.Now;
                CURRENTSTATE = (int)state.STOP;
                updateButtons();
            }
            GUI.timerTimer.Enabled = false;
        }

        private void pause()
        {
            if (CURRENTSTATE == (int)state.START)
            {
                stopTime = DateTime.Now;
                CURRENTSTATE = (int)state.PAUSE;
                updateButtons();
            }
            GUI.timerTimer.Enabled = false;
        }

        private void reset()
        {
            CURRENTSTATE = (int)state.RESET;
            updateButtons();
            hours = mins = secs = msecs = 0;
            updateTicker();
            GUI.timerTimer.Enabled = false;
        }

        private void updateTicker()
        {
            if (CURRENTSTATE == (int)state.RESET)
            {
                timeElapsed = TimeSpan.Zero;
            }
            else
                if (startTime.Ticks - stopTime.Ticks > 0)
                {
                    startTime = DateTime.Now;
                    timeElapsed = startTime - stopTime;
                }
                else
                {
                    stopTime = DateTime.Now;
                    timeElapsed = stopTime - startTime;
                }
            hours = timeElapsed.Hours;
            mins = timeElapsed.Minutes;
            secs = timeElapsed.Seconds;
            msecs = timeElapsed.Milliseconds;
            GUI.lblTimerCount.Text =
                String.Format("{0:00}", hours) + "h:  " +
                String.Format("{0:00}", mins) + "m:  " +
                String.Format("{0:00}", secs) + "s:  " +
                String.Format("{0:000}", msecs) + "ms";
        }

        private void updateButtons()
        {
            switch (CURRENTSTATE)
            {
                case (int)state.STOP:
                    GUI.btnTimerStop.BackgroundImage = new Bitmap(assembly.GetManifestResourceStream("DesktopUtilities.Resources.stopOn.png"));
                    GUI.btnTimerStart.BackgroundImage = new Bitmap(assembly.GetManifestResourceStream("DesktopUtilities.Resources.start.png"));
                    GUI.btnTimerPause.BackgroundImage = new Bitmap(assembly.GetManifestResourceStream("DesktopUtilities.Resources.pause.png"));
                    break;
                case (int)state.START:
                    GUI.btnTimerStart.BackgroundImage = new Bitmap(assembly.GetManifestResourceStream("DesktopUtilities.Resources.startOn.png"));
                    GUI.btnTimerStop.BackgroundImage = new Bitmap(assembly.GetManifestResourceStream("DesktopUtilities.Resources.stop2.png"));
                    GUI.btnTimerPause.BackgroundImage = new Bitmap(assembly.GetManifestResourceStream("DesktopUtilities.Resources.pause.png"));
                    break;
                case (int)state.PAUSE:
                    GUI.btnTimerPause.BackgroundImage = new Bitmap(assembly.GetManifestResourceStream("DesktopUtilities.Resources.pauseOn.png"));
                    GUI.btnTimerStop.BackgroundImage = new Bitmap(assembly.GetManifestResourceStream("DesktopUtilities.Resources.stop2.png"));
                    GUI.btnTimerStart.BackgroundImage = new Bitmap(assembly.GetManifestResourceStream("DesktopUtilities.Resources.start.png"));
                    break;
                case (int)state.RESET:
                    GUI.btnTimerStop.BackgroundImage = new Bitmap(assembly.GetManifestResourceStream("DesktopUtilities.Resources.stop2.png"));
                    GUI.btnTimerStart.BackgroundImage = new Bitmap(assembly.GetManifestResourceStream("DesktopUtilities.Resources.start.png"));
                    GUI.btnTimerPause.BackgroundImage = new Bitmap(assembly.GetManifestResourceStream("DesktopUtilities.Resources.pause.png"));
                    break;
            }
        }

    }
}

