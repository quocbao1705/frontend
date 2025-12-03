namespace QLCTSV.GUI
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.bntMinimize = new System.Windows.Forms.PictureBox();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.btnCloseChildForm = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.button_kyluat = new System.Windows.Forms.Button();
            this.button_diem = new System.Windows.Forms.Button();
            this.button_hocbong = new System.Windows.Forms.Button();
            this.button_sinhvien = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.button_logout = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panelDesktopPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bntMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(260, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1155, 127);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(541, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Controls.Add(this.pictureBox1);
            this.panelDesktopPane.Controls.Add(this.panelTitleBar);
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(260, 0);
            this.panelDesktopPane.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(1155, 750);
            this.panelDesktopPane.TabIndex = 17;
            this.panelDesktopPane.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktopPane_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(416, 284);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(236)))), ((int)(((byte)(212)))));
            this.panelTitleBar.Controls.Add(this.bntMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1155, 127);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // bntMinimize
            // 
            this.bntMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntMinimize.Image = ((System.Drawing.Image)(resources.GetObject("bntMinimize.Image")));
            this.bntMinimize.Location = new System.Drawing.Point(1045, 0);
            this.bntMinimize.Name = "bntMinimize";
            this.bntMinimize.Size = new System.Drawing.Size(20, 20);
            this.bntMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bntMinimize.TabIndex = 3;
            this.bntMinimize.TabStop = false;
            this.bntMinimize.Click += new System.EventHandler(this.bntMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(1085, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(20, 20);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseChildForm.Image")));
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(135, 127);
            this.btnCloseChildForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnCloseChildForm.TabIndex = 2;
            this.btnCloseChildForm.TabStop = false;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click_1);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(526, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(120, 45);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "HOME";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1124, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button_kyluat
            // 
            this.button_kyluat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button_kyluat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_kyluat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_kyluat.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_kyluat.ForeColor = System.Drawing.Color.White;
            this.button_kyluat.Image = ((System.Drawing.Image)(resources.GetObject("button_kyluat.Image")));
            this.button_kyluat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_kyluat.Location = new System.Drawing.Point(0, 310);
            this.button_kyluat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_kyluat.Name = "button_kyluat";
            this.button_kyluat.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_kyluat.Size = new System.Drawing.Size(260, 94);
            this.button_kyluat.TabIndex = 9;
            this.button_kyluat.Text = "           Kỷ luật";
            this.button_kyluat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_kyluat.UseVisualStyleBackColor = false;
            this.button_kyluat.Click += new System.EventHandler(this.button_kyluat_Click);
            // 
            // button_diem
            // 
            this.button_diem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button_diem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_diem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_diem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_diem.ForeColor = System.Drawing.Color.White;
            this.button_diem.Image = ((System.Drawing.Image)(resources.GetObject("button_diem.Image")));
            this.button_diem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_diem.Location = new System.Drawing.Point(0, 218);
            this.button_diem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_diem.Name = "button_diem";
            this.button_diem.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_diem.Size = new System.Drawing.Size(260, 94);
            this.button_diem.TabIndex = 9;
            this.button_diem.Text = "           Điểm";
            this.button_diem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_diem.UseVisualStyleBackColor = false;
            this.button_diem.Click += new System.EventHandler(this.button_diem_Click);
            // 
            // button_hocbong
            // 
            this.button_hocbong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button_hocbong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_hocbong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hocbong.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hocbong.ForeColor = System.Drawing.Color.White;
            this.button_hocbong.Image = ((System.Drawing.Image)(resources.GetObject("button_hocbong.Image")));
            this.button_hocbong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_hocbong.Location = new System.Drawing.Point(0, 400);
            this.button_hocbong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_hocbong.Name = "button_hocbong";
            this.button_hocbong.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_hocbong.Size = new System.Drawing.Size(260, 94);
            this.button_hocbong.TabIndex = 9;
            this.button_hocbong.Text = "           Học bổng";
            this.button_hocbong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_hocbong.UseVisualStyleBackColor = false;
            this.button_hocbong.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_sinhvien
            // 
            this.button_sinhvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button_sinhvien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_sinhvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sinhvien.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sinhvien.ForeColor = System.Drawing.Color.White;
            this.button_sinhvien.Image = ((System.Drawing.Image)(resources.GetObject("button_sinhvien.Image")));
            this.button_sinhvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sinhvien.Location = new System.Drawing.Point(0, 125);
            this.button_sinhvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_sinhvien.Name = "button_sinhvien";
            this.button_sinhvien.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_sinhvien.Size = new System.Drawing.Size(260, 94);
            this.button_sinhvien.TabIndex = 9;
            this.button_sinhvien.Text = "           Sinh viên";
            this.button_sinhvien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sinhvien.UseVisualStyleBackColor = false;
            this.button_sinhvien.Click += new System.EventHandler(this.button_sinhvien_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.pictureBox_logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 127);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(236)))), ((int)(((byte)(212)))));
            this.pictureBox_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
            this.pictureBox_logo.Location = new System.Drawing.Point(0, -2);
            this.pictureBox_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(260, 135);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            this.pictureBox_logo.Click += new System.EventHandler(this.pictureBox_logo_Click);
            this.pictureBox_logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_logo_MouseDown);
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logout.ForeColor = System.Drawing.Color.White;
            this.button_logout.Image = ((System.Drawing.Image)(resources.GetObject("button_logout.Image")));
            this.button_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_logout.Location = new System.Drawing.Point(0, 490);
            this.button_logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_logout.Name = "button_logout";
            this.button_logout.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_logout.Size = new System.Drawing.Size(260, 94);
            this.button_logout.TabIndex = 9;
            this.button_logout.Text = "           Đăng xuất";
            this.button_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button5_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.button_logout);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.button_sinhvien);
            this.panelMenu.Controls.Add(this.button_hocbong);
            this.panelMenu.Controls.Add(this.button_diem);
            this.panelMenu.Controls.Add(this.button_kyluat);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.White;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(260, 750);
            this.panelMenu.TabIndex = 15;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1415, 750);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.Black;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1226, 739);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelDesktopPane.ResumeLayout(false);
            this.panelDesktopPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bntMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox btnCloseChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox bntMinimize;
        private System.Windows.Forms.PictureBox btnMaximize;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Button button_kyluat;
        private System.Windows.Forms.Button button_diem;
        private System.Windows.Forms.Button button_hocbong;
        private System.Windows.Forms.Button button_sinhvien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Panel panelMenu;
    }
}