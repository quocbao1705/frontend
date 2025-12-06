using System;

namespace QLCTSV.GUI
{
    partial class AdminKyLuat
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_lyDo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_hocKy = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_hinhthuc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_namhoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_MaSV = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label_HTKL = new System.Windows.Forms.Label();
            this.label_DSSV = new System.Windows.Forms.Label();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_sua = new System.Windows.Forms.Button();
            this.button_them = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_lammoi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_lyDo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox_hocKy);
            this.groupBox1.Controls.Add(this.dateTimePicker_date);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox_hinhthuc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBox_namhoc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_MaSV);
            this.groupBox1.Location = new System.Drawing.Point(41, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(499, 290);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Kỷ Luật";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox_lyDo
            // 
            this.textBox_lyDo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_lyDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_lyDo.Location = new System.Drawing.Point(203, 207);
            this.textBox_lyDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_lyDo.Name = "textBox_lyDo";
            this.textBox_lyDo.Size = new System.Drawing.Size(277, 30);
            this.textBox_lyDo.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 37;
            this.label5.Text = "Lý do:";
            // 
            // comboBox_hocKy
            // 
            this.comboBox_hocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_hocKy.FormattingEnabled = true;
            this.comboBox_hocKy.Location = new System.Drawing.Point(203, 72);
            this.comboBox_hocKy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_hocKy.Name = "comboBox_hocKy";
            this.comboBox_hocKy.Size = new System.Drawing.Size(277, 33);
            this.comboBox_hocKy.TabIndex = 36;
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_date.Location = new System.Drawing.Point(203, 244);
            this.dateTimePicker_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(277, 30);
            this.dateTimePicker_date.TabIndex = 35;
            this.dateTimePicker_date.Value = new System.DateTime(2025, 11, 5, 21, 58, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 23);
            this.label4.TabIndex = 34;
            this.label4.Text = "Ngày quyết định";
            // 
            // comboBox_hinhthuc
            // 
            this.comboBox_hinhthuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_hinhthuc.FormattingEnabled = true;
            this.comboBox_hinhthuc.Location = new System.Drawing.Point(203, 159);
            this.comboBox_hinhthuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_hinhthuc.Name = "comboBox_hinhthuc";
            this.comboBox_hinhthuc.Size = new System.Drawing.Size(277, 33);
            this.comboBox_hinhthuc.TabIndex = 32;
            this.comboBox_hinhthuc.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 23);
            this.label6.TabIndex = 31;
            this.label6.Text = "Hình thức:";
            // 
            // comboBox_namhoc
            // 
            this.comboBox_namhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_namhoc.FormattingEnabled = true;
            this.comboBox_namhoc.Location = new System.Drawing.Point(203, 116);
            this.comboBox_namhoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_namhoc.Name = "comboBox_namhoc";
            this.comboBox_namhoc.Size = new System.Drawing.Size(277, 33);
            this.comboBox_namhoc.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Năm Học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Học Kỳ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã Sinh Viên:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_MaSV
            // 
            this.textBox_MaSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_MaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MaSV.Location = new System.Drawing.Point(203, 34);
            this.textBox_MaSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_MaSV.Name = "textBox_MaSV";
            this.textBox_MaSV.Size = new System.Drawing.Size(277, 30);
            this.textBox_MaSV.TabIndex = 13;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(573, 52);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(536, 366);
            this.dataGridView2.TabIndex = 22;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_KyLuat_CellClick);
            // 
            // label_HTKL
            // 
            this.label_HTKL.AutoSize = true;
            this.label_HTKL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_HTKL.ForeColor = System.Drawing.Color.Red;
            this.label_HTKL.Location = new System.Drawing.Point(566, 9);
            this.label_HTKL.Name = "label_HTKL";
            this.label_HTKL.Size = new System.Drawing.Size(265, 41);
            this.label_HTKL.TabIndex = 23;
            this.label_HTKL.Text = "Danh sách kỷ luật";
            // 
            // label_DSSV
            // 
            this.label_DSSV.AutoSize = true;
            this.label_DSSV.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DSSV.ForeColor = System.Drawing.Color.Red;
            this.label_DSSV.Location = new System.Drawing.Point(34, 418);
            this.label_DSSV.Name = "label_DSSV";
            this.label_DSSV.Size = new System.Drawing.Size(294, 41);
            this.label_DSSV.TabIndex = 24;
            this.label_DSSV.Text = "Danh sách sinh viên";
            // 
            // button_xoa
            // 
            this.button_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_xoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xoa.Location = new System.Drawing.Point(308, 346);
            this.button_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(100, 72);
            this.button_xoa.TabIndex = 36;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = true;
            this.button_xoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button_sua
            // 
            this.button_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sua.Location = new System.Drawing.Point(170, 346);
            this.button_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(100, 72);
            this.button_sua.TabIndex = 37;
            this.button_sua.Text = "Sửa";
            this.button_sua.UseVisualStyleBackColor = true;
            this.button_sua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // button_them
            // 
            this.button_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_them.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them.Location = new System.Drawing.Point(41, 346);
            this.button_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(100, 72);
            this.button_them.TabIndex = 35;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = true;
            this.button_them.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 461);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1068, 128);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SinhVien_CellClick);
            // 
            // button_lammoi
            // 
            this.button_lammoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_lammoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_lammoi.Location = new System.Drawing.Point(440, 345);
            this.button_lammoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_lammoi.Name = "button_lammoi";
            this.button_lammoi.Size = new System.Drawing.Size(100, 73);
            this.button_lammoi.TabIndex = 38;
            this.button_lammoi.Text = "Hủy chọn";
            this.button_lammoi.UseVisualStyleBackColor = true;
            this.button_lammoi.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // AdminKyLuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 623);
            this.Controls.Add(this.button_lammoi);
            this.Controls.Add(this.label_DSSV);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.label_HTKL);
            this.Controls.Add(this.button_sua);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminKyLuat";
            this.Text = "KỶ LUẬT";
            this.Load += new System.EventHandler(this.AdminKyLuat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void Label_Chung_Click(object sender, EventArgs e)
        {
        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_namhoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_MaSV;
        private System.Windows.Forms.ComboBox comboBox_hinhthuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label_HTKL;
        private System.Windows.Forms.Label label_DSSV;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private System.Windows.Forms.Button button_lammoi;
        private System.Windows.Forms.TextBox textBox_lyDo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_hocKy;
    }
}