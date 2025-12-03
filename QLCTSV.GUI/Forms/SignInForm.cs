using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLCTSV.GUI
{
    public partial class SignInForm: Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SVSignIn svsignin = new SVSignIn();
            this.Hide();
            // Hiển thị form dưới dạng dialog
            svsignin.Show();
        }

        private void button_DangNhap_Click(object sender, EventArgs e)
        {
           if(textBox_TaiKhoan.Text == "admin" && textBox_matKhau.Text == "abc123")
            {
                AdminForm adminForm = new AdminForm();
                this.Hide();
                // Hiển thị form dưới dạng dialog
                adminForm.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_TaiKhoan_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
