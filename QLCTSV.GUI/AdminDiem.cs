using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCTSV.DTO.AdminDTO;
using Newtonsoft.Json;
using System.Net.Http;
using System.Globalization;

namespace QLCTSV.GUI
{
    public partial class AdminDiem: Form
    {
        private static readonly HttpClient client = new HttpClient();
        private string baseUrl = "https://backendfinalproject-production-9fa0.up.railway.app/";
        public AdminDiem()
        {
            InitializeComponent();
        }
        
        private void Label_Chung_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void AdminDiem_Load(object sender, EventArgs e)
        {
            LoadTheme();
            SetupComboBox();
            LoadData();
        }
        private void SetupComboBox()
        {
            if (comboBox_hocKy.Items.Count == 0)
            {
                comboBox_hocKy.Items.AddRange(new string[] { "1", "2", "3" });
                comboBox_hocKy.SelectedIndex = 0; // Chọn mặc định HK 1
            }
            // Thêm dữ liệu mẫu cho Năm học nếu chưa có
            if (comboBox_Namhoc.Items.Count == 0)
            {
                comboBox_Namhoc.Items.AddRange(new string[] { "2023-2024", "2024-2025", "2025-2026", "2026-2027" });
            }
        }
        private async void LoadData()
        {
            try
            {
                // Gọi API lấy danh sách điểm
                string url = baseUrl + "api/ctsv/danh-sach-diem-sinh-vien";
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonContent = await response.Content.ReadAsStringAsync();
                    List<ThemDiemDTO> listDiem = JsonConvert.DeserializeObject<List<ThemDiemDTO>>(jsonContent);
                    var sortedList = listDiem.OrderBy(x => x.MaSV)
                         .ThenBy(x => x.NamHoc)
                         .ThenBy(x => x.HocKy)
                         .ToList();

                    dataGridView1.DataSource = sortedList;

                    // Đặt tên cột tiếng Việt
                    if (dataGridView1.Columns["MaSV"] != null) dataGridView1.Columns["MaSV"].HeaderText = "Mã SV";
                    if (dataGridView1.Columns["HocKy"] != null) dataGridView1.Columns["HocKy"].HeaderText = "Học Kỳ";
                    if (dataGridView1.Columns["NamHoc"] != null) dataGridView1.Columns["NamHoc"].HeaderText = "Năm Học";
                    if (dataGridView1.Columns["DiemRenLuyen"] != null) dataGridView1.Columns["DiemRenLuyen"].HeaderText = "ĐRL";
                    if (dataGridView1.Columns["XepLoaiHocLuc"] != null) dataGridView1.Columns["XepLoaiHocLuc"].HeaderText = "Xếp Loại";
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("Không thể tải dữ liệu điểm: " + response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }
        
        private ThemDiemDTO GetDiemFromUI()
        {
            // 1. Xử lý GPA
            double gpa = 0;
            string gpaText = textBox_GPA.Text.Replace(',', '.');
            if (!double.TryParse(gpaText, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out gpa))
            {
                gpa = 0;
            }
            // Giới hạn
            if (gpa > 4.0) gpa = 4.0;
            if (gpa < 0) gpa = 0;

            // 2. Xử lý ĐRL
            if (!int.TryParse(textBox_Drl.Text, out int drl)) drl = 0;
            if (drl > 100) drl = 100;
            if (drl < 0) drl = 0;

            return new ThemDiemDTO()
            {
                MaSV = textBox_MaSV.Text.Trim(),
                HocKy = comboBox_hocKy.Text.Trim(),
                NamHoc = comboBox_Namhoc.Text.Trim(),
                GPA = gpa,
                DiemRenLuyen = drl,

                // Không cần gửi xếp loại, Backend sẽ ghi đè cái này
                XepLoaiHocLuc = ""
            };
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
            if (Label_Chung != null) Label_Chung.ForeColor = ThemeColor.PrimaryColor;
        }

        private void button_lammoi_Click(object sender, EventArgs e)
        {
            textBox_MaSV.Clear();
            comboBox_Namhoc.SelectedIndex = -1;
            textBox_GPA.Clear();
            textBox_Drl.Clear();

            // Mở khóa lại các ô quan trọng
            textBox_MaSV.Enabled = true;
            comboBox_hocKy.Enabled = true;
            comboBox_Namhoc.Enabled = true;
        }

        private async void button_them_Click(object sender, EventArgs e)
        {
            if (textBox_MaSV.Enabled == false)
            {
                MessageBox.Show("Vui lòng bấm 'Hủy chọn' trước khi thêm mới.");
                return;
            }

            try
            {
                ThemDiemDTO diem = GetDiemFromUI();
                var currentList = dataGridView1.DataSource as List<ThemDiemDTO>;
                if (currentList != null)
                {
                    // Kiểm tra xem có dòng nào trùng khớp cả 3 thông tin không
                    bool isDuplicate = currentList.Any(x =>
                        x.MaSV.ToLower() == diem.MaSV.ToLower() &&
                        x.HocKy.ToLower() == diem.HocKy.ToLower() &&
                        x.NamHoc == diem.NamHoc);

                    if (isDuplicate)
                    {
                        MessageBox.Show($"Sinh viên {diem.MaSV} đã có điểm của {diem.HocKy}, năm {diem.NamHoc}.\nVui lòng chọn dòng đó và bấm 'Sửa' nếu muốn thay đổi.",
                            "Trùng dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Dừng lại, không gửi API nữa
                    }
                }

                // Validate cơ bản
                if (string.IsNullOrEmpty(diem.MaSV) || string.IsNullOrEmpty(diem.HocKy))
                {
                    MessageBox.Show("Vui lòng nhập Mã SV và Học kỳ.");
                    return;
                }

                string json = JsonConvert.SerializeObject(diem);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(baseUrl + "api/ctsv/nhap-diem", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Nhập điểm thành công!");
                    LoadData();
                    button_lammoi_Click(sender, e); // Reset form
                }
                else
                {
                    string err = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Thất bại: " + err);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private async void button_sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_MaSV.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa điểm.");
                return;
            }

            try
            {
                ThemDiemDTO diem = GetDiemFromUI();
                string json = JsonConvert.SerializeObject(diem);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                // API Update: api/ctsv/update-diem/{maSV}
                // Lưu ý: Logic backend của bạn cần xử lý việc update đúng kỳ/năm học dựa trên body gửi lên
                string url = baseUrl + "api/ctsv/update-diem/" + diem.MaSV;

                HttpResponseMessage response = await client.PutAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cập nhật điểm thành công!");
                    LoadData();
                }
                else
                {
                    string err = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Cập nhật thất bại: " + err);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private async void button_xoa_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra đã chọn dòng chưa
            if (textBox_MaSV.Enabled == true || string.IsNullOrEmpty(textBox_MaSV.Text))
            {
                MessageBox.Show("Vui lòng chọn dòng điểm cần xóa từ danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maSV = textBox_MaSV.Text.Trim();
            string hocKy = comboBox_hocKy.Text.Trim();
            string namHoc = comboBox_Namhoc.Text.Trim();

            var confirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa điểm của {maSV}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    // --- SỬA LỖI 415 TẠI ĐÂY ---

                    // Bước 1: Tạo đối tượng chứa dữ liệu cần xóa
                    // (Tên biến phải khớp với DTO bên Backend mong đợi)
                    var deleteData = new
                    {
                        MaSV = maSV,
                        HocKy = hocKy,
                        NamHoc = namHoc
                    };

                    // Bước 2: Tạo Request Message thủ công để có thể gắn Body vào DELETE
                    var request = new HttpRequestMessage
                    {
                        Method = HttpMethod.Delete,
                        RequestUri = new Uri(baseUrl + "api/ctsv/Delete-scores"),
                        // Đóng gói dữ liệu thành JSON
                        Content = new StringContent(JsonConvert.SerializeObject(deleteData), Encoding.UTF8, "application/json")
                    };

                    // Bước 3: Gửi Request bằng SendAsync
                    HttpResponseMessage response = await client.SendAsync(request);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Xóa điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        button_lammoi_Click(sender, e);
                    }
                    else
                    {
                        string err = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Xóa thất bại: " + err);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hệ thống: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            textBox_MaSV.Text = row.Cells["MaSV"].Value?.ToString();
            comboBox_hocKy.Text = row.Cells["HocKy"].Value?.ToString();
            comboBox_Namhoc.Text = row.Cells["NamHoc"].Value?.ToString();
            textBox_GPA.Text = row.Cells["GPA"].Value?.ToString();
            textBox_Drl.Text = row.Cells["DiemRenLuyen"].Value?.ToString();

            // Khi sửa điểm, KHÔNG ĐƯỢC sửa Mã SV, Học Kỳ, Năm Học
            textBox_MaSV.Enabled = false;
        }
    }
}
