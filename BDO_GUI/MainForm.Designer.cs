namespace BDO_GUI
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
            this.btnToggleWorker = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWorkerStatus = new System.Windows.Forms.Label();
            this.grpBoxWorker = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnWorkerIcon = new BDO_GUI.CircularButton();
            this.btnWorkerBeerIcon = new System.Windows.Forms.Button();
            this.btnWorkerConfirmBtn = new System.Windows.Forms.Button();
            this.btnWorkerRecoverBtn = new System.Windows.Forms.Button();
            this.btnWorkerRepeatBtn = new System.Windows.Forms.Button();
            this.grpBoxProcessing = new System.Windows.Forms.GroupBox();
            this.lbxProcessingMaterials = new System.Windows.Forms.ListBox();
            this.btnProcessingRemoveMat = new System.Windows.Forms.Button();
            this.btnProcessingAddMat = new System.Windows.Forms.Button();
            this.lbxMaterials = new System.Windows.Forms.ListBox();
            this.chkProcessingVenecil = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAmityArea = new BDO_GUI.CircularButton();
            this.btnLeftArea = new System.Windows.Forms.Button();
            this.btnRightArea = new System.Windows.Forms.Button();
            this.btnMidArea = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnProcessingStorageProcessBtn = new System.Windows.Forms.Button();
            this.btnProcessingChoppingIcon = new BDO_GUI.CircularButton();
            this.btnProcessingHeatingIcon = new BDO_GUI.CircularButton();
            this.btnProcessingStartBtn = new System.Windows.Forms.Button();
            this.btnProcessingStorageBtn = new System.Windows.Forms.Button();
            this.btnToggleProcessing = new System.Windows.Forms.Button();
            this.lblProcessingStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.timerRepeat = new System.Windows.Forms.Timer(this.components);
            this.btnSaveCalibration = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCloseApp = new BDO_GUI.CircularButton();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.grpBoxWorker.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpBoxProcessing.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnToggleWorker
            // 
            this.btnToggleWorker.BackColor = System.Drawing.Color.White;
            this.btnToggleWorker.Location = new System.Drawing.Point(169, 20);
            this.btnToggleWorker.Name = "btnToggleWorker";
            this.btnToggleWorker.Size = new System.Drawing.Size(93, 33);
            this.btnToggleWorker.TabIndex = 0;
            this.btnToggleWorker.Text = "Toggle Worker";
            this.btnToggleWorker.UseVisualStyleBackColor = false;
            this.btnToggleWorker.Click += new System.EventHandler(this.btnToggleWorker_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status :";
            // 
            // lblWorkerStatus
            // 
            this.lblWorkerStatus.AutoSize = true;
            this.lblWorkerStatus.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.lblWorkerStatus.Location = new System.Drawing.Point(91, 29);
            this.lblWorkerStatus.Name = "lblWorkerStatus";
            this.lblWorkerStatus.Size = new System.Drawing.Size(30, 18);
            this.lblWorkerStatus.TabIndex = 2;
            this.lblWorkerStatus.Text = "Off";
            // 
            // grpBoxWorker
            // 
            this.grpBoxWorker.BackColor = System.Drawing.Color.White;
            this.grpBoxWorker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpBoxWorker.BackgroundImage")));
            this.grpBoxWorker.Controls.Add(this.groupBox3);
            this.grpBoxWorker.Controls.Add(this.label1);
            this.grpBoxWorker.Controls.Add(this.btnToggleWorker);
            this.grpBoxWorker.Controls.Add(this.lblWorkerStatus);
            this.grpBoxWorker.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.grpBoxWorker.Location = new System.Drawing.Point(12, 46);
            this.grpBoxWorker.Name = "grpBoxWorker";
            this.grpBoxWorker.Size = new System.Drawing.Size(277, 206);
            this.grpBoxWorker.TabIndex = 3;
            this.grpBoxWorker.TabStop = false;
            this.grpBoxWorker.Text = "Worker";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnWorkerIcon);
            this.groupBox3.Controls.Add(this.btnWorkerBeerIcon);
            this.groupBox3.Controls.Add(this.btnWorkerConfirmBtn);
            this.groupBox3.Controls.Add(this.btnWorkerRecoverBtn);
            this.groupBox3.Controls.Add(this.btnWorkerRepeatBtn);
            this.groupBox3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 119);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Target Location";
            // 
            // btnWorkerIcon
            // 
            this.btnWorkerIcon.FlatAppearance.BorderSize = 0;
            this.btnWorkerIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkerIcon.Image = ((System.Drawing.Image)(resources.GetObject("btnWorkerIcon.Image")));
            this.btnWorkerIcon.Location = new System.Drawing.Point(16, 27);
            this.btnWorkerIcon.Name = "btnWorkerIcon";
            this.btnWorkerIcon.Size = new System.Drawing.Size(45, 45);
            this.btnWorkerIcon.TabIndex = 7;
            this.btnWorkerIcon.UseVisualStyleBackColor = true;
            this.btnWorkerIcon.Click += new System.EventHandler(this.btnWorkerIcon_Click);
            // 
            // btnWorkerBeerIcon
            // 
            this.btnWorkerBeerIcon.FlatAppearance.BorderSize = 0;
            this.btnWorkerBeerIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkerBeerIcon.Image = ((System.Drawing.Image)(resources.GetObject("btnWorkerBeerIcon.Image")));
            this.btnWorkerBeerIcon.Location = new System.Drawing.Point(76, 27);
            this.btnWorkerBeerIcon.Name = "btnWorkerBeerIcon";
            this.btnWorkerBeerIcon.Size = new System.Drawing.Size(45, 45);
            this.btnWorkerBeerIcon.TabIndex = 7;
            this.btnWorkerBeerIcon.UseVisualStyleBackColor = true;
            this.btnWorkerBeerIcon.Click += new System.EventHandler(this.btnWorkerBeerIcon_Click);
            // 
            // btnWorkerConfirmBtn
            // 
            this.btnWorkerConfirmBtn.FlatAppearance.BorderSize = 0;
            this.btnWorkerConfirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkerConfirmBtn.Image = ((System.Drawing.Image)(resources.GetObject("btnWorkerConfirmBtn.Image")));
            this.btnWorkerConfirmBtn.Location = new System.Drawing.Point(9, 77);
            this.btnWorkerConfirmBtn.Name = "btnWorkerConfirmBtn";
            this.btnWorkerConfirmBtn.Size = new System.Drawing.Size(117, 30);
            this.btnWorkerConfirmBtn.TabIndex = 6;
            this.btnWorkerConfirmBtn.UseVisualStyleBackColor = true;
            this.btnWorkerConfirmBtn.Click += new System.EventHandler(this.btnWorkerConfirmBtn_Click);
            // 
            // btnWorkerRecoverBtn
            // 
            this.btnWorkerRecoverBtn.FlatAppearance.BorderSize = 0;
            this.btnWorkerRecoverBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkerRecoverBtn.Image = ((System.Drawing.Image)(resources.GetObject("btnWorkerRecoverBtn.Image")));
            this.btnWorkerRecoverBtn.Location = new System.Drawing.Point(139, 28);
            this.btnWorkerRecoverBtn.Name = "btnWorkerRecoverBtn";
            this.btnWorkerRecoverBtn.Size = new System.Drawing.Size(117, 35);
            this.btnWorkerRecoverBtn.TabIndex = 4;
            this.btnWorkerRecoverBtn.UseVisualStyleBackColor = true;
            this.btnWorkerRecoverBtn.Click += new System.EventHandler(this.btnWorkerRecoverBtn_Click);
            // 
            // btnWorkerRepeatBtn
            // 
            this.btnWorkerRepeatBtn.FlatAppearance.BorderSize = 0;
            this.btnWorkerRepeatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkerRepeatBtn.Image = ((System.Drawing.Image)(resources.GetObject("btnWorkerRepeatBtn.Image")));
            this.btnWorkerRepeatBtn.Location = new System.Drawing.Point(139, 72);
            this.btnWorkerRepeatBtn.Name = "btnWorkerRepeatBtn";
            this.btnWorkerRepeatBtn.Size = new System.Drawing.Size(117, 35);
            this.btnWorkerRepeatBtn.TabIndex = 5;
            this.btnWorkerRepeatBtn.UseVisualStyleBackColor = true;
            this.btnWorkerRepeatBtn.Click += new System.EventHandler(this.btnWorkerRepeatBtn_Click);
            // 
            // grpBoxProcessing
            // 
            this.grpBoxProcessing.BackColor = System.Drawing.Color.White;
            this.grpBoxProcessing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpBoxProcessing.BackgroundImage")));
            this.grpBoxProcessing.Controls.Add(this.lbxProcessingMaterials);
            this.grpBoxProcessing.Controls.Add(this.btnProcessingRemoveMat);
            this.grpBoxProcessing.Controls.Add(this.btnProcessingAddMat);
            this.grpBoxProcessing.Controls.Add(this.lbxMaterials);
            this.grpBoxProcessing.Controls.Add(this.chkProcessingVenecil);
            this.grpBoxProcessing.Controls.Add(this.groupBox1);
            this.grpBoxProcessing.Controls.Add(this.groupBox4);
            this.grpBoxProcessing.Controls.Add(this.btnToggleProcessing);
            this.grpBoxProcessing.Controls.Add(this.lblProcessingStatus);
            this.grpBoxProcessing.Controls.Add(this.label2);
            this.grpBoxProcessing.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.grpBoxProcessing.Location = new System.Drawing.Point(295, 46);
            this.grpBoxProcessing.Name = "grpBoxProcessing";
            this.grpBoxProcessing.Size = new System.Drawing.Size(538, 451);
            this.grpBoxProcessing.TabIndex = 4;
            this.grpBoxProcessing.TabStop = false;
            this.grpBoxProcessing.Text = "Processing";
            // 
            // lbxProcessingMaterials
            // 
            this.lbxProcessingMaterials.FormattingEnabled = true;
            this.lbxProcessingMaterials.ItemHeight = 21;
            this.lbxProcessingMaterials.Location = new System.Drawing.Point(340, 205);
            this.lbxProcessingMaterials.Name = "lbxProcessingMaterials";
            this.lbxProcessingMaterials.Size = new System.Drawing.Size(192, 235);
            this.lbxProcessingMaterials.TabIndex = 18;
            // 
            // btnProcessingRemoveMat
            // 
            this.btnProcessingRemoveMat.BackColor = System.Drawing.Color.White;
            this.btnProcessingRemoveMat.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessingRemoveMat.Location = new System.Drawing.Point(220, 262);
            this.btnProcessingRemoveMat.Name = "btnProcessingRemoveMat";
            this.btnProcessingRemoveMat.Size = new System.Drawing.Size(103, 35);
            this.btnProcessingRemoveMat.TabIndex = 17;
            this.btnProcessingRemoveMat.Text = "<<  Remove";
            this.btnProcessingRemoveMat.UseVisualStyleBackColor = false;
            this.btnProcessingRemoveMat.Click += new System.EventHandler(this.btnProcessingRemoveMat_Click);
            // 
            // btnProcessingAddMat
            // 
            this.btnProcessingAddMat.BackColor = System.Drawing.Color.White;
            this.btnProcessingAddMat.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessingAddMat.Location = new System.Drawing.Point(220, 205);
            this.btnProcessingAddMat.Name = "btnProcessingAddMat";
            this.btnProcessingAddMat.Size = new System.Drawing.Size(103, 35);
            this.btnProcessingAddMat.TabIndex = 16;
            this.btnProcessingAddMat.Text = "Add    >>";
            this.btnProcessingAddMat.UseVisualStyleBackColor = false;
            this.btnProcessingAddMat.Click += new System.EventHandler(this.btnProcessingAddMat_Click);
            // 
            // lbxMaterials
            // 
            this.lbxMaterials.FormattingEnabled = true;
            this.lbxMaterials.ItemHeight = 21;
            this.lbxMaterials.Location = new System.Drawing.Point(9, 205);
            this.lbxMaterials.Name = "lbxMaterials";
            this.lbxMaterials.Size = new System.Drawing.Size(192, 235);
            this.lbxMaterials.TabIndex = 15;
            // 
            // chkProcessingVenecil
            // 
            this.chkProcessingVenecil.AutoSize = true;
            this.chkProcessingVenecil.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.chkProcessingVenecil.Location = new System.Drawing.Point(362, 29);
            this.chkProcessingVenecil.Name = "chkProcessingVenecil";
            this.chkProcessingVenecil.Size = new System.Drawing.Size(161, 22);
            this.chkProcessingVenecil.TabIndex = 14;
            this.chkProcessingVenecil.Text = "Use Venecil Costume";
            this.chkProcessingVenecil.UseVisualStyleBackColor = true;
            this.chkProcessingVenecil.CheckedChanged += new System.EventHandler(this.chkProcessingVenecil_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnAmityArea);
            this.groupBox1.Controls.Add(this.btnLeftArea);
            this.groupBox1.Controls.Add(this.btnRightArea);
            this.groupBox1.Controls.Add(this.btnMidArea);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.groupBox1.Location = new System.Drawing.Point(262, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 118);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Target Area (After Open Storage)";
            // 
            // btnAmityArea
            // 
            this.btnAmityArea.FlatAppearance.BorderSize = 0;
            this.btnAmityArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmityArea.Image = ((System.Drawing.Image)(resources.GetObject("btnAmityArea.Image")));
            this.btnAmityArea.Location = new System.Drawing.Point(9, 32);
            this.btnAmityArea.Name = "btnAmityArea";
            this.btnAmityArea.Size = new System.Drawing.Size(75, 75);
            this.btnAmityArea.TabIndex = 14;
            this.btnAmityArea.UseVisualStyleBackColor = true;
            this.btnAmityArea.Click += new System.EventHandler(this.btnAmityArea_Click);
            // 
            // btnLeftArea
            // 
            this.btnLeftArea.BackColor = System.Drawing.Color.White;
            this.btnLeftArea.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.btnLeftArea.Location = new System.Drawing.Point(90, 24);
            this.btnLeftArea.Name = "btnLeftArea";
            this.btnLeftArea.Size = new System.Drawing.Size(74, 48);
            this.btnLeftArea.TabIndex = 10;
            this.btnLeftArea.Text = "Left Area";
            this.btnLeftArea.UseVisualStyleBackColor = false;
            this.btnLeftArea.Click += new System.EventHandler(this.btnLeftArea_Click);
            // 
            // btnRightArea
            // 
            this.btnRightArea.BackColor = System.Drawing.Color.White;
            this.btnRightArea.Location = new System.Drawing.Point(170, 24);
            this.btnRightArea.Name = "btnRightArea";
            this.btnRightArea.Size = new System.Drawing.Size(94, 48);
            this.btnRightArea.TabIndex = 12;
            this.btnRightArea.Text = "Inventory Window";
            this.btnRightArea.UseVisualStyleBackColor = false;
            this.btnRightArea.Click += new System.EventHandler(this.btnRightArea_Click);
            // 
            // btnMidArea
            // 
            this.btnMidArea.BackColor = System.Drawing.Color.White;
            this.btnMidArea.Location = new System.Drawing.Point(90, 75);
            this.btnMidArea.Name = "btnMidArea";
            this.btnMidArea.Size = new System.Drawing.Size(174, 37);
            this.btnMidArea.TabIndex = 11;
            this.btnMidArea.Text = "Storage Window Area";
            this.btnMidArea.UseVisualStyleBackColor = false;
            this.btnMidArea.Click += new System.EventHandler(this.btnMidArea_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btnProcessingStorageProcessBtn);
            this.groupBox4.Controls.Add(this.btnProcessingChoppingIcon);
            this.groupBox4.Controls.Add(this.btnProcessingHeatingIcon);
            this.groupBox4.Controls.Add(this.btnProcessingStartBtn);
            this.groupBox4.Controls.Add(this.btnProcessingStorageBtn);
            this.groupBox4.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.groupBox4.Location = new System.Drawing.Point(9, 80);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 119);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Target Location";
            // 
            // btnProcessingStorageProcessBtn
            // 
            this.btnProcessingStorageProcessBtn.FlatAppearance.BorderSize = 0;
            this.btnProcessingStorageProcessBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessingStorageProcessBtn.Image = ((System.Drawing.Image)(resources.GetObject("btnProcessingStorageProcessBtn.Image")));
            this.btnProcessingStorageProcessBtn.Location = new System.Drawing.Point(5, 81);
            this.btnProcessingStorageProcessBtn.Name = "btnProcessingStorageProcessBtn";
            this.btnProcessingStorageProcessBtn.Size = new System.Drawing.Size(101, 27);
            this.btnProcessingStorageProcessBtn.TabIndex = 10;
            this.btnProcessingStorageProcessBtn.UseVisualStyleBackColor = true;
            this.btnProcessingStorageProcessBtn.Click += new System.EventHandler(this.btnProcessingStorageProcessBtn_Click);
            // 
            // btnProcessingChoppingIcon
            // 
            this.btnProcessingChoppingIcon.FlatAppearance.BorderSize = 0;
            this.btnProcessingChoppingIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessingChoppingIcon.Image = ((System.Drawing.Image)(resources.GetObject("btnProcessingChoppingIcon.Image")));
            this.btnProcessingChoppingIcon.Location = new System.Drawing.Point(126, 20);
            this.btnProcessingChoppingIcon.Name = "btnProcessingChoppingIcon";
            this.btnProcessingChoppingIcon.Size = new System.Drawing.Size(50, 50);
            this.btnProcessingChoppingIcon.TabIndex = 9;
            this.btnProcessingChoppingIcon.UseVisualStyleBackColor = true;
            this.btnProcessingChoppingIcon.Click += new System.EventHandler(this.btnProcessingChoppingIcon_Click);
            // 
            // btnProcessingHeatingIcon
            // 
            this.btnProcessingHeatingIcon.FlatAppearance.BorderSize = 0;
            this.btnProcessingHeatingIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessingHeatingIcon.Image = ((System.Drawing.Image)(resources.GetObject("btnProcessingHeatingIcon.Image")));
            this.btnProcessingHeatingIcon.Location = new System.Drawing.Point(182, 20);
            this.btnProcessingHeatingIcon.Name = "btnProcessingHeatingIcon";
            this.btnProcessingHeatingIcon.Size = new System.Drawing.Size(50, 50);
            this.btnProcessingHeatingIcon.TabIndex = 8;
            this.btnProcessingHeatingIcon.UseVisualStyleBackColor = true;
            this.btnProcessingHeatingIcon.Click += new System.EventHandler(this.btnProcessingHeatingIcon_Click);
            // 
            // btnProcessingStartBtn
            // 
            this.btnProcessingStartBtn.FlatAppearance.BorderSize = 0;
            this.btnProcessingStartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessingStartBtn.Image = ((System.Drawing.Image)(resources.GetObject("btnProcessingStartBtn.Image")));
            this.btnProcessingStartBtn.Location = new System.Drawing.Point(116, 75);
            this.btnProcessingStartBtn.Name = "btnProcessingStartBtn";
            this.btnProcessingStartBtn.Size = new System.Drawing.Size(125, 35);
            this.btnProcessingStartBtn.TabIndex = 8;
            this.btnProcessingStartBtn.UseVisualStyleBackColor = true;
            this.btnProcessingStartBtn.Click += new System.EventHandler(this.btnProcessingStartBtn_Click);
            // 
            // btnProcessingStorageBtn
            // 
            this.btnProcessingStorageBtn.FlatAppearance.BorderSize = 0;
            this.btnProcessingStorageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessingStorageBtn.Image = ((System.Drawing.Image)(resources.GetObject("btnProcessingStorageBtn.Image")));
            this.btnProcessingStorageBtn.Location = new System.Drawing.Point(6, 27);
            this.btnProcessingStorageBtn.Name = "btnProcessingStorageBtn";
            this.btnProcessingStorageBtn.Size = new System.Drawing.Size(101, 27);
            this.btnProcessingStorageBtn.TabIndex = 5;
            this.btnProcessingStorageBtn.UseVisualStyleBackColor = true;
            this.btnProcessingStorageBtn.Click += new System.EventHandler(this.btnProcessingStorageBtn_Click);
            // 
            // btnToggleProcessing
            // 
            this.btnToggleProcessing.BackColor = System.Drawing.Color.White;
            this.btnToggleProcessing.Location = new System.Drawing.Point(143, 18);
            this.btnToggleProcessing.Name = "btnToggleProcessing";
            this.btnToggleProcessing.Size = new System.Drawing.Size(103, 35);
            this.btnToggleProcessing.TabIndex = 4;
            this.btnToggleProcessing.Text = "Toggle Processing";
            this.btnToggleProcessing.UseVisualStyleBackColor = false;
            this.btnToggleProcessing.Click += new System.EventHandler(this.btnToggleProcessing_Click);
            // 
            // lblProcessingStatus
            // 
            this.lblProcessingStatus.AutoSize = true;
            this.lblProcessingStatus.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.lblProcessingStatus.Location = new System.Drawing.Point(81, 28);
            this.lblProcessingStatus.Name = "lblProcessingStatus";
            this.lblProcessingStatus.Size = new System.Drawing.Size(30, 18);
            this.lblProcessingStatus.TabIndex = 3;
            this.lblProcessingStatus.Text = "Off";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(8, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Status :";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(196, 442);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(93, 55);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timerRepeat
            // 
            this.timerRepeat.Interval = 60000;
            // 
            // btnSaveCalibration
            // 
            this.btnSaveCalibration.Location = new System.Drawing.Point(12, 258);
            this.btnSaveCalibration.Name = "btnSaveCalibration";
            this.btnSaveCalibration.Size = new System.Drawing.Size(106, 55);
            this.btnSaveCalibration.TabIndex = 6;
            this.btnSaveCalibration.Text = "Save Calibration";
            this.btnSaveCalibration.UseVisualStyleBackColor = true;
            this.btnSaveCalibration.Click += new System.EventHandler(this.btnSaveCalibration_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 20F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "BDO Configuration";
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.FlatAppearance.BorderSize = 0;
            this.btnCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseApp.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseApp.Image")));
            this.btnCloseApp.Location = new System.Drawing.Point(807, 9);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(26, 26);
            this.btnCloseApp.TabIndex = 7;
            this.btnCloseApp.UseVisualStyleBackColor = true;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(12, 442);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(93, 55);
            this.btnSaveData.TabIndex = 9;
            this.btnSaveData.Text = "Save Data";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(844, 507);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.btnSaveCalibration);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grpBoxProcessing);
            this.Controls.Add(this.grpBoxWorker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BDO Configuration";
            this.grpBoxWorker.ResumeLayout(false);
            this.grpBoxWorker.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.grpBoxProcessing.ResumeLayout(false);
            this.grpBoxProcessing.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToggleWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWorkerStatus;
        private System.Windows.Forms.GroupBox grpBoxWorker;
        private System.Windows.Forms.GroupBox grpBoxProcessing;
        private System.Windows.Forms.Button btnToggleProcessing;
        private System.Windows.Forms.Label lblProcessingStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnWorkerConfirmBtn;
        private System.Windows.Forms.Button btnWorkerRepeatBtn;
        private System.Windows.Forms.Button btnWorkerRecoverBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnProcessingStorageBtn;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timerRepeat;
        private System.Windows.Forms.Button btnWorkerBeerIcon;
        private System.Windows.Forms.Button btnSaveCalibration;
        private CircularButton btnWorkerIcon;
        private CircularButton btnCloseApp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProcessingStartBtn;
        private System.Windows.Forms.Button btnLeftArea;
        private System.Windows.Forms.Button btnMidArea;
        private System.Windows.Forms.Button btnRightArea;
        private CircularButton btnProcessingHeatingIcon;
        private CircularButton btnProcessingChoppingIcon;
        private System.Windows.Forms.Button btnProcessingStorageProcessBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private CircularButton btnAmityArea;
        private System.Windows.Forms.CheckBox chkProcessingVenecil;
        private System.Windows.Forms.ListBox lbxProcessingMaterials;
        private System.Windows.Forms.Button btnProcessingRemoveMat;
        private System.Windows.Forms.Button btnProcessingAddMat;
        private System.Windows.Forms.ListBox lbxMaterials;
        private System.Windows.Forms.Button btnSaveData;
    }
}

