namespace DesktopUtilities
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabServices = new System.Windows.Forms.TabPage();
            this.tabColourPicker = new System.Windows.Forms.TabPage();
            this.lblColL = new System.Windows.Forms.Label();
            this.lblColS = new System.Windows.Forms.Label();
            this.lblColH = new System.Windows.Forms.Label();
            this.txtColourL = new System.Windows.Forms.TextBox();
            this.txtColourS = new System.Windows.Forms.TextBox();
            this.txtColourH = new System.Windows.Forms.TextBox();
            this.lblColRGB3 = new System.Windows.Forms.Label();
            this.lblColRGB2 = new System.Windows.Forms.Label();
            this.lblColRGB1 = new System.Windows.Forms.Label();
            this.lblColB = new System.Windows.Forms.Label();
            this.lblColG = new System.Windows.Forms.Label();
            this.lblColR = new System.Windows.Forms.Label();
            this.txtColourBhex = new System.Windows.Forms.TextBox();
            this.txtColourGhex = new System.Windows.Forms.TextBox();
            this.txtColourRhex = new System.Windows.Forms.TextBox();
            this.txtColourBdec = new System.Windows.Forms.TextBox();
            this.txtColourGdec = new System.Windows.Forms.TextBox();
            this.txtColourRdec = new System.Windows.Forms.TextBox();
            this.txtColourRGBdecimal = new System.Windows.Forms.TextBox();
            this.txtColourRGBcss = new System.Windows.Forms.TextBox();
            this.txtColourRGB = new System.Windows.Forms.TextBox();
            this.lblColourSample = new System.Windows.Forms.Label();
            this.tabGamma = new System.Windows.Forms.TabPage();
            this.btnGammaDefault = new System.Windows.Forms.Button();
            this.lblGamma = new System.Windows.Forms.Label();
            this.sliderGamma = new System.Windows.Forms.TrackBar();
            this.tabTimer = new System.Windows.Forms.TabPage();
            this.btnTimerReset = new System.Windows.Forms.Button();
            this.lblTimerCount = new System.Windows.Forms.Label();
            this.btnTimerPause = new System.Windows.Forms.Button();
            this.btnTimerStop = new System.Windows.Forms.Button();
            this.btnTimerStart = new System.Windows.Forms.Button();
            this.tabLorem = new System.Windows.Forms.TabPage();
            this.prgLorem = new System.Windows.Forms.ProgressBar();
            this.txtLoremOutput = new System.Windows.Forms.TextBox();
            this.btnLoremGo = new System.Windows.Forms.Button();
            this.cmbLoremSelected = new System.Windows.Forms.ComboBox();
            this.lblLoremValue = new System.Windows.Forms.Label();
            this.trackBarLorem = new System.Windows.Forms.TrackBar();
            this.lblLorem = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.timerTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl.SuspendLayout();
            this.tabColourPicker.SuspendLayout();
            this.tabGamma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderGamma)).BeginInit();
            this.tabTimer.SuspendLayout();
            this.tabLorem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLorem)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabServices);
            this.tabControl.Controls.Add(this.tabColourPicker);
            this.tabControl.Controls.Add(this.tabGamma);
            this.tabControl.Controls.Add(this.tabTimer);
            this.tabControl.Controls.Add(this.tabLorem);
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(-2, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(290, 204);
            this.tabControl.TabIndex = 0;
            // 
            // tabServices
            // 
            this.tabServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabServices.Location = new System.Drawing.Point(4, 24);
            this.tabServices.Name = "tabServices";
            this.tabServices.Padding = new System.Windows.Forms.Padding(3);
            this.tabServices.Size = new System.Drawing.Size(282, 176);
            this.tabServices.TabIndex = 0;
            this.tabServices.Text = "Services";
            // 
            // tabColourPicker
            // 
            this.tabColourPicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabColourPicker.Controls.Add(this.lblColL);
            this.tabColourPicker.Controls.Add(this.lblColS);
            this.tabColourPicker.Controls.Add(this.lblColH);
            this.tabColourPicker.Controls.Add(this.txtColourL);
            this.tabColourPicker.Controls.Add(this.txtColourS);
            this.tabColourPicker.Controls.Add(this.txtColourH);
            this.tabColourPicker.Controls.Add(this.lblColRGB3);
            this.tabColourPicker.Controls.Add(this.lblColRGB2);
            this.tabColourPicker.Controls.Add(this.lblColRGB1);
            this.tabColourPicker.Controls.Add(this.lblColB);
            this.tabColourPicker.Controls.Add(this.lblColG);
            this.tabColourPicker.Controls.Add(this.lblColR);
            this.tabColourPicker.Controls.Add(this.txtColourBhex);
            this.tabColourPicker.Controls.Add(this.txtColourGhex);
            this.tabColourPicker.Controls.Add(this.txtColourRhex);
            this.tabColourPicker.Controls.Add(this.txtColourBdec);
            this.tabColourPicker.Controls.Add(this.txtColourGdec);
            this.tabColourPicker.Controls.Add(this.txtColourRdec);
            this.tabColourPicker.Controls.Add(this.txtColourRGBdecimal);
            this.tabColourPicker.Controls.Add(this.txtColourRGBcss);
            this.tabColourPicker.Controls.Add(this.txtColourRGB);
            this.tabColourPicker.Controls.Add(this.lblColourSample);
            this.tabColourPicker.Location = new System.Drawing.Point(4, 24);
            this.tabColourPicker.Name = "tabColourPicker";
            this.tabColourPicker.Padding = new System.Windows.Forms.Padding(3);
            this.tabColourPicker.Size = new System.Drawing.Size(282, 176);
            this.tabColourPicker.TabIndex = 1;
            this.tabColourPicker.Text = "Colour Picker";
            // 
            // lblColL
            // 
            this.lblColL.AutoSize = true;
            this.lblColL.Location = new System.Drawing.Point(128, 145);
            this.lblColL.Name = "lblColL";
            this.lblColL.Size = new System.Drawing.Size(16, 15);
            this.lblColL.TabIndex = 22;
            this.lblColL.Text = "L:";
            // 
            // lblColS
            // 
            this.lblColS.AutoSize = true;
            this.lblColS.Location = new System.Drawing.Point(128, 116);
            this.lblColS.Name = "lblColS";
            this.lblColS.Size = new System.Drawing.Size(16, 15);
            this.lblColS.TabIndex = 21;
            this.lblColS.Text = "S:";
            // 
            // lblColH
            // 
            this.lblColH.AutoSize = true;
            this.lblColH.Location = new System.Drawing.Point(128, 87);
            this.lblColH.Name = "lblColH";
            this.lblColH.Size = new System.Drawing.Size(19, 15);
            this.lblColH.TabIndex = 20;
            this.lblColH.Text = "H:";
            // 
            // txtColourL
            // 
            this.txtColourL.Location = new System.Drawing.Point(151, 142);
            this.txtColourL.Name = "txtColourL";
            this.txtColourL.Size = new System.Drawing.Size(25, 23);
            this.txtColourL.TabIndex = 19;
            // 
            // txtColourS
            // 
            this.txtColourS.Location = new System.Drawing.Point(151, 113);
            this.txtColourS.Name = "txtColourS";
            this.txtColourS.Size = new System.Drawing.Size(25, 23);
            this.txtColourS.TabIndex = 18;
            // 
            // txtColourH
            // 
            this.txtColourH.Location = new System.Drawing.Point(151, 84);
            this.txtColourH.Name = "txtColourH";
            this.txtColourH.Size = new System.Drawing.Size(25, 23);
            this.txtColourH.TabIndex = 17;
            // 
            // lblColRGB3
            // 
            this.lblColRGB3.AutoSize = true;
            this.lblColRGB3.Location = new System.Drawing.Point(3, 145);
            this.lblColRGB3.Name = "lblColRGB3";
            this.lblColRGB3.Size = new System.Drawing.Size(32, 15);
            this.lblColRGB3.TabIndex = 15;
            this.lblColRGB3.Text = "RGB:";
            // 
            // lblColRGB2
            // 
            this.lblColRGB2.AutoSize = true;
            this.lblColRGB2.Location = new System.Drawing.Point(3, 116);
            this.lblColRGB2.Name = "lblColRGB2";
            this.lblColRGB2.Size = new System.Drawing.Size(32, 15);
            this.lblColRGB2.TabIndex = 14;
            this.lblColRGB2.Text = "RGB:";
            // 
            // lblColRGB1
            // 
            this.lblColRGB1.AutoSize = true;
            this.lblColRGB1.Location = new System.Drawing.Point(3, 88);
            this.lblColRGB1.Name = "lblColRGB1";
            this.lblColRGB1.Size = new System.Drawing.Size(32, 15);
            this.lblColRGB1.TabIndex = 13;
            this.lblColRGB1.Text = "RGB:";
            // 
            // lblColB
            // 
            this.lblColB.AutoSize = true;
            this.lblColB.Location = new System.Drawing.Point(188, 145);
            this.lblColB.Name = "lblColB";
            this.lblColB.Size = new System.Drawing.Size(17, 15);
            this.lblColB.TabIndex = 12;
            this.lblColB.Text = "B:";
            // 
            // lblColG
            // 
            this.lblColG.AutoSize = true;
            this.lblColG.Location = new System.Drawing.Point(188, 116);
            this.lblColG.Name = "lblColG";
            this.lblColG.Size = new System.Drawing.Size(18, 15);
            this.lblColG.TabIndex = 11;
            this.lblColG.Text = "G:";
            // 
            // lblColR
            // 
            this.lblColR.AutoSize = true;
            this.lblColR.Location = new System.Drawing.Point(188, 88);
            this.lblColR.Name = "lblColR";
            this.lblColR.Size = new System.Drawing.Size(17, 15);
            this.lblColR.TabIndex = 10;
            this.lblColR.Text = "R:";
            // 
            // txtColourBhex
            // 
            this.txtColourBhex.Location = new System.Drawing.Point(238, 142);
            this.txtColourBhex.Name = "txtColourBhex";
            this.txtColourBhex.Size = new System.Drawing.Size(23, 23);
            this.txtColourBhex.TabIndex = 9;
            // 
            // txtColourGhex
            // 
            this.txtColourGhex.Location = new System.Drawing.Point(238, 113);
            this.txtColourGhex.Name = "txtColourGhex";
            this.txtColourGhex.Size = new System.Drawing.Size(23, 23);
            this.txtColourGhex.TabIndex = 8;
            // 
            // txtColourRhex
            // 
            this.txtColourRhex.Location = new System.Drawing.Point(238, 84);
            this.txtColourRhex.Name = "txtColourRhex";
            this.txtColourRhex.Size = new System.Drawing.Size(23, 23);
            this.txtColourRhex.TabIndex = 7;
            // 
            // txtColourBdec
            // 
            this.txtColourBdec.Location = new System.Drawing.Point(205, 142);
            this.txtColourBdec.Name = "txtColourBdec";
            this.txtColourBdec.Size = new System.Drawing.Size(25, 23);
            this.txtColourBdec.TabIndex = 6;
            // 
            // txtColourGdec
            // 
            this.txtColourGdec.Location = new System.Drawing.Point(205, 113);
            this.txtColourGdec.Name = "txtColourGdec";
            this.txtColourGdec.Size = new System.Drawing.Size(25, 23);
            this.txtColourGdec.TabIndex = 5;
            // 
            // txtColourRdec
            // 
            this.txtColourRdec.Location = new System.Drawing.Point(205, 85);
            this.txtColourRdec.Name = "txtColourRdec";
            this.txtColourRdec.Size = new System.Drawing.Size(25, 23);
            this.txtColourRdec.TabIndex = 4;
            // 
            // txtColourRGBdecimal
            // 
            this.txtColourRGBdecimal.Location = new System.Drawing.Point(37, 142);
            this.txtColourRGBdecimal.Name = "txtColourRGBdecimal";
            this.txtColourRGBdecimal.Size = new System.Drawing.Size(79, 23);
            this.txtColourRGBdecimal.TabIndex = 3;
            // 
            // txtColourRGBcss
            // 
            this.txtColourRGBcss.Location = new System.Drawing.Point(37, 113);
            this.txtColourRGBcss.Name = "txtColourRGBcss";
            this.txtColourRGBcss.Size = new System.Drawing.Size(59, 23);
            this.txtColourRGBcss.TabIndex = 2;
            // 
            // txtColourRGB
            // 
            this.txtColourRGB.Location = new System.Drawing.Point(37, 83);
            this.txtColourRGB.Name = "txtColourRGB";
            this.txtColourRGB.Size = new System.Drawing.Size(59, 23);
            this.txtColourRGB.TabIndex = 1;
            // 
            // lblColourSample
            // 
            this.lblColourSample.AutoSize = true;
            this.lblColourSample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColourSample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblColourSample.Image = global::DesktopUtilities.Properties.Resources.rgb;
            this.lblColourSample.Location = new System.Drawing.Point(101, 15);
            this.lblColourSample.MinimumSize = new System.Drawing.Size(80, 50);
            this.lblColourSample.Name = "lblColourSample";
            this.lblColourSample.Size = new System.Drawing.Size(80, 50);
            this.lblColourSample.TabIndex = 16;
            // 
            // tabGamma
            // 
            this.tabGamma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabGamma.Controls.Add(this.btnGammaDefault);
            this.tabGamma.Controls.Add(this.lblGamma);
            this.tabGamma.Controls.Add(this.sliderGamma);
            this.tabGamma.Location = new System.Drawing.Point(4, 24);
            this.tabGamma.Name = "tabGamma";
            this.tabGamma.Padding = new System.Windows.Forms.Padding(3);
            this.tabGamma.Size = new System.Drawing.Size(282, 176);
            this.tabGamma.TabIndex = 2;
            this.tabGamma.Text = "Gamma";
            // 
            // btnGammaDefault
            // 
            this.btnGammaDefault.Location = new System.Drawing.Point(91, 101);
            this.btnGammaDefault.Name = "btnGammaDefault";
            this.btnGammaDefault.Size = new System.Drawing.Size(101, 23);
            this.btnGammaDefault.TabIndex = 3;
            this.btnGammaDefault.Text = "Reset to Default";
            this.btnGammaDefault.UseVisualStyleBackColor = true;
            // 
            // lblGamma
            // 
            this.lblGamma.AutoSize = true;
            this.lblGamma.Location = new System.Drawing.Point(11, 68);
            this.lblGamma.Name = "lblGamma";
            this.lblGamma.Size = new System.Drawing.Size(55, 15);
            this.lblGamma.TabIndex = 2;
            this.lblGamma.Text = "Gamma: ";
            // 
            // sliderGamma
            // 
            this.sliderGamma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sliderGamma.Location = new System.Drawing.Point(10, 16);
            this.sliderGamma.Maximum = 42;
            this.sliderGamma.Minimum = 2;
            this.sliderGamma.Name = "sliderGamma";
            this.sliderGamma.Size = new System.Drawing.Size(266, 45);
            this.sliderGamma.TabIndex = 1;
            this.sliderGamma.TickFrequency = 4;
            this.sliderGamma.Value = 2;
            // 
            // tabTimer
            // 
            this.tabTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabTimer.Controls.Add(this.btnTimerReset);
            this.tabTimer.Controls.Add(this.lblTimerCount);
            this.tabTimer.Controls.Add(this.btnTimerPause);
            this.tabTimer.Controls.Add(this.btnTimerStop);
            this.tabTimer.Controls.Add(this.btnTimerStart);
            this.tabTimer.Location = new System.Drawing.Point(4, 24);
            this.tabTimer.Name = "tabTimer";
            this.tabTimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimer.Size = new System.Drawing.Size(282, 176);
            this.tabTimer.TabIndex = 3;
            this.tabTimer.Text = "Timer";
            // 
            // btnTimerReset
            // 
            this.btnTimerReset.BackColor = System.Drawing.Color.Transparent;
            this.btnTimerReset.BackgroundImage = global::DesktopUtilities.Properties.Resources.reset;
            this.btnTimerReset.FlatAppearance.BorderSize = 0;
            this.btnTimerReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimerReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimerReset.Location = new System.Drawing.Point(220, 42);
            this.btnTimerReset.Name = "btnTimerReset";
            this.btnTimerReset.Size = new System.Drawing.Size(20, 20);
            this.btnTimerReset.TabIndex = 4;
            this.btnTimerReset.Text = "R";
            this.btnTimerReset.UseVisualStyleBackColor = false;
            // 
            // lblTimerCount
            // 
            this.lblTimerCount.AutoSize = true;
            this.lblTimerCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimerCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerCount.Location = new System.Drawing.Point(41, 80);
            this.lblTimerCount.MinimumSize = new System.Drawing.Size(200, 15);
            this.lblTimerCount.Name = "lblTimerCount";
            this.lblTimerCount.Size = new System.Drawing.Size(200, 27);
            this.lblTimerCount.TabIndex = 3;
            // 
            // btnTimerPause
            // 
            this.btnTimerPause.BackgroundImage = global::DesktopUtilities.Properties.Resources.pause;
            this.btnTimerPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTimerPause.Location = new System.Drawing.Point(160, 22);
            this.btnTimerPause.Name = "btnTimerPause";
            this.btnTimerPause.Size = new System.Drawing.Size(40, 40);
            this.btnTimerPause.TabIndex = 2;
            this.btnTimerPause.UseVisualStyleBackColor = true;
            // 
            // btnTimerStop
            // 
            this.btnTimerStop.BackgroundImage = global::DesktopUtilities.Properties.Resources.stop2;
            this.btnTimerStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTimerStop.Location = new System.Drawing.Point(99, 22);
            this.btnTimerStop.Name = "btnTimerStop";
            this.btnTimerStop.Size = new System.Drawing.Size(40, 40);
            this.btnTimerStop.TabIndex = 1;
            this.btnTimerStop.UseVisualStyleBackColor = true;
            // 
            // btnTimerStart
            // 
            this.btnTimerStart.BackgroundImage = global::DesktopUtilities.Properties.Resources.start;
            this.btnTimerStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTimerStart.Location = new System.Drawing.Point(42, 22);
            this.btnTimerStart.Name = "btnTimerStart";
            this.btnTimerStart.Size = new System.Drawing.Size(40, 40);
            this.btnTimerStart.TabIndex = 0;
            this.btnTimerStart.UseVisualStyleBackColor = true;
            // 
            // tabLorem
            // 
            this.tabLorem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabLorem.Controls.Add(this.prgLorem);
            this.tabLorem.Controls.Add(this.txtLoremOutput);
            this.tabLorem.Controls.Add(this.btnLoremGo);
            this.tabLorem.Controls.Add(this.cmbLoremSelected);
            this.tabLorem.Controls.Add(this.lblLoremValue);
            this.tabLorem.Controls.Add(this.trackBarLorem);
            this.tabLorem.Controls.Add(this.lblLorem);
            this.tabLorem.Location = new System.Drawing.Point(4, 24);
            this.tabLorem.Name = "tabLorem";
            this.tabLorem.Padding = new System.Windows.Forms.Padding(3);
            this.tabLorem.Size = new System.Drawing.Size(282, 176);
            this.tabLorem.TabIndex = 4;
            this.tabLorem.Text = "Lorem";
            // 
            // prgLorem
            // 
            this.prgLorem.Location = new System.Drawing.Point(6, 160);
            this.prgLorem.Name = "prgLorem";
            this.prgLorem.Size = new System.Drawing.Size(270, 15);
            this.prgLorem.Step = 1;
            this.prgLorem.TabIndex = 7;
            // 
            // txtLoremOutput
            // 
            this.txtLoremOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtLoremOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoremOutput.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoremOutput.Location = new System.Drawing.Point(6, 87);
            this.txtLoremOutput.Multiline = true;
            this.txtLoremOutput.Name = "txtLoremOutput";
            this.txtLoremOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLoremOutput.Size = new System.Drawing.Size(270, 72);
            this.txtLoremOutput.TabIndex = 5;
            // 
            // btnLoremGo
            // 
            this.btnLoremGo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoremGo.Location = new System.Drawing.Point(183, 60);
            this.btnLoremGo.Name = "btnLoremGo";
            this.btnLoremGo.Size = new System.Drawing.Size(67, 21);
            this.btnLoremGo.TabIndex = 4;
            this.btnLoremGo.Text = "Generate";
            this.btnLoremGo.UseVisualStyleBackColor = true;
            // 
            // cmbLoremSelected
            // 
            this.cmbLoremSelected.FormattingEnabled = true;
            this.cmbLoremSelected.Location = new System.Drawing.Point(46, 60);
            this.cmbLoremSelected.Name = "cmbLoremSelected";
            this.cmbLoremSelected.Size = new System.Drawing.Size(118, 23);
            this.cmbLoremSelected.TabIndex = 3;
            // 
            // lblLoremValue
            // 
            this.lblLoremValue.AutoSize = true;
            this.lblLoremValue.Location = new System.Drawing.Point(10, 60);
            this.lblLoremValue.Name = "lblLoremValue";
            this.lblLoremValue.Size = new System.Drawing.Size(22, 15);
            this.lblLoremValue.TabIndex = 2;
            this.lblLoremValue.Text = ". . .";
            // 
            // trackBarLorem
            // 
            this.trackBarLorem.Location = new System.Drawing.Point(6, 21);
            this.trackBarLorem.Maximum = 100;
            this.trackBarLorem.Minimum = 1;
            this.trackBarLorem.Name = "trackBarLorem";
            this.trackBarLorem.Size = new System.Drawing.Size(270, 45);
            this.trackBarLorem.TabIndex = 1;
            this.trackBarLorem.TickFrequency = 10;
            this.trackBarLorem.Value = 1;
            // 
            // lblLorem
            // 
            this.lblLorem.AutoSize = true;
            this.lblLorem.Location = new System.Drawing.Point(3, 3);
            this.lblLorem.Name = "lblLorem";
            this.lblLorem.Size = new System.Drawing.Size(57, 15);
            this.lblLorem.TabIndex = 0;
            this.lblLorem.Text = "Generate:";
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.FullOpen = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(299, 209);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Desktop Utilities";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DesktopUtilities_Closing);
            this.Load += new System.EventHandler(this.DesktopUtilities_Load);
            this.tabControl.ResumeLayout(false);
            this.tabColourPicker.ResumeLayout(false);
            this.tabColourPicker.PerformLayout();
            this.tabGamma.ResumeLayout(false);
            this.tabGamma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderGamma)).EndInit();
            this.tabTimer.ResumeLayout(false);
            this.tabTimer.PerformLayout();
            this.tabLorem.ResumeLayout(false);
            this.tabLorem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLorem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.TabControl tabControl;
        protected internal System.Windows.Forms.TabPage tabServices;
        protected internal System.Windows.Forms.TabPage tabColourPicker;
        private System.Windows.Forms.Label lblGamma;
        protected internal System.Windows.Forms.TrackBar sliderGamma;
        protected internal System.Windows.Forms.Button btnGammaDefault;
        protected internal System.Windows.Forms.ColorDialog colorDialog;
        protected internal System.Windows.Forms.TabPage tabGamma;
        private System.Windows.Forms.Label lblColRGB3;
        private System.Windows.Forms.Label lblColRGB2;
        private System.Windows.Forms.Label lblColRGB1;
        private System.Windows.Forms.Label lblColB;
        private System.Windows.Forms.Label lblColG;
        private System.Windows.Forms.Label lblColR;
        protected internal System.Windows.Forms.Label lblColourSample;
        protected internal System.Windows.Forms.TextBox txtColourBhex;
        protected internal System.Windows.Forms.TextBox txtColourGhex;
        protected internal System.Windows.Forms.TextBox txtColourRhex;
        protected internal System.Windows.Forms.TextBox txtColourBdec;
        protected internal System.Windows.Forms.TextBox txtColourGdec;
        protected internal System.Windows.Forms.TextBox txtColourRdec;
        protected internal System.Windows.Forms.TextBox txtColourRGBdecimal;
        protected internal System.Windows.Forms.TextBox txtColourRGBcss;
        protected internal System.Windows.Forms.TextBox txtColourRGB;
        private System.Windows.Forms.Label lblColL;
        private System.Windows.Forms.Label lblColS;
        private System.Windows.Forms.Label lblColH;
        protected internal System.Windows.Forms.TextBox txtColourL;
        protected internal System.Windows.Forms.TextBox txtColourS;
        protected internal System.Windows.Forms.TextBox txtColourH;
        private System.Windows.Forms.TabPage tabTimer;
        protected internal System.Windows.Forms.Button btnTimerPause;
        protected internal System.Windows.Forms.Button btnTimerStop;
        protected internal System.Windows.Forms.Button btnTimerStart;
        protected internal System.Windows.Forms.Label lblTimerCount;
        protected internal System.Windows.Forms.Button btnTimerReset;
        protected internal System.Windows.Forms.Timer timerTimer;
        protected internal System.Windows.Forms.TabPage tabLorem;
        private System.Windows.Forms.Label lblLorem;
        protected internal System.Windows.Forms.TextBox txtLoremOutput;
        protected internal System.Windows.Forms.Button btnLoremGo;
        protected internal System.Windows.Forms.ComboBox cmbLoremSelected;
        protected internal System.Windows.Forms.Label lblLoremValue;
        protected internal System.Windows.Forms.TrackBar trackBarLorem;
        protected internal System.Windows.Forms.ProgressBar prgLorem;


    }
}

