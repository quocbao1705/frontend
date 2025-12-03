using System;

namespace QLCTSV.GUI
{
    partial class AdminHocBong
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_hocky = new System.Windows.Forms.ComboBox();
            this.label_HocBong = new System.Windows.Forms.Label();
            this.comboBox_namhoc = new System.Windows.Forms.ComboBox();
            this.label_NamHoc = new System.Windows.Forms.Label();
            this.Label_Chung = new System.Windows.Forms.Label();
            this.button_xemds = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 231);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1063, 273);
            this.dataGridView1.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_hocky);
            this.groupBox1.Controls.Add(this.label_HocBong);
            this.groupBox1.Controls.Add(this.comboBox_namhoc);
            this.groupBox1.Controls.Add(this.label_NamHoc);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(48, 72);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1063, 88);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Học Bổng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox_hocky
            // 
            this.comboBox_hocky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_hocky.FormattingEnabled = true;
            this.comboBox_hocky.Location = new System.Drawing.Point(701, 26);
            this.comboBox_hocky.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_hocky.Name = "comboBox_hocky";
            this.comboBox_hocky.Size = new System.Drawing.Size(324, 33);
            this.comboBox_hocky.TabIndex = 32;
            // 
            // label_HocBong
            // 
            this.label_HocBong.AutoSize = true;
            this.label_HocBong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_HocBong.Location = new System.Drawing.Point(609, 31);
            this.label_HocBong.Name = "label_HocBong";
            this.label_HocBong.Size = new System.Drawing.Size(66, 23);
            this.label_HocBong.TabIndex = 31;
            this.label_HocBong.Text = "Học kì:";
            // 
            // comboBox_namhoc
            // 
            this.comboBox_namhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_namhoc.FormattingEnabled = true;
            this.comboBox_namhoc.Location = new System.Drawing.Point(144, 26);
            this.comboBox_namhoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_namhoc.Name = "comboBox_namhoc";
            this.comboBox_namhoc.Size = new System.Drawing.Size(324, 33);
            this.comboBox_namhoc.TabIndex = 29;
            // 
            // label_NamHoc
            // 
            this.label_NamHoc.AutoSize = true;
            this.label_NamHoc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NamHoc.Location = new System.Drawing.Point(37, 31);
            this.label_NamHoc.Name = "label_NamHoc";
            this.label_NamHoc.Size = new System.Drawing.Size(89, 23);
            this.label_NamHoc.TabIndex = 16;
            this.label_NamHoc.Text = "Năm Học:";
            // 
            // Label_Chung
            // 
            this.Label_Chung.AutoSize = true;
            this.Label_Chung.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Chung.ForeColor = System.Drawing.Color.Blue;
            this.Label_Chung.Location = new System.Drawing.Point(40, 184);
            this.Label_Chung.Name = "Label_Chung";
            this.Label_Chung.Size = new System.Drawing.Size(306, 45);
            this.Label_Chung.TabIndex = 18;
            this.Label_Chung.Text = "Quản Lý Học Bổng";
            // 
            // button_xemds
            // 
            this.button_xemds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_xemds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_xemds.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xemds.Location = new System.Drawing.Point(888, 518);
            this.button_xemds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_xemds.Name = "button_xemds";
            this.button_xemds.Size = new System.Drawing.Size(223, 59);
            this.button_xemds.TabIndex = 23;
            this.button_xemds.Text = "Xem danh sách";
            this.button_xemds.UseVisualStyleBackColor = true;
            this.button_xemds.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // AdminHocBong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 623);
            this.Controls.Add(this.button_xemds);
            this.Controls.Add(this.Label_Chung);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminHocBong";
            this.Text = "HỌC BỔNG";
            this.Load += new System.EventHandler(this.AdminHocBong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_NamHoc;
        private System.Windows.Forms.Label Label_Chung;
        private System.Windows.Forms.ComboBox comboBox_namhoc;
        private System.Windows.Forms.ComboBox comboBox_hocky;
        private System.Windows.Forms.Label label_HocBong;
        private System.Windows.Forms.Button button_xemds;
    }
}