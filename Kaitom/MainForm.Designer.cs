namespace Kaitom
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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayContex = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showhHideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitContex = new System.Windows.Forms.ToolStripMenuItem();
            this.setting = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.timeUpdate = new System.Windows.Forms.Timer(this.components);
            this.emergencystop = new System.Windows.Forms.Button();
            this.isPauseCheck = new System.Windows.Forms.CheckBox();
            this.statShow1 = new Kaitom.lib.StatShow();
            this.helplable = new System.Windows.Forms.LinkLabel();
            this.TrayContex.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "ระบบแจ้งเตือนรายชั่วโมงได้เริ่มทำงานแล้ว";
            this.notifyIcon1.BalloonTipTitle = "แจ้งเตือน";
            this.notifyIcon1.ContextMenuStrip = this.TrayContex;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "ระบบแจ้งเตือนรายชั่วโมง";
            this.notifyIcon1.Visible = true;
            // 
            // TrayContex
            // 
            this.TrayContex.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showhHideToolStripMenuItem,
            this.updateCheckToolStripMenuItem,
            this.AboutToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitContex});
            this.TrayContex.Name = "TrayContex";
            this.TrayContex.Size = new System.Drawing.Size(148, 98);
            // 
            // showhHideToolStripMenuItem
            // 
            this.showhHideToolStripMenuItem.Name = "showhHideToolStripMenuItem";
            this.showhHideToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.showhHideToolStripMenuItem.Text = "ซ่อน";
            // 
            // updateCheckToolStripMenuItem
            // 
            this.updateCheckToolStripMenuItem.Name = "updateCheckToolStripMenuItem";
            this.updateCheckToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.updateCheckToolStripMenuItem.Text = "ตรวจสอบอัพเดท";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.AboutToolStripMenuItem.Text = "เกี่ยวกับ";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(144, 6);
            // 
            // exitContex
            // 
            this.exitContex.Name = "exitContex";
            this.exitContex.Size = new System.Drawing.Size(147, 22);
            this.exitContex.Text = "ออก";
            // 
            // setting
            // 
            this.setting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.setting.Location = new System.Drawing.Point(576, 298);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(106, 32);
            this.setting.TabIndex = 1;
            this.setting.Text = "การตั่งค่า";
            this.setting.UseVisualStyleBackColor = true;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // status
            // 
            this.status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.status.Location = new System.Drawing.Point(12, 303);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(558, 23);
            this.status.TabIndex = 2;
            this.status.Text = "สถานะ :";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeUpdate
            // 
            this.timeUpdate.Enabled = true;
            this.timeUpdate.Interval = 50;
            // 
            // emergencystop
            // 
            this.emergencystop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.emergencystop.Location = new System.Drawing.Point(15, 268);
            this.emergencystop.Name = "emergencystop";
            this.emergencystop.Size = new System.Drawing.Size(88, 32);
            this.emergencystop.TabIndex = 3;
            this.emergencystop.Text = "หยุดเล่น";
            this.emergencystop.UseVisualStyleBackColor = true;
            // 
            // isPauseCheck
            // 
            this.isPauseCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.isPauseCheck.AutoSize = true;
            this.isPauseCheck.Location = new System.Drawing.Point(109, 277);
            this.isPauseCheck.Name = "isPauseCheck";
            this.isPauseCheck.Size = new System.Drawing.Size(132, 17);
            this.isPauseCheck.TabIndex = 5;
            this.isPauseCheck.Text = "หยุดการทำงานชั่วคราว";
            this.isPauseCheck.UseVisualStyleBackColor = true;
            // 
            // statShow1
            // 
            this.statShow1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statShow1.ContextMenuStrip = this.TrayContex;
            this.statShow1.f1 = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.statShow1.f2 = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold);
            this.statShow1.f3 = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.statShow1.Location = new System.Drawing.Point(15, 32);
            this.statShow1.Name = "statShow1";
            this.statShow1.NextTime = "00:00:10 AM";
            this.statShow1.NextTimeThai = "การแจ้งตื่นครั่งถัดไป";
            this.statShow1.NowTime = "00:00:10 AM";
            this.statShow1.NowTimeThai = "เวลาตอนนี้";
            this.statShow1.Size = new System.Drawing.Size(667, 226);
            this.statShow1.TabIndex = 4;
            // 
            // helplable
            // 
            this.helplable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helplable.AutoSize = true;
            this.helplable.Location = new System.Drawing.Point(650, 16);
            this.helplable.Name = "helplable";
            this.helplable.Size = new System.Drawing.Size(32, 13);
            this.helplable.TabIndex = 6;
            this.helplable.TabStop = true;
            this.helplable.Text = "วิธีใช้";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 342);
            this.Controls.Add(this.helplable);
            this.Controls.Add(this.isPauseCheck);
            this.Controls.Add(this.statShow1);
            this.Controls.Add(this.emergencystop);
            this.Controls.Add(this.status);
            this.Controls.Add(this.setting);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "ระบบแจ้งเตือนรายชั่วโมง";
            this.TrayContex.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip TrayContex;
        private System.Windows.Forms.ToolStripMenuItem showhHideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitContex;
        private System.Windows.Forms.Button setting;
        private System.Windows.Forms.Label status;
        private lib.StatShow statShow1;
        private System.Windows.Forms.Timer timeUpdate;
        private System.Windows.Forms.Button emergencystop;
        private System.Windows.Forms.CheckBox isPauseCheck;
        private System.Windows.Forms.ToolStripMenuItem updateCheckToolStripMenuItem;
        private System.Windows.Forms.LinkLabel helplable;
    }
}

