using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using QLCTSV.DTO.AdminDTO;
using Newtonsoft.Json;

namespace QLCTSV.GUI
{
    public partial class AdminSV: Form
    {
        public AdminSV()
        {
            InitializeComponent();
        }

        private static readonly HttpClient client = new HttpClient();

        private string baseUrl = "https://backendfinalproject-production-9fa0.up.railway.app/"; 

        private void AdminSV_Load(object sender, EventArgs e)
        {
            LoadTheme();
            LoadData();
        }
        private async void LoadData()
        {
            try
            {
                string url = baseUrl + "api/ctsv/danh-sach-sinh-vien";
                HttpResponseMessage response = await client.GetAsync(url);

                // 2. Kiểm tra kết quả
                if (response.IsSuccessStatusCode)
                {
                    // 3. Đọc dữ liệu JSON trả về
                    string jsonContent = await response.Content.ReadAsStringAsync();

                    // 4. Deserialize JSON thành danh sách SinhVienDTO
                    List<SinhVienDTO> listSV = JsonConvert.DeserializeObject<List<SinhVienDTO>>(jsonContent);

                    dataGridView1.DataSource = listSV;
                    dataGridView1.Columns["MaSV"].HeaderText = "Mã sinh viên";
                    dataGridView1.Columns["HoTen"].HeaderText = "Họ và Tên";
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("Không thể tải dữ liệu: " + response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load data: " + ex.Message);
            }
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            Label_Chung.ForeColor = ThemeColor.PrimaryColor;
        }
        private SinhVienDTO GetSinhVienFromUI()
        {
            return new SinhVienDTO()
            {

                MaSV = textBox_MaSV.Text.Trim(),
                HoTen = textBox_Ten.Text.Trim(),
                NgaySinh = dateTimePicker_date.Value,
                GioiTinh = comboBox_GT.Text.Trim(),
                DiaChi = textBox_diaChi.Text.Trim(),
                SoDienThoai = textBox_Sdt.Text.Trim()
            };
        }

        private async void button_them_Click(object sender, EventArgs e)
        {
            // Kiểm tra logic nhỏ: Nếu MaSV đang bị khóa (tức là đang chọn sửa), không cho bấm Thêm
            if (textBox_MaSV.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ xem/sửa. Vui lòng bấm nút 'Làm mới' để thêm sinh viên mới.");
                return;
            }
            // Kiểm tra logic nhỏ: Mã SV không được để trống
            if (string.IsNullOrWhiteSpace(textBox_MaSV.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Sinh Viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_MaSV.Focus(); // Đưa con trỏ chuột về ô này
                return; // Dừng lại, không chạy tiếp code bên dưới
            }

            try
            {
                SinhVienDTO sv = GetSinhVienFromUI();
                string json = JsonConvert.SerializeObject(sv);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(baseUrl + "api/ctsv/add-student", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Thêm sinh viên thành công!");
                    LoadData();
                    // Gọi hàm Reset form sau khi thêm thành công
                    button_lammoi_Click(sender, e);
                }
                else
                {
                    // Đọc kỹ lỗi từ server gửi về (ví dụ: Trùng mã SV)
                    string errorContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Thêm thất bại. Lỗi: " + response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }

        private async void button_sua_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra mã SV (Không cho sửa nếu để trống)
            if (string.IsNullOrEmpty(textBox_MaSV.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_Ten.Text))
            {
                MessageBox.Show("Tên sinh viên không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SinhVienDTO sv = GetSinhVienFromUI();
                string json = JsonConvert.SerializeObject(sv);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                string url = baseUrl + "api/ctsv/update-student/" + sv.MaSV;

                HttpResponseMessage response = await client.PutAsync(url, content);

                // 5. Kiểm tra kết quả
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cập nhật thông tin thành công!");
                    LoadData(); // Load lại bảng để thấy thay đổi
                }
                else
                {
                    // Đọc lỗi từ backend gửi về (nếu có)
                    string errorMsg = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Cập nhật thất bại. Server báo: {response.StatusCode} - {errorMsg}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }

        private async void button_xoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có mã SV chưa
            string maSV = textBox_MaSV.Text;
            if (string.IsNullOrEmpty(maSV))
            {
                MessageBox.Show("Vui lòng nhập hoặc chọn Mã SV cần xóa");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Gọi API DELETE
                    string url = baseUrl + "api/ctsv/delete-student/" + maSV;
                    HttpResponseMessage response = await client.DeleteAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Xóa thành công!");
                        LoadData();
                        // Reset form sau khi xóa xong
                        button_lammoi_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại: " + response.ReasonPhrase);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }


        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            // Dùng ?.ToString() để tránh lỗi nếu ô đó null
            textBox_MaSV.Text = row.Cells["MaSV"].Value?.ToString();
            textBox_Ten.Text = row.Cells["HoTen"].Value?.ToString();
            textBox_diaChi.Text = row.Cells["DiaChi"].Value?.ToString();
            textBox_Sdt.Text = row.Cells["SoDienThoai"].Value?.ToString();

            if (DateTime.TryParse(row.Cells["NgaySinh"].Value?.ToString(), out DateTime date))
            {
                dateTimePicker_date.Value = date;
            }

            comboBox_GT.Text = row.Cells["GioiTinh"].Value?.ToString();

            // Khóa Mã SV để tránh sửa nhầm Primary Key
            textBox_MaSV.Enabled = false;
        }


        private void button_lammoi_Click(object sender, EventArgs e)
        {
            // 1. Xóa trắng các ô
            textBox_MaSV.Clear();
            textBox_Ten.Clear();
            textBox_diaChi.Clear();
            textBox_Sdt.Clear();
            dateTimePicker_date.Value = DateTime.Now;
            comboBox_GT.SelectedIndex = -1; // Reset combobox

            // 2. MỞ KHÓA lại ô Mã SV để người dùng nhập mới
            textBox_MaSV.Enabled = true;
        }
    }
}
