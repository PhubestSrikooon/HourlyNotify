namespace Kaitom.SubForm
{
    partial class EditForm
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
            this.cancelbtn = new System.Windows.Forms.Button();
            this.editedbtn = new System.Windows.Forms.Button();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.VolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.RemoveTme = new System.Windows.Forms.Button();
            this.AddTime = new System.Windows.Forms.Button();
            this.TimeSelectPanel = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DateSelectList = new System.Windows.Forms.CheckedListBox();
            this.TimeTableLabel = new System.Windows.Forms.Label();
            this.FileSelect = new System.Windows.Forms.Button();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.toggleswitch = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).BeginInit();
            this.TimeSelectPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelbtn
            // 
            this.cancelbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelbtn.Location = new System.Drawing.Point(229, 308);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(83, 39);
            this.cancelbtn.TabIndex = 23;
            this.cancelbtn.Text = "ยกเลิก";
            this.cancelbtn.UseVisualStyleBackColor = true;
            // 
            // editedbtn
            // 
            this.editedbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editedbtn.Location = new System.Drawing.Point(318, 308);
            this.editedbtn.Name = "editedbtn";
            this.editedbtn.Size = new System.Drawing.Size(83, 39);
            this.editedbtn.TabIndex = 22;
            this.editedbtn.Text = "แก้ไข";
            this.editedbtn.UseVisualStyleBackColor = true;
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VolumeLabel.Location = new System.Drawing.Point(4, 241);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(405, 13);
            this.VolumeLabel.TabIndex = 35;
            this.VolumeLabel.Text = "ระดับเสียง : 100%";
            this.VolumeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VolumeTrackBar
            // 
            this.VolumeTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VolumeTrackBar.Location = new System.Drawing.Point(4, 257);
            this.VolumeTrackBar.Maximum = 200;
            this.VolumeTrackBar.Name = "VolumeTrackBar";
            this.VolumeTrackBar.Size = new System.Drawing.Size(405, 45);
            this.VolumeTrackBar.TabIndex = 34;
            this.VolumeTrackBar.Value = 100;
            // 
            // RemoveTme
            // 
            this.RemoveTme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveTme.Location = new System.Drawing.Point(270, 218);
            this.RemoveTme.Name = "RemoveTme";
            this.RemoveTme.Size = new System.Drawing.Size(44, 20);
            this.RemoveTme.TabIndex = 33;
            this.RemoveTme.Text = "-";
            this.RemoveTme.UseVisualStyleBackColor = true;
            // 
            // AddTime
            // 
            this.AddTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTime.Location = new System.Drawing.Point(220, 218);
            this.AddTime.Name = "AddTime";
            this.AddTime.Size = new System.Drawing.Size(44, 20);
            this.AddTime.TabIndex = 32;
            this.AddTime.Text = "+";
            this.AddTime.UseVisualStyleBackColor = true;
            // 
            // TimeSelectPanel
            // 
            this.TimeSelectPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeSelectPanel.AutoScroll = true;
            this.TimeSelectPanel.BackColor = System.Drawing.SystemColors.Window;
            this.TimeSelectPanel.Controls.Add(this.dateTimePicker1);
            this.TimeSelectPanel.Location = new System.Drawing.Point(211, 103);
            this.TimeSelectPanel.Name = "TimeSelectPanel";
            this.TimeSelectPanel.Size = new System.Drawing.Size(189, 109);
            this.TimeSelectPanel.TabIndex = 31;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // DateSelectList
            // 
            this.DateSelectList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DateSelectList.FormattingEnabled = true;
            this.DateSelectList.Items.AddRange(new object[] {
            "วันจันทร์",
            "วันอังคาร",
            "วันพุธ",
            "วันพฤหัสบดี",
            "วันศุกร์",
            "วันเสาร์",
            "วันอาทิตย์"});
            this.DateSelectList.Location = new System.Drawing.Point(7, 103);
            this.DateSelectList.Name = "DateSelectList";
            this.DateSelectList.Size = new System.Drawing.Size(198, 109);
            this.DateSelectList.TabIndex = 30;
            // 
            // TimeTableLabel
            // 
            this.TimeTableLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeTableLabel.Location = new System.Drawing.Point(4, 87);
            this.TimeTableLabel.Name = "TimeTableLabel";
            this.TimeTableLabel.Size = new System.Drawing.Size(405, 13);
            this.TimeTableLabel.TabIndex = 29;
            this.TimeTableLabel.Text = "เวลา";
            this.TimeTableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FileSelect
            // 
            this.FileSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FileSelect.Location = new System.Drawing.Point(357, 64);
            this.FileSelect.Name = "FileSelect";
            this.FileSelect.Size = new System.Drawing.Size(44, 20);
            this.FileSelect.TabIndex = 28;
            this.FileSelect.Text = "...";
            this.FileSelect.UseVisualStyleBackColor = true;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileNameLabel.Location = new System.Drawing.Point(4, 48);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(405, 13);
            this.FileNameLabel.TabIndex = 27;
            this.FileNameLabel.Text = "ไฟล์เสียง";
            this.FileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileNameTextBox.Location = new System.Drawing.Point(4, 64);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(342, 20);
            this.FileNameTextBox.TabIndex = 26;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.Location = new System.Drawing.Point(4, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(405, 13);
            this.NameLabel.TabIndex = 25;
            this.NameLabel.Text = "ชื่อ";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(4, 25);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(396, 20);
            this.NameTextBox.TabIndex = 24;
            // 
            // toggleswitch
            // 
            this.toggleswitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toggleswitch.AutoSize = true;
            this.toggleswitch.Location = new System.Drawing.Point(12, 330);
            this.toggleswitch.Name = "toggleswitch";
            this.toggleswitch.Size = new System.Drawing.Size(57, 17);
            this.toggleswitch.TabIndex = 36;
            this.toggleswitch.Text = "ใช้งาน";
            this.toggleswitch.UseVisualStyleBackColor = true;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 356);
            this.Controls.Add(this.toggleswitch);
            this.Controls.Add(this.VolumeLabel);
            this.Controls.Add(this.VolumeTrackBar);
            this.Controls.Add(this.RemoveTme);
            this.Controls.Add(this.AddTime);
            this.Controls.Add(this.TimeSelectPanel);
            this.Controls.Add(this.DateSelectList);
            this.Controls.Add(this.TimeTableLabel);
            this.Controls.Add(this.FileSelect);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.FileNameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.editedbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "แก้ไข";
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).EndInit();
            this.TimeSelectPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button editedbtn;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.TrackBar VolumeTrackBar;
        private System.Windows.Forms.Button RemoveTme;
        private System.Windows.Forms.Button AddTime;
        private System.Windows.Forms.Panel TimeSelectPanel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckedListBox DateSelectList;
        private System.Windows.Forms.Label TimeTableLabel;
        private System.Windows.Forms.Button FileSelect;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.CheckBox toggleswitch;
    }
}