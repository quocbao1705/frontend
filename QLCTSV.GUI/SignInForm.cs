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
using System.Net.Http;
using System.Text.Json;
using QLCTSV.DTO;

namespace QLCTSV.GUI
{
    public partial class SignInForm: Form
    {

        // khởi tạo http client
        private readonly HttpClient _httpClient = new HttpClient()
        {
            // thiết lập URL cho http client
            BaseAddress = new Uri("https://backendfinalproject-production-9fa0.up.railway.app/")
        };

        public SignInForm()
        {
            InitializeComponent();
            this.AcceptButton = button_DangNhap;
            textBox_matKhau.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private async void button_DangNhap_Click(object sender, EventArgs e)
        {
            string username = textBox_TaiKhoan.Text.Trim();
            string password = textBox_matKhau.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tài khoản và Mật khẩu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tắt nút để tránh click kép trong khi chờ API
            button_DangNhap.Enabled = false;

            try
            {
                // 1. Chuẩn bị dữ liệu gửi đi (LoginRequestDTO)
                var loginData = new AuthRequestDTO
                {
                    Username = username,
                    Password = password
                };

                string jsonContent = JsonSerializer.Serialize(loginData);
                var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                // 2. Gọi API POST /auth/login
                HttpResponseMessage response = await _httpClient.PostAsync("api/auth/login", httpContent);

                // Đăng nhập thành công (200 OK)
                string jsonResponse = await response.Content.ReadAsStringAsync();

                // Deserialize kết quả
                var result = JsonSerializer.Deserialize<AuthResponseDTO>(jsonResponse, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
               
                // 3. Xử lý phản hồi
                if (result.Role == "SinhVien")
                {
                    MessageBox.Show("Sinh viên không được phép đăng nhập ở đây! Vui lòng đăng nhập ở nút 'Đăng nhập bằng tài khoản sinh viên' bên dưới.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Đăng nhập thành công! Vai trò: {result.Role}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cán bộ đăng nhập thành công sẽ chuyển đến giao diện cho Admin
                        AdminForm adminForm = new AdminForm();
                        this.Hide();
                        adminForm.Show();
                    
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    // Sai TK/MK (401 Unauthorized)
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Các lỗi hệ thống khác (ví dụ: 500)
                    MessageBox.Show($"Lỗi hệ thống: {response.StatusCode}. Vui lòng kiểm tra Server.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Lỗi kết nối mạng, server chưa bật, v.v.
                MessageBox.Show($"Lỗi kết nối API: {ex.Message}", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                button_DangNhap.Enabled = true; // Bật lại nút
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
