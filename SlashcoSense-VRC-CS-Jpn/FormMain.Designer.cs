namespace SlashcoSense_VRC_CS_Jpn
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSlasher = new System.Windows.Forms.Label();
            this.groupBoxG = new System.Windows.Forms.GroupBox();
            this.checkBoxG2Battery = new System.Windows.Forms.CheckBox();
            this.checkBoxG1Battery = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBarG2Fuel = new System.Windows.Forms.ProgressBar();
            this.progressBarG1Fuel = new System.Windows.Forms.ProgressBar();
            this.labelG2Fuel = new System.Windows.Forms.Label();
            this.labelG1Fuel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxOSC = new System.Windows.Forms.GroupBox();
            this.numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            this.checkBoxOSC = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fileSystemWatcherLog = new System.IO.FileSystemWatcher();
            this.groupBox1.SuspendLayout();
            this.groupBoxG.SuspendLayout();
            this.groupBoxOSC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcherLog)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelSlasher);
            this.groupBox1.Controls.Add(this.groupBoxG);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ゲーム情報";
            // 
            // labelSlasher
            // 
            this.labelSlasher.AutoSize = true;
            this.labelSlasher.Font = new System.Drawing.Font("Noto Serif JP", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSlasher.Location = new System.Drawing.Point(80, 15);
            this.labelSlasher.Name = "labelSlasher";
            this.labelSlasher.Size = new System.Drawing.Size(32, 17);
            this.labelSlasher.TabIndex = 4;
            this.labelSlasher.Text = "不明";
            // 
            // groupBoxG
            // 
            this.groupBoxG.Controls.Add(this.checkBoxG2Battery);
            this.groupBoxG.Controls.Add(this.checkBoxG1Battery);
            this.groupBoxG.Controls.Add(this.label3);
            this.groupBoxG.Controls.Add(this.progressBarG2Fuel);
            this.groupBoxG.Controls.Add(this.progressBarG1Fuel);
            this.groupBoxG.Controls.Add(this.labelG2Fuel);
            this.groupBoxG.Controls.Add(this.labelG1Fuel);
            this.groupBoxG.Location = new System.Drawing.Point(10, 50);
            this.groupBoxG.Name = "groupBoxG";
            this.groupBoxG.Size = new System.Drawing.Size(320, 100);
            this.groupBoxG.TabIndex = 2;
            this.groupBoxG.TabStop = false;
            this.groupBoxG.Text = "ジェネレーター";
            // 
            // checkBoxG2Battery
            // 
            this.checkBoxG2Battery.AutoSize = true;
            this.checkBoxG2Battery.Location = new System.Drawing.Point(240, 55);
            this.checkBoxG2Battery.Name = "checkBoxG2Battery";
            this.checkBoxG2Battery.Size = new System.Drawing.Size(67, 16);
            this.checkBoxG2Battery.TabIndex = 8;
            this.checkBoxG2Battery.Text = "バッテリー";
            this.checkBoxG2Battery.UseVisualStyleBackColor = true;
            // 
            // checkBoxG1Battery
            // 
            this.checkBoxG1Battery.AutoSize = true;
            this.checkBoxG1Battery.Location = new System.Drawing.Point(240, 25);
            this.checkBoxG1Battery.Name = "checkBoxG1Battery";
            this.checkBoxG1Battery.Size = new System.Drawing.Size(67, 16);
            this.checkBoxG1Battery.TabIndex = 7;
            this.checkBoxG1Battery.Text = "バッテリー";
            this.checkBoxG1Battery.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "ジェネレーターの監視はゲーム中のみ利用できます";
            // 
            // progressBarG2Fuel
            // 
            this.progressBarG2Fuel.Location = new System.Drawing.Point(70, 55);
            this.progressBarG2Fuel.Maximum = 4;
            this.progressBarG2Fuel.Name = "progressBarG2Fuel";
            this.progressBarG2Fuel.Size = new System.Drawing.Size(160, 20);
            this.progressBarG2Fuel.TabIndex = 3;
            // 
            // progressBarG1Fuel
            // 
            this.progressBarG1Fuel.Location = new System.Drawing.Point(70, 25);
            this.progressBarG1Fuel.Maximum = 4;
            this.progressBarG1Fuel.Name = "progressBarG1Fuel";
            this.progressBarG1Fuel.Size = new System.Drawing.Size(160, 20);
            this.progressBarG1Fuel.TabIndex = 2;
            // 
            // labelG2Fuel
            // 
            this.labelG2Fuel.AutoSize = true;
            this.labelG2Fuel.Location = new System.Drawing.Point(10, 60);
            this.labelG2Fuel.Name = "labelG2Fuel";
            this.labelG2Fuel.Size = new System.Drawing.Size(53, 12);
            this.labelG2Fuel.TabIndex = 1;
            this.labelG2Fuel.Text = "燃料: 0/4";
            // 
            // labelG1Fuel
            // 
            this.labelG1Fuel.AutoSize = true;
            this.labelG1Fuel.Location = new System.Drawing.Point(10, 30);
            this.labelG1Fuel.Name = "labelG1Fuel";
            this.labelG1Fuel.Size = new System.Drawing.Size(53, 12);
            this.labelG1Fuel.TabIndex = 0;
            this.labelG1Fuel.Text = "燃料: 0/4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "スラッシャー: ";
            // 
            // groupBoxOSC
            // 
            this.groupBoxOSC.Controls.Add(this.numericUpDownPort);
            this.groupBoxOSC.Controls.Add(this.checkBoxOSC);
            this.groupBoxOSC.Controls.Add(this.label5);
            this.groupBoxOSC.Location = new System.Drawing.Point(12, 170);
            this.groupBoxOSC.Name = "groupBoxOSC";
            this.groupBoxOSC.Size = new System.Drawing.Size(340, 50);
            this.groupBoxOSC.TabIndex = 2;
            this.groupBoxOSC.TabStop = false;
            this.groupBoxOSC.Text = "OSC";
            // 
            // numericUpDownPort
            // 
            this.numericUpDownPort.Location = new System.Drawing.Point(160, 15);
            this.numericUpDownPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownPort.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.Size = new System.Drawing.Size(60, 19);
            this.numericUpDownPort.TabIndex = 2;
            this.numericUpDownPort.Value = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.numericUpDownPort.ValueChanged += new System.EventHandler(this.NumericUpDownPort_ValueChanged);
            // 
            // checkBoxOSC
            // 
            this.checkBoxOSC.AutoSize = true;
            this.checkBoxOSC.Checked = true;
            this.checkBoxOSC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOSC.Location = new System.Drawing.Point(10, 20);
            this.checkBoxOSC.Name = "checkBoxOSC";
            this.checkBoxOSC.Size = new System.Drawing.Size(83, 16);
            this.checkBoxOSC.TabIndex = 1;
            this.checkBoxOSC.Text = "OSC有効化";
            this.checkBoxOSC.UseVisualStyleBackColor = true;
            this.checkBoxOSC.CheckedChanged += new System.EventHandler(this.CheckBoxOSC_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "ポート";
            // 
            // fileSystemWatcherLog
            // 
            this.fileSystemWatcherLog.EnableRaisingEvents = true;
            this.fileSystemWatcherLog.Filter = "output_*.txt";
            this.fileSystemWatcherLog.NotifyFilter = System.IO.NotifyFilters.LastWrite;
            this.fileSystemWatcherLog.SynchronizingObject = this;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 231);
            this.Controls.Add(this.groupBoxOSC);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "SlashcoSense-VRC-CS-Jpn By:arcxingye & Raru37m";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxG.ResumeLayout(false);
            this.groupBoxG.PerformLayout();
            this.groupBoxOSC.ResumeLayout(false);
            this.groupBoxOSC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcherLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelG1Fuel;
        private System.Windows.Forms.Label labelG2Fuel;
        private System.Windows.Forms.ProgressBar progressBarG2Fuel;
        private System.Windows.Forms.ProgressBar progressBarG1Fuel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxOSC;
        private System.Windows.Forms.NumericUpDown numericUpDownPort;
        private System.Windows.Forms.CheckBox checkBoxOSC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelSlasher;
        private System.Windows.Forms.CheckBox checkBoxG2Battery;
        private System.Windows.Forms.CheckBox checkBoxG1Battery;
        private System.IO.FileSystemWatcher fileSystemWatcherLog;
    }
}

