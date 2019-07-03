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
            this.grpBoxProcessing = new System.Windows.Forms.GroupBox();
            this.chkProcessingContainer = new System.Windows.Forms.CheckBox();
            this.btnProcessingRemoveAllMat = new System.Windows.Forms.Button();
            this.lbxProcessingMaterials = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnProcessingRemoveMat = new System.Windows.Forms.Button();
            this.chkTrayApplication = new System.Windows.Forms.CheckBox();
            this.btnProcessingAddMat = new System.Windows.Forms.Button();
            this.btnToggleProcessing = new System.Windows.Forms.Button();
            this.lbxMaterials = new System.Windows.Forms.ListBox();
            this.chkProcessingVenecil = new System.Windows.Forms.CheckBox();
            this.lblProcessingStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.timerRepeat = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnCalibration = new System.Windows.Forms.Button();
            this.txtTargetApplicationName = new System.Windows.Forms.TextBox();
            this.lblTargetApplication = new System.Windows.Forms.Label();
            this.lblRepeatTimer = new System.Windows.Forms.Label();
            this.numRepeatTimer = new System.Windows.Forms.NumericUpDown();
            this.btnCloseApp = new BDO_GUI.CircularButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpBoxWorker.SuspendLayout();
            this.grpBoxProcessing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRepeatTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToggleWorker
            // 
            this.btnToggleWorker.BackColor = System.Drawing.Color.White;
            this.btnToggleWorker.Location = new System.Drawing.Point(184, 20);
            this.btnToggleWorker.Name = "btnToggleWorker";
            this.btnToggleWorker.Size = new System.Drawing.Size(78, 33);
            this.btnToggleWorker.TabIndex = 0;
            this.btnToggleWorker.Text = "Toggle";
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
            this.lblWorkerStatus.BackColor = System.Drawing.Color.Transparent;
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
            this.grpBoxWorker.Controls.Add(this.label1);
            this.grpBoxWorker.Controls.Add(this.btnToggleWorker);
            this.grpBoxWorker.Controls.Add(this.lblWorkerStatus);
            this.grpBoxWorker.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.grpBoxWorker.Location = new System.Drawing.Point(12, 117);
            this.grpBoxWorker.Name = "grpBoxWorker";
            this.grpBoxWorker.Size = new System.Drawing.Size(277, 64);
            this.grpBoxWorker.TabIndex = 3;
            this.grpBoxWorker.TabStop = false;
            this.grpBoxWorker.Text = "Worker";
            // 
            // grpBoxProcessing
            // 
            this.grpBoxProcessing.BackColor = System.Drawing.Color.White;
            this.grpBoxProcessing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpBoxProcessing.BackgroundImage")));
            this.grpBoxProcessing.Controls.Add(this.chkProcessingContainer);
            this.grpBoxProcessing.Controls.Add(this.btnProcessingRemoveAllMat);
            this.grpBoxProcessing.Controls.Add(this.lbxProcessingMaterials);
            this.grpBoxProcessing.Controls.Add(this.pictureBox1);
            this.grpBoxProcessing.Controls.Add(this.btnProcessingRemoveMat);
            this.grpBoxProcessing.Controls.Add(this.chkTrayApplication);
            this.grpBoxProcessing.Controls.Add(this.btnProcessingAddMat);
            this.grpBoxProcessing.Controls.Add(this.btnToggleProcessing);
            this.grpBoxProcessing.Controls.Add(this.lbxMaterials);
            this.grpBoxProcessing.Controls.Add(this.chkProcessingVenecil);
            this.grpBoxProcessing.Controls.Add(this.lblProcessingStatus);
            this.grpBoxProcessing.Controls.Add(this.label2);
            this.grpBoxProcessing.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.grpBoxProcessing.Location = new System.Drawing.Point(295, 46);
            this.grpBoxProcessing.Name = "grpBoxProcessing";
            this.grpBoxProcessing.Size = new System.Drawing.Size(538, 368);
            this.grpBoxProcessing.TabIndex = 4;
            this.grpBoxProcessing.TabStop = false;
            this.grpBoxProcessing.Text = "Processing";
            // 
            // chkProcessingContainer
            // 
            this.chkProcessingContainer.AutoSize = true;
            this.chkProcessingContainer.BackColor = System.Drawing.Color.Transparent;
            this.chkProcessingContainer.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.chkProcessingContainer.Location = new System.Drawing.Point(364, 43);
            this.chkProcessingContainer.Name = "chkProcessingContainer";
            this.chkProcessingContainer.Size = new System.Drawing.Size(118, 22);
            this.chkProcessingContainer.TabIndex = 20;
            this.chkProcessingContainer.Text = "Use Container";
            this.chkProcessingContainer.UseVisualStyleBackColor = false;
            this.chkProcessingContainer.CheckedChanged += new System.EventHandler(this.chkProcessingContainer_CheckedChanged);
            // 
            // btnProcessingRemoveAllMat
            // 
            this.btnProcessingRemoveAllMat.BackColor = System.Drawing.Color.White;
            this.btnProcessingRemoveAllMat.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessingRemoveAllMat.Location = new System.Drawing.Point(217, 256);
            this.btnProcessingRemoveAllMat.Name = "btnProcessingRemoveAllMat";
            this.btnProcessingRemoveAllMat.Size = new System.Drawing.Size(103, 35);
            this.btnProcessingRemoveAllMat.TabIndex = 19;
            this.btnProcessingRemoveAllMat.Text = "Clear All";
            this.btnProcessingRemoveAllMat.UseVisualStyleBackColor = false;
            this.btnProcessingRemoveAllMat.Click += new System.EventHandler(this.btnProcessingRemoveAllMat_Click);
            // 
            // lbxProcessingMaterials
            // 
            this.lbxProcessingMaterials.FormattingEnabled = true;
            this.lbxProcessingMaterials.ItemHeight = 21;
            this.lbxProcessingMaterials.Location = new System.Drawing.Point(333, 69);
            this.lbxProcessingMaterials.Name = "lbxProcessingMaterials";
            this.lbxProcessingMaterials.Size = new System.Drawing.Size(192, 235);
            this.lbxProcessingMaterials.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(333, 320);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 37);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnProcessingRemoveMat
            // 
            this.btnProcessingRemoveMat.BackColor = System.Drawing.Color.White;
            this.btnProcessingRemoveMat.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessingRemoveMat.Location = new System.Drawing.Point(217, 121);
            this.btnProcessingRemoveMat.Name = "btnProcessingRemoveMat";
            this.btnProcessingRemoveMat.Size = new System.Drawing.Size(103, 35);
            this.btnProcessingRemoveMat.TabIndex = 17;
            this.btnProcessingRemoveMat.Text = "<<  Remove";
            this.btnProcessingRemoveMat.UseVisualStyleBackColor = false;
            this.btnProcessingRemoveMat.Click += new System.EventHandler(this.btnProcessingRemoveMat_Click);
            // 
            // chkTrayApplication
            // 
            this.chkTrayApplication.AutoSize = true;
            this.chkTrayApplication.BackColor = System.Drawing.Color.Transparent;
            this.chkTrayApplication.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.chkTrayApplication.Location = new System.Drawing.Point(34, 327);
            this.chkTrayApplication.Name = "chkTrayApplication";
            this.chkTrayApplication.Size = new System.Drawing.Size(249, 25);
            this.chkTrayApplication.TabIndex = 14;
            this.chkTrayApplication.Text = "Hide Game After Processing";
            this.chkTrayApplication.UseVisualStyleBackColor = false;
            this.chkTrayApplication.CheckedChanged += new System.EventHandler(this.chkTrayApplication_CheckedChanged);
            // 
            // btnProcessingAddMat
            // 
            this.btnProcessingAddMat.BackColor = System.Drawing.Color.White;
            this.btnProcessingAddMat.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessingAddMat.Location = new System.Drawing.Point(217, 80);
            this.btnProcessingAddMat.Name = "btnProcessingAddMat";
            this.btnProcessingAddMat.Size = new System.Drawing.Size(103, 35);
            this.btnProcessingAddMat.TabIndex = 16;
            this.btnProcessingAddMat.Text = "Add    >>";
            this.btnProcessingAddMat.UseVisualStyleBackColor = false;
            this.btnProcessingAddMat.Click += new System.EventHandler(this.btnProcessingAddMat_Click);
            // 
            // btnToggleProcessing
            // 
            this.btnToggleProcessing.BackColor = System.Drawing.Color.White;
            this.btnToggleProcessing.Location = new System.Drawing.Point(164, 20);
            this.btnToggleProcessing.Name = "btnToggleProcessing";
            this.btnToggleProcessing.Size = new System.Drawing.Size(78, 33);
            this.btnToggleProcessing.TabIndex = 4;
            this.btnToggleProcessing.Text = "Toggle";
            this.btnToggleProcessing.UseVisualStyleBackColor = false;
            this.btnToggleProcessing.Click += new System.EventHandler(this.btnToggleProcessing_Click);
            // 
            // lbxMaterials
            // 
            this.lbxMaterials.FormattingEnabled = true;
            this.lbxMaterials.ItemHeight = 21;
            this.lbxMaterials.Location = new System.Drawing.Point(12, 69);
            this.lbxMaterials.Name = "lbxMaterials";
            this.lbxMaterials.Size = new System.Drawing.Size(192, 235);
            this.lbxMaterials.TabIndex = 15;
            // 
            // chkProcessingVenecil
            // 
            this.chkProcessingVenecil.AutoSize = true;
            this.chkProcessingVenecil.BackColor = System.Drawing.Color.Transparent;
            this.chkProcessingVenecil.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.chkProcessingVenecil.Location = new System.Drawing.Point(364, 15);
            this.chkProcessingVenecil.Name = "chkProcessingVenecil";
            this.chkProcessingVenecil.Size = new System.Drawing.Size(161, 22);
            this.chkProcessingVenecil.TabIndex = 14;
            this.chkProcessingVenecil.Text = "Use Venecil Costume";
            this.chkProcessingVenecil.UseVisualStyleBackColor = false;
            this.chkProcessingVenecil.CheckedChanged += new System.EventHandler(this.chkProcessingVenecil_CheckedChanged);
            // 
            // lblProcessingStatus
            // 
            this.lblProcessingStatus.AutoSize = true;
            this.lblProcessingStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblProcessingStatus.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.lblProcessingStatus.Location = new System.Drawing.Point(103, 29);
            this.lblProcessingStatus.Name = "lblProcessingStatus";
            this.lblProcessingStatus.Size = new System.Drawing.Size(30, 18);
            this.lblProcessingStatus.TabIndex = 3;
            this.lblProcessingStatus.Text = "Off";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(30, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Status :";
            // 
            // btnStartStop
            // 
            this.btnStartStop.BackColor = System.Drawing.Color.White;
            this.btnStartStop.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.btnStartStop.Location = new System.Drawing.Point(196, 373);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(93, 39);
            this.btnStartStop.TabIndex = 5;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = false;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // timerRepeat
            // 
            this.timerRepeat.Interval = 1000;
            this.timerRepeat.Tick += new System.EventHandler(this.timerRepeat_Tick);
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
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.lblTimer.Location = new System.Drawing.Point(30, 349);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 21);
            this.lblTimer.TabIndex = 10;
            // 
            // btnCalibration
            // 
            this.btnCalibration.BackColor = System.Drawing.Color.White;
            this.btnCalibration.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.btnCalibration.Location = new System.Drawing.Point(155, 187);
            this.btnCalibration.Name = "btnCalibration";
            this.btnCalibration.Size = new System.Drawing.Size(132, 53);
            this.btnCalibration.TabIndex = 13;
            this.btnCalibration.Text = "Calibration";
            this.btnCalibration.UseVisualStyleBackColor = false;
            this.btnCalibration.Click += new System.EventHandler(this.btnCalibration_Click);
            // 
            // txtTargetApplicationName
            // 
            this.txtTargetApplicationName.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.txtTargetApplicationName.Location = new System.Drawing.Point(129, 45);
            this.txtTargetApplicationName.Name = "txtTargetApplicationName";
            this.txtTargetApplicationName.Size = new System.Drawing.Size(160, 25);
            this.txtTargetApplicationName.TabIndex = 16;
            this.txtTargetApplicationName.TabStop = false;
            this.txtTargetApplicationName.Text = "Black Desert";
            // 
            // lblTargetApplication
            // 
            this.lblTargetApplication.AutoSize = true;
            this.lblTargetApplication.BackColor = System.Drawing.Color.Transparent;
            this.lblTargetApplication.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.lblTargetApplication.Location = new System.Drawing.Point(14, 46);
            this.lblTargetApplication.Name = "lblTargetApplication";
            this.lblTargetApplication.Size = new System.Drawing.Size(109, 21);
            this.lblTargetApplication.TabIndex = 17;
            this.lblTargetApplication.Text = "Target App. :";
            // 
            // lblRepeatTimer
            // 
            this.lblRepeatTimer.AutoSize = true;
            this.lblRepeatTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblRepeatTimer.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.lblRepeatTimer.Location = new System.Drawing.Point(15, 83);
            this.lblRepeatTimer.Name = "lblRepeatTimer";
            this.lblRepeatTimer.Size = new System.Drawing.Size(191, 18);
            this.lblRepeatTimer.TabIndex = 19;
            this.lblRepeatTimer.Text = "Repeat Timer (in minutes) :";
            // 
            // numRepeatTimer
            // 
            this.numRepeatTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numRepeatTimer.Location = new System.Drawing.Point(229, 78);
            this.numRepeatTimer.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numRepeatTimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRepeatTimer.Name = "numRepeatTimer";
            this.numRepeatTimer.Size = new System.Drawing.Size(60, 23);
            this.numRepeatTimer.TabIndex = 20;
            this.numRepeatTimer.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRepeatTimer.ValueChanged += new System.EventHandler(this.numRepeatTimer_ValueChanged);
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
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.btnSave.Location = new System.Drawing.Point(12, 373);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 39);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(844, 426);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numRepeatTimer);
            this.Controls.Add(this.lblRepeatTimer);
            this.Controls.Add(this.lblTargetApplication);
            this.Controls.Add(this.txtTargetApplicationName);
            this.Controls.Add(this.btnCalibration);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.grpBoxProcessing);
            this.Controls.Add(this.grpBoxWorker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BDO Configuration";
            this.grpBoxWorker.ResumeLayout(false);
            this.grpBoxWorker.PerformLayout();
            this.grpBoxProcessing.ResumeLayout(false);
            this.grpBoxProcessing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRepeatTimer)).EndInit();
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
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Timer timerRepeat;
        private CircularButton btnCloseApp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkProcessingVenecil;
        private System.Windows.Forms.ListBox lbxProcessingMaterials;
        private System.Windows.Forms.Button btnProcessingRemoveMat;
        private System.Windows.Forms.Button btnProcessingAddMat;
        private System.Windows.Forms.ListBox lbxMaterials;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnCalibration;
        private System.Windows.Forms.CheckBox chkTrayApplication;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnProcessingRemoveAllMat;
        private System.Windows.Forms.TextBox txtTargetApplicationName;
        private System.Windows.Forms.Label lblTargetApplication;
        private System.Windows.Forms.Label lblRepeatTimer;
        private System.Windows.Forms.NumericUpDown numRepeatTimer;
        private System.Windows.Forms.CheckBox chkProcessingContainer;
        private System.Windows.Forms.Button btnSave;
    }
}

