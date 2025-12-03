using QLCTSV.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCTSV.GUI
{
    public partial class SVSignIn: Form
    {
        public static string TaiKhoanDangNhap = "";
        // khởi tạo http client
        private readonly HttpClient _httpClient = new HttpClient()
        {
            // thiết lập URL cho http client
            BaseAddress = new Uri("https://backendfinalproject-production-9fa0.up.railway.app/")
        };

        public SVSignIn()
        {
            InitializeComponent();
            this.AcceptButton = button_DangNhap;
            textBox_MKSV.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_TaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void button_DangNhap_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void SVSignIn_Load(object sender, EventArgs e)
        {

        }

        private async void button_DangNhap_Click_1(object sender, EventArgs e)
        {
            string username = textBox_TaiKhoanSV.Text.Trim();
            string password = textBox_MKSV.Text;

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

                if (response.IsSuccessStatusCode)
                {
                    var result = JsonSerializer.Deserialize<AuthResponseDTO>(jsonResponse, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    // Kiểm tra quyền Sinh Viên
                    if (result.Role == "SinhVien")
                    {
                        // LƯU LẠI MÃ SINH VIÊN VỪA ĐĂNG NHẬP
                        SVSignIn.TaiKhoanDangNhap = username;

                        MessageBox.Show($"Đăng nhập thành công! Xin chào {username}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        SVinterface svform = new SVinterface();
                        this.Hide();
                        svform.Show();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản này không phải là Sinh viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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
                button_DangNhap.Enabled = true; 
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            this.Hide();
            signInForm.Show();
        }

        private void label_ForgotPass_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            this.Hide();
            forgotPassword.Show();
        }
    }
}
