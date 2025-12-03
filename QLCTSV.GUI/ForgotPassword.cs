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
    public partial class ForgotPassword : Form
    {
        private readonly HttpClient _httpClient = new HttpClient()
        {
            // thiết lập URL cho http client
            BaseAddress = new Uri("https://backendfinalproject-production-9fa0.up.railway.app/")
        };
        public ForgotPassword()
        {
            InitializeComponent();
            this.AcceptButton = button_XacNhan;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SVSignIn sVSignIn = new SVSignIn();
            this.Hide();
            sVSignIn.Show();
        }

        private async void button_XacNhan_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các TextBox của Form này
            var requestData = new ResetPasswordRequestDTO
            {
                MaSV = textBox_MaSV.Text.Trim(),
                SoDienThoaiXacThuc = textBox_sdt.Text.Trim(),
                MatKhauMoi = textBox_MatKhauMoi.Text // Lưu ý: Cần hash mật khẩu nếu Backend có hash!
            };

            if (string.IsNullOrEmpty(requestData.MaSV) || string.IsNullOrEmpty(requestData.MatKhauMoi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            button_XacNhan.Enabled = false;

            try
            {
                string jsonContent = JsonSerializer.Serialize(requestData);
                var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                // Gọi API POST /auth/reset-password
                HttpResponseMessage response = await _httpClient.PostAsync("api/auth/reset-password", httpContent);

                string jsonResponse = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<ResponseMessageDTO>(jsonResponse, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                // 1. Xử lý thành công (200 OK)
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(result?.Message ?? "Đổi mật khẩu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SVSignIn sVSignIn = new SVSignIn();
                    sVSignIn.Show();
                    this.Close(); // Đóng Form Reset Password
                }
                // 2. Xử lý lỗi nghiệp vụ (400 Bad Request)
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    // Backend trả về message lỗi chi tiết (ví dụ: "Số điện thoại xác thực không chính xác!")
                    MessageBox.Show(result?.Message ?? "Dữ liệu không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Lỗi hệ thống khác
                    MessageBox.Show($"Lỗi hệ thống: {response.StatusCode} - {result?.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối API: {ex.Message}", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                button_XacNhan.Enabled = true;
            }
        }

    }
}
