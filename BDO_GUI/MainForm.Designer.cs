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
            this.btnToggleWorker = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.workerStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnWorkerConfirmLocation = new System.Windows.Forms.Button();
            this.btnWorkerRepeatLocation = new System.Windows.Forms.Button();
            this.btnWorkerRecoverLocation = new System.Windows.Forms.Button();
            this.btnWorkerIconLocation = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnProcessingStorageLocation = new System.Windows.Forms.Button();
            this.btnToggleProcessing = new System.Windows.Forms.Button();
            this.processStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnToggleWorker
            // 
            this.btnToggleWorker.Location = new System.Drawing.Point(101, 21);
            this.btnToggleWorker.Name = "btnToggleWorker";
            this.btnToggleWorker.Size = new System.Drawing.Size(93, 23);
            this.btnToggleWorker.TabIndex = 0;
            this.btnToggleWorker.Text = "Toggle Worker";
            this.btnToggleWorker.UseVisualStyleBackColor = true;
            this.btnToggleWorker.Click += new System.EventHandler(this.btnToggleWorker_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status:";
            // 
            // workerStatus
            // 
            this.workerStatus.AutoSize = true;
            this.workerStatus.Location = new System.Drawing.Point(54, 26);
            this.workerStatus.Name = "workerStatus";
            this.workerStatus.Size = new System.Drawing.Size(0, 13);
            this.workerStatus.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnToggleWorker);
            this.groupBox1.Controls.Add(this.workerStatus);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 165);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnWorkerConfirmLocation);
            this.groupBox3.Controls.Add(this.btnWorkerRepeatLocation);
            this.groupBox3.Controls.Add(this.btnWorkerRecoverLocation);
            this.groupBox3.Controls.Add(this.btnWorkerIconLocation);
            this.groupBox3.Location = new System.Drawing.Point(6, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 106);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Target Location";
            // 
            // btnWorkerConfirmLocation
            // 
            this.btnWorkerConfirmLocation.Location = new System.Drawing.Point(51, 77);
            this.btnWorkerConfirmLocation.Name = "btnWorkerConfirmLocation";
            this.btnWorkerConfirmLocation.Size = new System.Drawing.Size(77, 23);
            this.btnWorkerConfirmLocation.TabIndex = 6;
            this.btnWorkerConfirmLocation.Text = "Confirm";
            this.btnWorkerConfirmLocation.UseVisualStyleBackColor = true;
            this.btnWorkerConfirmLocation.Click += new System.EventHandler(this.btnWorkerConfirmLocation_Click);
            // 
            // btnWorkerRepeatLocation
            // 
            this.btnWorkerRepeatLocation.Location = new System.Drawing.Point(94, 48);
            this.btnWorkerRepeatLocation.Name = "btnWorkerRepeatLocation";
            this.btnWorkerRepeatLocation.Size = new System.Drawing.Size(88, 23);
            this.btnWorkerRepeatLocation.TabIndex = 5;
            this.btnWorkerRepeatLocation.Text = "Repeat All";
            this.btnWorkerRepeatLocation.UseVisualStyleBackColor = true;
            this.btnWorkerRepeatLocation.Click += new System.EventHandler(this.btnWorkerRepeatLocation_Click);
            // 
            // btnWorkerRecoverLocation
            // 
            this.btnWorkerRecoverLocation.Location = new System.Drawing.Point(6, 48);
            this.btnWorkerRecoverLocation.Name = "btnWorkerRecoverLocation";
            this.btnWorkerRecoverLocation.Size = new System.Drawing.Size(88, 23);
            this.btnWorkerRecoverLocation.TabIndex = 4;
            this.btnWorkerRecoverLocation.Text = "Recover All";
            this.btnWorkerRecoverLocation.UseVisualStyleBackColor = true;
            this.btnWorkerRecoverLocation.Click += new System.EventHandler(this.btnWorkerRecoverLocation_Click);
            // 
            // btnWorkerIconLocation
            // 
            this.btnWorkerIconLocation.Location = new System.Drawing.Point(6, 19);
            this.btnWorkerIconLocation.Name = "btnWorkerIconLocation";
            this.btnWorkerIconLocation.Size = new System.Drawing.Size(176, 23);
            this.btnWorkerIconLocation.TabIndex = 3;
            this.btnWorkerIconLocation.Text = "Worker Icon";
            this.btnWorkerIconLocation.UseVisualStyleBackColor = true;
            this.btnWorkerIconLocation.Click += new System.EventHandler(this.btnWorkerIconLocation_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.btnToggleProcessing);
            this.groupBox2.Controls.Add(this.processStatus);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 165);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Processing";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnProcessingStorageLocation);
            this.groupBox4.Location = new System.Drawing.Point(5, 53);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(443, 106);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Target Location";
            // 
            // btnProcessingStorageLocation
            // 
            this.btnProcessingStorageLocation.Location = new System.Drawing.Point(6, 19);
            this.btnProcessingStorageLocation.Name = "btnProcessingStorageLocation";
            this.btnProcessingStorageLocation.Size = new System.Drawing.Size(75, 23);
            this.btnProcessingStorageLocation.TabIndex = 5;
            this.btnProcessingStorageLocation.Text = "Storage";
            this.btnProcessingStorageLocation.UseVisualStyleBackColor = true;
            // 
            // btnToggleProcessing
            // 
            this.btnToggleProcessing.Location = new System.Drawing.Point(90, 21);
            this.btnToggleProcessing.Name = "btnToggleProcessing";
            this.btnToggleProcessing.Size = new System.Drawing.Size(103, 23);
            this.btnToggleProcessing.TabIndex = 4;
            this.btnToggleProcessing.Text = "Toggle Processing";
            this.btnToggleProcessing.UseVisualStyleBackColor = true;
            // 
            // processStatus
            // 
            this.processStatus.AutoSize = true;
            this.processStatus.Location = new System.Drawing.Point(54, 26);
            this.processStatus.Name = "processStatus";
            this.processStatus.Size = new System.Drawing.Size(0, 13);
            this.processStatus.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Status:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(597, 183);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3600000;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 208);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "BDO Configuration";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToggleWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label workerStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnWorkerIconLocation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnToggleProcessing;
        private System.Windows.Forms.Label processStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnWorkerConfirmLocation;
        private System.Windows.Forms.Button btnWorkerRepeatLocation;
        private System.Windows.Forms.Button btnWorkerRecoverLocation;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnProcessingStorageLocation;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
    }
}

