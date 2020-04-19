namespace Simple_Stop_Animation
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listImages = new System.Windows.Forms.ListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImageDetails = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddImg = new System.Windows.Forms.Button();
            this.ChooseImgFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picturePreview = new System.Windows.Forms.PictureBox();
            this.btnRemoveImg = new System.Windows.Forms.Button();
            this.grpOutputOptions = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bitrate = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.FPS = new System.Windows.Forms.NumericUpDown();
            this.MovieWidth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MovieHeight = new System.Windows.Forms.NumericUpDown();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnStartWebCam = new System.Windows.Forms.Button();
            this.btnTakePicture = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.GrpControls = new System.Windows.Forms.GroupBox();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnNewProject = new System.Windows.Forms.Button();
            this.btnLoadProject = new System.Windows.Forms.Button();
            this.NewProjectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.ChooseProjectFile = new System.Windows.Forms.OpenFileDialog();
            this.grpCameraControl = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.trackBarSharpness = new System.Windows.Forms.TrackBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.trackBarGain = new System.Windows.Forms.TrackBar();
            this.btnResetCameraControls = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.trackBarExposure = new System.Windows.Forms.TrackBar();
            this.checkBoxAutoFocus = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.trackBarContrast = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.trackBarBrightness = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxOnionSkin = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).BeginInit();
            this.grpOutputOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bitrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovieWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovieHeight)).BeginInit();
            this.GrpControls.SuspendLayout();
            this.grpCameraControl.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSharpness)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGain)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarExposure)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            this.SuspendLayout();
            // 
            // listImages
            // 
            this.listImages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.ImageDetails,
            this.FilePath});
            this.listImages.FullRowSelect = true;
            this.listImages.GridLines = true;
            this.listImages.HideSelection = false;
            this.listImages.Location = new System.Drawing.Point(12, 61);
            this.listImages.MultiSelect = false;
            this.listImages.Name = "listImages";
            this.listImages.Size = new System.Drawing.Size(634, 317);
            this.listImages.TabIndex = 2;
            this.listImages.UseCompatibleStateImageBehavior = false;
            this.listImages.View = System.Windows.Forms.View.Details;
            this.listImages.SelectedIndexChanged += new System.EventHandler(this.listImages_SelectedIndexChanged);
            // 
            // FileName
            // 
            this.FileName.Text = "File Name";
            this.FileName.Width = 183;
            // 
            // ImageDetails
            // 
            this.ImageDetails.Text = "Image Details";
            this.ImageDetails.Width = 109;
            // 
            // FilePath
            // 
            this.FilePath.Text = "File Path";
            this.FilePath.Width = 1097;
            // 
            // btnAddImg
            // 
            this.btnAddImg.Location = new System.Drawing.Point(45, 31);
            this.btnAddImg.Name = "btnAddImg";
            this.btnAddImg.Size = new System.Drawing.Size(75, 39);
            this.btnAddImg.TabIndex = 3;
            this.btnAddImg.Text = "Add Image From File";
            this.btnAddImg.UseVisualStyleBackColor = true;
            this.btnAddImg.Click += new System.EventHandler(this.btnAddImg_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picturePreview);
            this.groupBox1.Location = new System.Drawing.Point(787, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 317);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Preview";
            // 
            // picturePreview
            // 
            this.picturePreview.Location = new System.Drawing.Point(6, 19);
            this.picturePreview.Name = "picturePreview";
            this.picturePreview.Size = new System.Drawing.Size(495, 292);
            this.picturePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePreview.TabIndex = 0;
            this.picturePreview.TabStop = false;
            // 
            // btnRemoveImg
            // 
            this.btnRemoveImg.Location = new System.Drawing.Point(45, 119);
            this.btnRemoveImg.Name = "btnRemoveImg";
            this.btnRemoveImg.Size = new System.Drawing.Size(75, 39);
            this.btnRemoveImg.TabIndex = 5;
            this.btnRemoveImg.Text = "Remove Image";
            this.btnRemoveImg.UseVisualStyleBackColor = true;
            this.btnRemoveImg.Click += new System.EventHandler(this.btnRemoveImg_Click);
            // 
            // grpOutputOptions
            // 
            this.grpOutputOptions.Controls.Add(this.label3);
            this.grpOutputOptions.Controls.Add(this.bitrate);
            this.grpOutputOptions.Controls.Add(this.label4);
            this.grpOutputOptions.Controls.Add(this.FPS);
            this.grpOutputOptions.Controls.Add(this.MovieWidth);
            this.grpOutputOptions.Controls.Add(this.label2);
            this.grpOutputOptions.Controls.Add(this.label1);
            this.grpOutputOptions.Controls.Add(this.MovieHeight);
            this.grpOutputOptions.Enabled = false;
            this.grpOutputOptions.Location = new System.Drawing.Point(652, 231);
            this.grpOutputOptions.Name = "grpOutputOptions";
            this.grpOutputOptions.Size = new System.Drawing.Size(129, 147);
            this.grpOutputOptions.TabIndex = 9;
            this.grpOutputOptions.TabStop = false;
            this.grpOutputOptions.Text = "Movie Output Options";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Birate:";
            // 
            // bitrate
            // 
            this.bitrate.Location = new System.Drawing.Point(48, 109);
            this.bitrate.Maximum = new decimal(new int[] {
            14000,
            0,
            0,
            0});
            this.bitrate.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.bitrate.Name = "bitrate";
            this.bitrate.Size = new System.Drawing.Size(64, 20);
            this.bitrate.TabIndex = 11;
            this.bitrate.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "FPS: ";
            // 
            // FPS
            // 
            this.FPS.Location = new System.Drawing.Point(48, 83);
            this.FPS.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.FPS.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FPS.Name = "FPS";
            this.FPS.Size = new System.Drawing.Size(55, 20);
            this.FPS.TabIndex = 8;
            this.FPS.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // MovieWidth
            // 
            this.MovieWidth.Location = new System.Drawing.Point(48, 29);
            this.MovieWidth.Maximum = new decimal(new int[] {
            16000,
            0,
            0,
            0});
            this.MovieWidth.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.MovieWidth.Name = "MovieWidth";
            this.MovieWidth.Size = new System.Drawing.Size(55, 20);
            this.MovieWidth.TabIndex = 4;
            this.MovieWidth.Value = new decimal(new int[] {
            1280,
            0,
            0,
            0});
            this.MovieWidth.ValueChanged += new System.EventHandler(this.MovieWidth_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Height:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Width:";
            // 
            // MovieHeight
            // 
            this.MovieHeight.Location = new System.Drawing.Point(48, 55);
            this.MovieHeight.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.MovieHeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.MovieHeight.Name = "MovieHeight";
            this.MovieHeight.Size = new System.Drawing.Size(55, 20);
            this.MovieHeight.TabIndex = 6;
            this.MovieHeight.Value = new decimal(new int[] {
            960,
            0,
            0,
            0});
            this.MovieHeight.ValueChanged += new System.EventHandler(this.MovieHeight_ValueChanged);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1212, 543);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(82, 32);
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnStartWebCam
            // 
            this.btnStartWebCam.Location = new System.Drawing.Point(45, 76);
            this.btnStartWebCam.Name = "btnStartWebCam";
            this.btnStartWebCam.Size = new System.Drawing.Size(75, 39);
            this.btnStartWebCam.TabIndex = 11;
            this.btnStartWebCam.Text = "Image From WebCam";
            this.btnStartWebCam.UseVisualStyleBackColor = true;
            this.btnStartWebCam.Click += new System.EventHandler(this.btnWebCam_Click);
            // 
            // btnTakePicture
            // 
            this.btnTakePicture.Location = new System.Drawing.Point(1180, 108);
            this.btnTakePicture.Name = "btnTakePicture";
            this.btnTakePicture.Size = new System.Drawing.Size(96, 39);
            this.btnTakePicture.TabIndex = 12;
            this.btnTakePicture.Text = "Take Picture";
            this.btnTakePicture.UseVisualStyleBackColor = true;
            this.btnTakePicture.Click += new System.EventHandler(this.btnTakePicture_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(1124, 543);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 32);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save Project";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // GrpControls
            // 
            this.GrpControls.Controls.Add(this.btnMoveDown);
            this.GrpControls.Controls.Add(this.btnMoveUp);
            this.GrpControls.Controls.Add(this.btnAddImg);
            this.GrpControls.Controls.Add(this.btnStartWebCam);
            this.GrpControls.Controls.Add(this.btnRemoveImg);
            this.GrpControls.Enabled = false;
            this.GrpControls.Location = new System.Drawing.Point(652, 61);
            this.GrpControls.Name = "GrpControls";
            this.GrpControls.Size = new System.Drawing.Size(126, 164);
            this.GrpControls.TabIndex = 14;
            this.GrpControls.TabStop = false;
            this.GrpControls.Text = "Controls";
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveDown.Image")));
            this.btnMoveDown.Location = new System.Drawing.Point(7, 88);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(22, 27);
            this.btnMoveDown.TabIndex = 13;
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveUp.Image")));
            this.btnMoveUp.Location = new System.Drawing.Point(7, 53);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(22, 27);
            this.btnMoveUp.TabIndex = 12;
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnNewProject
            // 
            this.btnNewProject.Location = new System.Drawing.Point(12, 12);
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Size = new System.Drawing.Size(81, 38);
            this.btnNewProject.TabIndex = 15;
            this.btnNewProject.Text = "Create New Project Folder";
            this.btnNewProject.UseVisualStyleBackColor = true;
            this.btnNewProject.Click += new System.EventHandler(this.btnNewProject_Click);
            // 
            // btnLoadProject
            // 
            this.btnLoadProject.Location = new System.Drawing.Point(99, 12);
            this.btnLoadProject.Name = "btnLoadProject";
            this.btnLoadProject.Size = new System.Drawing.Size(81, 38);
            this.btnLoadProject.TabIndex = 16;
            this.btnLoadProject.Text = "Load Project";
            this.btnLoadProject.UseVisualStyleBackColor = true;
            this.btnLoadProject.Click += new System.EventHandler(this.btnLoadProject_Click);
            // 
            // grpCameraControl
            // 
            this.grpCameraControl.Controls.Add(this.groupBox6);
            this.grpCameraControl.Controls.Add(this.groupBox5);
            this.grpCameraControl.Controls.Add(this.btnResetCameraControls);
            this.grpCameraControl.Controls.Add(this.groupBox4);
            this.grpCameraControl.Controls.Add(this.checkBoxAutoFocus);
            this.grpCameraControl.Controls.Add(this.groupBox3);
            this.grpCameraControl.Controls.Add(this.groupBox2);
            this.grpCameraControl.Controls.Add(this.label5);
            this.grpCameraControl.Controls.Add(this.btnTakePicture);
            this.grpCameraControl.Enabled = false;
            this.grpCameraControl.Location = new System.Drawing.Point(12, 384);
            this.grpCameraControl.Name = "grpCameraControl";
            this.grpCameraControl.Size = new System.Drawing.Size(1282, 153);
            this.grpCameraControl.TabIndex = 17;
            this.grpCameraControl.TabStop = false;
            this.grpCameraControl.Text = "Camera Control";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.trackBarSharpness);
            this.groupBox6.Location = new System.Drawing.Point(781, 78);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(187, 69);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Sharpness";
            // 
            // trackBarSharpness
            // 
            this.trackBarSharpness.Location = new System.Drawing.Point(6, 17);
            this.trackBarSharpness.Maximum = 24;
            this.trackBarSharpness.Name = "trackBarSharpness";
            this.trackBarSharpness.Size = new System.Drawing.Size(173, 45);
            this.trackBarSharpness.TabIndex = 13;
            this.trackBarSharpness.Value = 24;
            this.trackBarSharpness.Scroll += new System.EventHandler(this.trackBarSharpness_Scroll);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.trackBarGain);
            this.groupBox5.Location = new System.Drawing.Point(587, 78);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(187, 69);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Gain";
            // 
            // trackBarGain
            // 
            this.trackBarGain.Location = new System.Drawing.Point(6, 17);
            this.trackBarGain.Maximum = 300;
            this.trackBarGain.Name = "trackBarGain";
            this.trackBarGain.Size = new System.Drawing.Size(173, 45);
            this.trackBarGain.TabIndex = 13;
            this.trackBarGain.Value = 19;
            this.trackBarGain.Scroll += new System.EventHandler(this.trackBarGain_Scroll);
            // 
            // btnResetCameraControls
            // 
            this.btnResetCameraControls.Location = new System.Drawing.Point(1180, 14);
            this.btnResetCameraControls.Name = "btnResetCameraControls";
            this.btnResetCameraControls.Size = new System.Drawing.Size(96, 26);
            this.btnResetCameraControls.TabIndex = 19;
            this.btnResetCameraControls.Text = "Reset Controls";
            this.btnResetCameraControls.UseVisualStyleBackColor = true;
            this.btnResetCameraControls.Click += new System.EventHandler(this.btnResetCameraControls_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.trackBarExposure);
            this.groupBox4.Location = new System.Drawing.Point(394, 78);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(187, 69);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Exposure";
            // 
            // trackBarExposure
            // 
            this.trackBarExposure.Location = new System.Drawing.Point(6, 17);
            this.trackBarExposure.Maximum = 70;
            this.trackBarExposure.Name = "trackBarExposure";
            this.trackBarExposure.Size = new System.Drawing.Size(173, 45);
            this.trackBarExposure.TabIndex = 13;
            this.trackBarExposure.Value = 60;
            this.trackBarExposure.Scroll += new System.EventHandler(this.trackBarExposure_Scroll);
            // 
            // checkBoxAutoFocus
            // 
            this.checkBoxAutoFocus.AutoSize = true;
            this.checkBoxAutoFocus.Checked = true;
            this.checkBoxAutoFocus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoFocus.Location = new System.Drawing.Point(8, 45);
            this.checkBoxAutoFocus.Name = "checkBoxAutoFocus";
            this.checkBoxAutoFocus.Size = new System.Drawing.Size(80, 17);
            this.checkBoxAutoFocus.TabIndex = 18;
            this.checkBoxAutoFocus.Text = "Auto Focus";
            this.checkBoxAutoFocus.UseVisualStyleBackColor = true;
            this.checkBoxAutoFocus.CheckedChanged += new System.EventHandler(this.checkBoxAutoFocus_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.trackBarContrast);
            this.groupBox3.Location = new System.Drawing.Point(201, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 69);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contrast";
            // 
            // trackBarContrast
            // 
            this.trackBarContrast.Location = new System.Drawing.Point(6, 17);
            this.trackBarContrast.Maximum = 100;
            this.trackBarContrast.Name = "trackBarContrast";
            this.trackBarContrast.Size = new System.Drawing.Size(173, 45);
            this.trackBarContrast.TabIndex = 13;
            this.trackBarContrast.Value = 32;
            this.trackBarContrast.Scroll += new System.EventHandler(this.trackBarContrast_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trackBarBrightness);
            this.groupBox2.Location = new System.Drawing.Point(8, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 69);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Brightness";
            // 
            // trackBarBrightness
            // 
            this.trackBarBrightness.Location = new System.Drawing.Point(6, 17);
            this.trackBarBrightness.Maximum = 256;
            this.trackBarBrightness.Name = "trackBarBrightness";
            this.trackBarBrightness.Size = new System.Drawing.Size(173, 45);
            this.trackBarBrightness.TabIndex = 13;
            this.trackBarBrightness.Value = 128;
            this.trackBarBrightness.Scroll += new System.EventHandler(this.trackBarBrightness_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(664, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Please note that many of these settings are only available for high-end cameras. " +
    "Some settings will not work if your device doesn\'t support it.";
            // 
            // checkBoxOnionSkin
            // 
            this.checkBoxOnionSkin.AutoSize = true;
            this.checkBoxOnionSkin.Enabled = false;
            this.checkBoxOnionSkin.Location = new System.Drawing.Point(1216, 38);
            this.checkBoxOnionSkin.Name = "checkBoxOnionSkin";
            this.checkBoxOnionSkin.Size = new System.Drawing.Size(80, 17);
            this.checkBoxOnionSkin.TabIndex = 21;
            this.checkBoxOnionSkin.Text = "X-ray vision";
            this.checkBoxOnionSkin.UseVisualStyleBackColor = true;
            this.checkBoxOnionSkin.CheckedChanged += new System.EventHandler(this.checkBoxOnionSkin_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(565, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(81, 38);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 587);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.checkBoxOnionSkin);
            this.Controls.Add(this.grpCameraControl);
            this.Controls.Add(this.btnLoadProject);
            this.Controls.Add(this.btnNewProject);
            this.Controls.Add(this.GrpControls);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.grpOutputOptions);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listImages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Spencer\'s Simple Stop Motion Animation";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).EndInit();
            this.grpOutputOptions.ResumeLayout(false);
            this.grpOutputOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bitrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovieWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovieHeight)).EndInit();
            this.GrpControls.ResumeLayout(false);
            this.grpCameraControl.ResumeLayout(false);
            this.grpCameraControl.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSharpness)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGain)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarExposure)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listImages;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader ImageDetails;
        private System.Windows.Forms.ColumnHeader FilePath;
        private System.Windows.Forms.Button btnAddImg;
        private System.Windows.Forms.OpenFileDialog ChooseImgFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picturePreview;
        private System.Windows.Forms.Button btnRemoveImg;
        private System.Windows.Forms.GroupBox grpOutputOptions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown FPS;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnStartWebCam;
        private System.Windows.Forms.Button btnTakePicture;
        private System.Windows.Forms.NumericUpDown MovieWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown MovieHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown bitrate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox GrpControls;
        private System.Windows.Forms.Button btnNewProject;
        private System.Windows.Forms.Button btnLoadProject;
        private System.Windows.Forms.FolderBrowserDialog NewProjectFolder;
        private System.Windows.Forms.OpenFileDialog ChooseProjectFile;
        private System.Windows.Forms.GroupBox grpCameraControl;
        private System.Windows.Forms.TrackBar trackBarBrightness;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar trackBarContrast;
        private System.Windows.Forms.CheckBox checkBoxAutoFocus;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TrackBar trackBarExposure;
        private System.Windows.Forms.Button btnResetCameraControls;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TrackBar trackBarGain;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TrackBar trackBarSharpness;
        private System.Windows.Forms.CheckBox checkBoxOnionSkin;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
    }
}

