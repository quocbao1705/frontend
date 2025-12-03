namespace QLCTSV.GUI
{
    partial class SVinterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SVinterface));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.btn_SVmenu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebarSV = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_SVhocbong = new System.Windows.Forms.Panel();
            this.button_SVhocbong = new System.Windows.Forms.Button();
            this.panel_SVdiem = new System.Windows.Forms.Panel();
            this.button_SVdiem = new System.Windows.Forms.Button();
            this.panel_logout = new System.Windows.Forms.Panel();
            this.button_SVLogout = new System.Windows.Forms.Button();
            this.SVTransition = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SVmenu)).BeginInit();
            this.sidebarSV.SuspendLayout();
            this.panel_SVhocbong.SuspendLayout();
            this.panel_SVdiem.SuspendLayout();
            this.panel_logout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Controls.Add(this.btn_SVmenu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1309, 44);
            this.panel1.TabIndex = 6;
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(1170, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 7;
            // 
            // btn_SVmenu
            // 
            this.btn_SVmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SVmenu.Image = ((System.Drawing.Image)(resources.GetObject("btn_SVmenu.Image")));
            this.btn_SVmenu.Location = new System.Drawing.Point(12, 6);
            this.btn_SVmenu.Name = "btn_SVmenu";
            this.btn_SVmenu.Size = new System.Drawing.Size(40, 33);
            this.btn_SVmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_SVmenu.TabIndex = 6;
            this.btn_SVmenu.TabStop = false;
            this.btn_SVmenu.Click += new System.EventHandler(this.btn_SVmenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(95, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "HỆ THỐNG SINH VIÊN";
            // 
            // sidebarSV
            // 
            this.sidebarSV.BackColor = System.Drawing.Color.Blue;
            this.sidebarSV.Controls.Add(this.panel_SVhocbong);
            this.sidebarSV.Controls.Add(this.panel_SVdiem);
            this.sidebarSV.Controls.Add(this.panel_logout);
            this.sidebarSV.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarSV.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebarSV.Location = new System.Drawing.Point(0, 44);
            this.sidebarSV.Name = "sidebarSV";
            this.sidebarSV.Size = new System.Drawing.Size(376, 606);
            this.sidebarSV.TabIndex = 9;
            this.sidebarSV.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebarSV_Paint);
            // 
            // panel_SVhocbong
            // 
            this.panel_SVhocbong.Controls.Add(this.button_SVhocbong);
            this.panel_SVhocbong.Location = new System.Drawing.Point(3, 3);
            this.panel_SVhocbong.Name = "panel_SVhocbong";
            this.panel_SVhocbong.Size = new System.Drawing.Size(373, 66);
            this.panel_SVhocbong.TabIndex = 10;
            // 
            // button_SVhocbong
            // 
            this.button_SVhocbong.BackColor = System.Drawing.Color.Blue;
            this.button_SVhocbong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SVhocbong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SVhocbong.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SVhocbong.ForeColor = System.Drawing.Color.White;
            this.button_SVhocbong.Image = ((System.Drawing.Image)(resources.GetObject("button_SVhocbong.Image")));
            this.button_SVhocbong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_SVhocbong.Location = new System.Drawing.Point(-24, -15);
            this.button_SVhocbong.Name = "button_SVhocbong";
            this.button_SVhocbong.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button_SVhocbong.Size = new System.Drawing.Size(409, 94);
            this.button_SVhocbong.TabIndex = 9;
            this.button_SVhocbong.Text = "           Học bổng";
            this.button_SVhocbong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_SVhocbong.UseVisualStyleBackColor = false;
            this.button_SVhocbong.Click += new System.EventHandler(this.button_SVhocbong_Click);
            // 
            // panel_SVdiem
            // 
            this.panel_SVdiem.Controls.Add(this.button_SVdiem);
            this.panel_SVdiem.Location = new System.Drawing.Point(3, 75);
            this.panel_SVdiem.Name = "panel_SVdiem";
            this.panel_SVdiem.Size = new System.Drawing.Size(373, 66);
            this.panel_SVdiem.TabIndex = 12;
            // 
            // button_SVdiem
            // 
            this.button_SVdiem.BackColor = System.Drawing.Color.Blue;
            this.button_SVdiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SVdiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SVdiem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SVdiem.ForeColor = System.Drawing.Color.White;
            this.button_SVdiem.Image = ((System.Drawing.Image)(resources.GetObject("button_SVdiem.Image")));
            this.button_SVdiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_SVdiem.Location = new System.Drawing.Point(-24, -15);
            this.button_SVdiem.Name = "button_SVdiem";
            this.button_SVdiem.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button_SVdiem.Size = new System.Drawing.Size(409, 94);
            this.button_SVdiem.TabIndex = 9;
            this.button_SVdiem.Text = "           Điểm";
            this.button_SVdiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_SVdiem.UseVisualStyleBackColor = false;
            this.button_SVdiem.Click += new System.EventHandler(this.button_SVdiem_Click);
            // 
            // panel_logout
            // 
            this.panel_logout.Controls.Add(this.button_SVLogout);
            this.panel_logout.Location = new System.Drawing.Point(3, 147);
            this.panel_logout.Name = "panel_logout";
            this.panel_logout.Size = new System.Drawing.Size(373, 66);
            this.panel_logout.TabIndex = 14;
            // 
            // button_SVLogout
            // 
            this.button_SVLogout.BackColor = System.Drawing.Color.Blue;
            this.button_SVLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SVLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SVLogout.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SVLogout.ForeColor = System.Drawing.Color.White;
            this.button_SVLogout.Image = ((System.Drawing.Image)(resources.GetObject("button_SVLogout.Image")));
            this.button_SVLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_SVLogout.Location = new System.Drawing.Point(-24, -15);
            this.button_SVLogout.Name = "button_SVLogout";
            this.button_SVLogout.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button_SVLogout.Size = new System.Drawing.Size(409, 94);
            this.button_SVLogout.TabIndex = 9;
            this.button_SVLogout.Text = "           Đăng xuất";
            this.button_SVLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_SVLogout.UseVisualStyleBackColor = false;
            // 
            // SVTransition
            // 
            this.SVTransition.Interval = 5;
            this.SVTransition.Tick += new System.EventHandler(this.SVTransition_Tick);
            // 
            // SVinterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 650);
            this.Controls.Add(this.sidebarSV);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SVinterface";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SVinterface_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SVmenu)).EndInit();
            this.sidebarSV.ResumeLayout(false);
            this.panel_SVhocbong.ResumeLayout(false);
            this.panel_SVdiem.ResumeLayout(false);
            this.panel_logout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.PictureBox btn_SVmenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel sidebarSV;
        private System.Windows.Forms.Panel panel_SVhocbong;
        private System.Windows.Forms.Button button_SVhocbong;
        private System.Windows.Forms.Panel panel_SVdiem;
        private System.Windows.Forms.Button button_SVdiem;
        private System.Windows.Forms.Panel panel_logout;
        private System.Windows.Forms.Button button_SVLogout;
        private System.Windows.Forms.Timer SVTransition;
    }
}