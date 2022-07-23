namespace Kaitom.SubForm
{
    partial class AddForm
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.FileSelect = new System.Windows.Forms.Button();
            this.TimeTableLabel = new System.Windows.Forms.Label();
            this.DateSelectList = new System.Windows.Forms.CheckedListBox();
            this.TimeSelectPanel = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.AddTime = new System.Windows.Forms.Button();
            this.RemoveTme = new System.Windows.Forms.Button();
            this.VolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.TimeSelectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(12, 36);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(396, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.Location = new System.Drawing.Point(12, 20);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(409, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "ชื่อ";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileNameLabel.Location = new System.Drawing.Point(12, 59);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(409, 13);
            this.FileNameLabel.TabIndex = 3;
            this.FileNameLabel.Text = "ไฟล์เสียง";
            this.FileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileNameTextBox.Location = new System.Drawing.Point(12, 75);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(335, 20);
            this.FileNameTextBox.TabIndex = 2;
            // 
            // FileSelect
            // 
            this.FileSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FileSelect.Location = new System.Drawing.Point(364, 75);
            this.FileSelect.Name = "FileSelect";
            this.FileSelect.Size = new System.Drawing.Size(44, 20);
            this.FileSelect.TabIndex = 4;
            this.FileSelect.Text = "...";
            this.FileSelect.UseVisualStyleBackColor = true;
            // 
            // TimeTableLabel
            // 
            this.TimeTableLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeTableLabel.Location = new System.Drawing.Point(12, 98);
            this.TimeTableLabel.Name = "TimeTableLabel";
            this.TimeTableLabel.Size = new System.Drawing.Size(409, 13);
            this.TimeTableLabel.TabIndex = 5;
            this.TimeTableLabel.Text = "เวลา";
            this.TimeTableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateSelectList
            // 
            this.DateSelectList.FormattingEnabled = true;
            this.DateSelectList.Items.AddRange(new object[] {
            "วันจันทร์",
            "วันอังคาร",
            "วันพุธ",
            "วันพฤหัสบดี",
            "วันศุกร์",
            "วันเสาร์",
            "วันอาทิตย์"});
            this.DateSelectList.Location = new System.Drawing.Point(15, 114);
            this.DateSelectList.Name = "DateSelectList";
            this.DateSelectList.Size = new System.Drawing.Size(198, 109);
            this.DateSelectList.TabIndex = 14;
            // 
            // TimeSelectPanel
            // 
            this.TimeSelectPanel.AutoScroll = true;
            this.TimeSelectPanel.BackColor = System.Drawing.SystemColors.Window;
            this.TimeSelectPanel.Controls.Add(this.dateTimePicker1);
            this.TimeSelectPanel.Location = new System.Drawing.Point(219, 114);
            this.TimeSelectPanel.Name = "TimeSelectPanel";
            this.TimeSelectPanel.Size = new System.Drawing.Size(189, 109);
            this.TimeSelectPanel.TabIndex = 15;
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
            // AddTime
            // 
            this.AddTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTime.Location = new System.Drawing.Point(232, 229);
            this.AddTime.Name = "AddTime";
            this.AddTime.Size = new System.Drawing.Size(44, 20);
            this.AddTime.TabIndex = 16;
            this.AddTime.Text = "+";
            this.AddTime.UseVisualStyleBackColor = true;
            // 
            // RemoveTme
            // 
            this.RemoveTme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveTme.Location = new System.Drawing.Point(282, 229);
            this.RemoveTme.Name = "RemoveTme";
            this.RemoveTme.Size = new System.Drawing.Size(44, 20);
            this.RemoveTme.TabIndex = 17;
            this.RemoveTme.Text = "-";
            this.RemoveTme.UseVisualStyleBackColor = true;
            // 
            // VolumeTrackBar
            // 
            this.VolumeTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VolumeTrackBar.Location = new System.Drawing.Point(12, 268);
            this.VolumeTrackBar.Maximum = 200;
            this.VolumeTrackBar.Name = "VolumeTrackBar";
            this.VolumeTrackBar.Size = new System.Drawing.Size(396, 45);
            this.VolumeTrackBar.TabIndex = 18;
            this.VolumeTrackBar.Value = 100;
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VolumeLabel.Location = new System.Drawing.Point(12, 252);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(409, 13);
            this.VolumeLabel.TabIndex = 19;
            this.VolumeLabel.Text = "ระดับเสียง : 100%";
            this.VolumeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(325, 305);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 39);
            this.button4.TabIndex = 20;
            this.button4.Text = "เพิ่ม";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button5.Location = new System.Drawing.Point(236, 305);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 39);
            this.button5.TabIndex = 21;
            this.button5.Text = "ยกเลิก";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 356);
            this.ControlBox = false;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "เพิ่ม ";
            this.TimeSelectPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.Button FileSelect;
        private System.Windows.Forms.Label TimeTableLabel;
        private System.Windows.Forms.CheckedListBox DateSelectList;
        private System.Windows.Forms.Panel TimeSelectPanel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button AddTime;
        private System.Windows.Forms.Button RemoveTme;
        private System.Windows.Forms.TrackBar VolumeTrackBar;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}