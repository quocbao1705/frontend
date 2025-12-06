namespace QLCTSV.GUI
{
    partial class AdminSV
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
            this.textBox_Ten = new System.Windows.Forms.TextBox();
            this.textBox_Sdt = new System.Windows.Forms.TextBox();
            this.textBox_diaChi = new System.Windows.Forms.TextBox();
            this.comboBox_GT = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.textBox_MaSV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_sua = new System.Windows.Forms.Button();
            this.button_them = new System.Windows.Forms.Button();
            this.Label_Chung = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_lammoi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Ten);
            this.groupBox1.Controls.Add(this.textBox_Sdt);
            this.groupBox1.Controls.Add(this.textBox_diaChi);
            this.groupBox1.Controls.Add(this.comboBox_GT);
            this.groupBox1.Controls.Add(this.dateTimePicker_date);
            this.groupBox1.Controls.Add(this.textBox_MaSV);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(43, 123);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(488, 258);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // textBox_Ten
            // 
            this.textBox_Ten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Ten.Location = new System.Drawing.Point(173, 68);
            this.textBox_Ten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Ten.Name = "textBox_Ten";
            this.textBox_Ten.Size = new System.Drawing.Size(277, 30);
            this.textBox_Ten.TabIndex = 2;
            // 
            // textBox_Sdt
            // 
            this.textBox_Sdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Sdt.Location = new System.Drawing.Point(173, 207);
            this.textBox_Sdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Sdt.Name = "textBox_Sdt";
            this.textBox_Sdt.Size = new System.Drawing.Size(277, 30);
            this.textBox_Sdt.TabIndex = 6;
            // 
            // textBox_diaChi
            // 
            this.textBox_diaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_diaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_diaChi.Location = new System.Drawing.Point(173, 173);
            this.textBox_diaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_diaChi.Name = "textBox_diaChi";
            this.textBox_diaChi.Size = new System.Drawing.Size(277, 30);
            this.textBox_diaChi.TabIndex = 5;
            // 
            // comboBox_GT
            // 
            this.comboBox_GT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_GT.FormattingEnabled = true;
            this.comboBox_GT.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.comboBox_GT.Location = new System.Drawing.Point(173, 136);
            this.comboBox_GT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_GT.Name = "comboBox_GT";
            this.comboBox_GT.Size = new System.Drawing.Size(277, 33);
            this.comboBox_GT.TabIndex = 4;
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker_date.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_date.Location = new System.Drawing.Point(173, 102);
            this.dateTimePicker_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(277, 30);
            this.dateTimePicker_date.TabIndex = 3;
            this.dateTimePicker_date.Value = new System.DateTime(2025, 11, 5, 21, 58, 0, 0);
            // 
            // textBox_MaSV
            // 
            this.textBox_MaSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_MaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MaSV.Location = new System.Drawing.Point(173, 34);
            this.textBox_MaSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_MaSV.Name = "textBox_MaSV";
            this.textBox_MaSV.Size = new System.Drawing.Size(277, 30);
            this.textBox_MaSV.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 23);
            this.label10.TabIndex = 9;
            this.label10.Text = "Số điện thoại:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "Địa Chỉ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Giới Tính:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày Sinh:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Họ và tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Sinh Viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 2;
            // 
            // button_xoa
            // 
            this.button_xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_xoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xoa.Location = new System.Drawing.Point(967, 529);
            this.button_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(100, 83);
            this.button_xoa.TabIndex = 19;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = true;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // button_sua
            // 
            this.button_sua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sua.Location = new System.Drawing.Point(718, 529);
            this.button_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(100, 83);
            this.button_sua.TabIndex = 19;
            this.button_sua.Text = "Sửa";
            this.button_sua.UseVisualStyleBackColor = true;
            this.button_sua.Click += new System.EventHandler(this.button_sua_Click);
            // 
            // button_them
            // 
            this.button_them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_them.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them.Location = new System.Drawing.Point(590, 529);
            this.button_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(100, 83);
            this.button_them.TabIndex = 18;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = true;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // Label_Chung
            // 
            this.Label_Chung.AutoEllipsis = true;
            this.Label_Chung.AutoSize = true;
            this.Label_Chung.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Chung.ForeColor = System.Drawing.Color.Red;
            this.Label_Chung.Location = new System.Drawing.Point(583, 65);
            this.Label_Chung.Name = "Label_Chung";
            this.Label_Chung.Size = new System.Drawing.Size(331, 45);
            this.Label_Chung.TabIndex = 7;
            this.Label_Chung.Text = "Thông Tin Sinh Viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(591, 112);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(477, 388);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // button_lammoi
            // 
            this.button_lammoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_lammoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_lammoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_lammoi.Location = new System.Drawing.Point(843, 529);
            this.button_lammoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_lammoi.Name = "button_lammoi";
            this.button_lammoi.Size = new System.Drawing.Size(100, 83);
            this.button_lammoi.TabIndex = 22;
            this.button_lammoi.Text = "Hủy chọn";
            this.button_lammoi.UseVisualStyleBackColor = true;
            this.button_lammoi.Click += new System.EventHandler(this.button_lammoi_Click);
            // 
            // AdminSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 623);
            this.Controls.Add(this.button_lammoi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_sua);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.Label_Chung);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminSV";
            this.Text = "SINH VIÊN";
            this.Load += new System.EventHandler(this.AdminSV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.ComboBox comboBox_GT;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private System.Windows.Forms.TextBox textBox_MaSV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_Chung;
        private System.Windows.Forms.TextBox textBox_Ten;
        private System.Windows.Forms.TextBox textBox_Sdt;
        private System.Windows.Forms.TextBox textBox_diaChi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_lammoi;
    }
}