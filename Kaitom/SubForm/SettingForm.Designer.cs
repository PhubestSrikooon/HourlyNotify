namespace Kaitom.SubForm
{
    partial class SettingForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SoundDataGridView = new System.Windows.Forms.DataGridView();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.File = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlertTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllSoundsLabel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.OverallSoundVolumeText = new System.Windows.Forms.Label();
            this.AutoRun = new System.Windows.Forms.CheckBox();
            this.SettingLabel = new System.Windows.Forms.Label();
            this.SaveAndExitBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.edit = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.AddItems = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoundDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SoundDataGridView);
            this.panel1.Controls.Add(this.AllSoundsLabel);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.OverallSoundVolumeText);
            this.panel1.Controls.Add(this.AutoRun);
            this.panel1.Controls.Add(this.SettingLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 485);
            this.panel1.TabIndex = 0;
            // 
            // SoundDataGridView
            // 
            this.SoundDataGridView.AllowUserToAddRows = false;
            this.SoundDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SoundDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SoundDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Active,
            this.sName,
            this.File,
            this.Date,
            this.AlertTime,
            this.Volume});
            this.SoundDataGridView.Location = new System.Drawing.Point(15, 150);
            this.SoundDataGridView.MultiSelect = false;
            this.SoundDataGridView.Name = "SoundDataGridView";
            this.SoundDataGridView.Size = new System.Drawing.Size(618, 329);
            this.SoundDataGridView.TabIndex = 9;
            // 
            // Active
            // 
            this.Active.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            this.Active.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Active.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // sName
            // 
            this.sName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sName.HeaderText = "Name";
            this.sName.Name = "sName";
            this.sName.ReadOnly = true;
            // 
            // File
            // 
            this.File.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.File.HeaderText = "File";
            this.File.Name = "File";
            this.File.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // AlertTime
            // 
            this.AlertTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AlertTime.HeaderText = "AlertTime";
            this.AlertTime.Name = "AlertTime";
            this.AlertTime.ReadOnly = true;
            // 
            // Volume
            // 
            this.Volume.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Volume.HeaderText = "Volume";
            this.Volume.Name = "Volume";
            this.Volume.ReadOnly = true;
            // 
            // AllSoundsLabel
            // 
            this.AllSoundsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllSoundsLabel.Location = new System.Drawing.Point(12, 128);
            this.AllSoundsLabel.Name = "AllSoundsLabel";
            this.AllSoundsLabel.Size = new System.Drawing.Size(621, 19);
            this.AllSoundsLabel.TabIndex = 8;
            this.AllSoundsLabel.Text = "เสียงทั้งหมด";
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(15, 91);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(618, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Value = 80;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // OverallSoundVolumeText
            // 
            this.OverallSoundVolumeText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OverallSoundVolumeText.Location = new System.Drawing.Point(12, 69);
            this.OverallSoundVolumeText.Name = "OverallSoundVolumeText";
            this.OverallSoundVolumeText.Size = new System.Drawing.Size(621, 19);
            this.OverallSoundVolumeText.TabIndex = 6;
            this.OverallSoundVolumeText.Text = "ระดับเสียงโดยรวม : 80%";
            // 
            // AutoRun
            // 
            this.AutoRun.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoRun.Location = new System.Drawing.Point(15, 31);
            this.AutoRun.Name = "AutoRun";
            this.AutoRun.Size = new System.Drawing.Size(618, 35);
            this.AutoRun.TabIndex = 5;
            this.AutoRun.Text = "เริ่มต้นอัตโนมัติตอนเปิดเครื่อง";
            this.AutoRun.UseVisualStyleBackColor = true;
            // 
            // SettingLabel
            // 
            this.SettingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingLabel.Location = new System.Drawing.Point(12, 5);
            this.SettingLabel.Name = "SettingLabel";
            this.SettingLabel.Size = new System.Drawing.Size(621, 23);
            this.SettingLabel.TabIndex = 4;
            this.SettingLabel.Text = "การตั้งค่า";
            this.SettingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveAndExitBtn
            // 
            this.SaveAndExitBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveAndExitBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.SaveAndExitBtn.Location = new System.Drawing.Point(544, 0);
            this.SaveAndExitBtn.Name = "SaveAndExitBtn";
            this.SaveAndExitBtn.Size = new System.Drawing.Size(101, 41);
            this.SaveAndExitBtn.TabIndex = 0;
            this.SaveAndExitBtn.Text = "บันทึก";
            this.SaveAndExitBtn.UseVisualStyleBackColor = true;
            this.SaveAndExitBtn.Click += new System.EventHandler(this.SaveAndExitBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitBtn.Location = new System.Drawing.Point(443, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(101, 41);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "ออก";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.edit);
            this.panel2.Controls.Add(this.del);
            this.panel2.Controls.Add(this.AddItems);
            this.panel2.Controls.Add(this.exitBtn);
            this.panel2.Controls.Add(this.SaveAndExitBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 485);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(645, 41);
            this.panel2.TabIndex = 2;
            // 
            // edit
            // 
            this.edit.Dock = System.Windows.Forms.DockStyle.Left;
            this.edit.Location = new System.Drawing.Point(202, 0);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(101, 41);
            this.edit.TabIndex = 4;
            this.edit.Text = "แก้ไข";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // del
            // 
            this.del.Dock = System.Windows.Forms.DockStyle.Left;
            this.del.Location = new System.Drawing.Point(101, 0);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(101, 41);
            this.del.TabIndex = 3;
            this.del.Text = "ลบ";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // AddItems
            // 
            this.AddItems.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddItems.Location = new System.Drawing.Point(0, 0);
            this.AddItems.Name = "AddItems";
            this.AddItems.Size = new System.Drawing.Size(101, 41);
            this.AddItems.TabIndex = 2;
            this.AddItems.Text = "เพิ่ม";
            this.AddItems.UseVisualStyleBackColor = true;
            this.AddItems.Click += new System.EventHandler(this.AddItems_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "การตั่งค่า";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoundDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SettingLabel;
        private System.Windows.Forms.DataGridView SoundDataGridView;
        private System.Windows.Forms.Label AllSoundsLabel;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label OverallSoundVolumeText;
        private System.Windows.Forms.Button SaveAndExitBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button AddItems;
        private System.Windows.Forms.CheckBox AutoRun;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn sName;
        private System.Windows.Forms.DataGridViewTextBoxColumn File;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlertTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volume;
    }
}