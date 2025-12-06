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


        private void AdminDiem_Load(object sender, EventArgs e)
        {
            LoadTheme();
            SetupComboBox();
            LoadDSDiem();
            LoadDSSinhVien();
            SetupDataGridView();
        }
        private void SetupDataGridView()
        {
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
            dataGridView2.ReadOnly = true;
        }
        private void SetupComboBox()
        {
            if (comboBox_hocKy.Items.Count == 0)
            {
                comboBox_hocKy.Items.AddRange(new string[] { "1", "2", "3" });
                comboBox_hocKy.SelectedIndex = 0;
            }
            // Thêm dữ liệu mẫu cho Năm học nếu chưa có
            if (comboBox_Namhoc.Items.Count == 0)
            {
                comboBox_Namhoc.Items.AddRange(new string[] { "2023-2024", "2024-2025", "2025-2026", "2026-2027" });
                comboBox_Namhoc.SelectedIndex = 0;
            }

        }
        private async void LoadDSSinhVien()
        {
            try
            {
                string url = baseUrl + "api/ctsv/danh-sach-sinh-vien";
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var listSV = JsonConvert.DeserializeObject<List<SinhVienDTO>>(json);
                    dataGridView1.DataSource = listSV;

                    if (dataGridView1.Columns["MaSV"] != null) dataGridView1.Columns["MaSV"].HeaderText = "Mã SV";
                    if (dataGridView1.Columns["HoTen"] != null) dataGridView1.Columns["HoTen"].HeaderText = "Họ Tên";
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi load SV: " + ex.Message); }
        }
        private async void LoadDSDiem()
        {
            // Reset grid để tránh lỗi hiển thị
            dataGridView2.DataSource = null;
            try
            {
                string url = baseUrl + "api/ctsv/danh-sach-diem-sinh-vien";
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string jsonContent = await response.Content.ReadAsStringAsync();
                    List<ThemDiemDTO> listDiem = JsonConvert.DeserializeObject<List<ThemDiemDTO>>(jsonContent);
                    dataGridView2.DataSource = listDiem;
                    FormatGridDiem();
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi load Kỷ luật: " + ex.Message); }
        }
        private void FormatGridDiem()
        {
            if (dataGridView2.Columns["Id"] != null) dataGridView2.Columns["Id"].Visible = false;
            // Ẩn bớt các cột không cần thiết...
            if (dataGridView2.Columns["MaSV"] != null) dataGridView2.Columns["MaSV"].HeaderText = "Mã SV";
            if (dataGridView2.Columns["HoTen"] != null)
            {
                dataGridView2.Columns["HoTen"].Visible = true;
                dataGridView2.Columns["HoTen"].HeaderText = "Họ và Tên";
                dataGridView2.Columns["HoTen"].DisplayIndex = 2;
            }
            if (dataGridView2.Columns["DiemRenLuyen"] != null) dataGridView2.Columns["DiemRenLuyen"].HeaderText = "ĐRL";
            if (dataGridView2.Columns["XepLoaiHocLuc"] != null) dataGridView2.Columns["XepLoaiHocLuc"].HeaderText = "Xếp Loại";
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            textBox_GPA.Clear();
            textBox_Drl.Clear();

            // Mở khóa lại các ô quan trọng
            textBox_MaSV.Enabled = true;
            dataGridView2.ClearSelection();
            dataGridView1.ClearSelection();
        }
        private ThemDiemDTO GetDiemFromUI()
        {
            // --- Xử lý GPA ---
            double gpa = 0;
            string gpaText = textBox_GPA.Text.Replace(',', '.');

            // Kiểm tra có phải là số không
            if (!double.TryParse(gpaText, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out gpa))
            {
                MessageBox.Show("Điểm GPA không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            // Kiểm tra khoảng giá trị (Yêu cầu của bạn)
            if (gpa < 0 || gpa > 4.0)
            {
                MessageBox.Show("Điểm GPA phải nằm trong khoảng 0 - 4.0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null; // Trả về null để nút Thêm dừng lại
            }

            // --- Xử lý ĐRL ---
            if (!int.TryParse(textBox_Drl.Text, out int drl))
            {
                MessageBox.Show("Điểm rèn luyện không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (drl < 0 || drl > 100)
            {
                MessageBox.Show("Điểm rèn luyện phải nằm trong khoảng 0 - 100", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return new ThemDiemDTO()
            {
                MaSV = textBox_MaSV.Text.Trim(),
                HocKy = comboBox_hocKy.Text.Trim(),
                NamHoc = comboBox_Namhoc.Text.Trim(),
                GPA = gpa,
                DiemRenLuyen = drl,
                XepLoaiHocLuc = ""
            };
        }
        private async void button_them_Click(object sender, EventArgs e)
        {
            // 1. Chỉ kiểm tra xem đã có mã sinh viên chưa (Không quan tâm Enabled hay Disabled)
            if (string.IsNullOrEmpty(textBox_MaSV.Text))
            {
                MessageBox.Show("Vui lòng chọn Sinh viên từ bảng dưới hoặc nhập Mã SV!");
                return;
            }

            try
            {
                // 2. Gọi hàm lấy dữ liệu (Hàm này đã có Validation GPA/ĐRL bên dưới)
                ThemDiemDTO diem = GetDiemFromUI();

                // Nếu hàm GetDiemFromUI trả về null (do nhập sai), thì dừng lại
                if (diem == null) return;

                // 3. Kiểm tra trùng lặp (Giữ nguyên logic cũ của bạn)
                var currentList = dataGridView2.DataSource as List<ThemDiemDTO>;
                if (currentList != null)
                {
                    bool isDuplicate = currentList.Any(x =>
                        x.MaSV.ToLower() == diem.MaSV.ToLower() &&
                        x.HocKy.ToLower() == diem.HocKy.ToLower() &&
                        x.NamHoc == diem.NamHoc);

                    if (isDuplicate)
                    {
                        MessageBox.Show($"Sinh viên {diem.MaSV} đã có điểm của {diem.HocKy}, năm {diem.NamHoc}.\nVui lòng chọn dòng đó và bấm 'Sửa' nếu muốn thay đổi.",
                            "Trùng dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // 4. Gọi API Thêm
                string json = JsonConvert.SerializeObject(diem);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(baseUrl + "api/ctsv/nhap-diem", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Nhập điểm thành công!");
                    LoadDSDiem(); // Tải lại bảng điểm
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
            // Kiểm tra chưa nhập mã sinh viên
            if (string.IsNullOrEmpty(textBox_MaSV.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa điểm.");
                return;
            }

            try
            {
                ThemDiemDTO diem = GetDiemFromUI();
                if (diem == null) return;
                string json = JsonConvert.SerializeObject(diem);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                // Gọi API Update
                // Sử dụng Uri.EscapeDataString để đảm bảo mã SV an toàn trong URL
                string url = baseUrl + $"api/ctsv/update-diem/{Uri.EscapeDataString(diem.MaSV)}";

                HttpResponseMessage response = await client.PutAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cập nhật điểm thành công!");
                    LoadDSDiem(); // Tải lại bảng để thấy Xếp loại mới do Backend tính
                    button_lammoi_Click(sender, e);
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
            // 1. Kiểm tra chọn dòng trực tiếp từ GridView
            if (dataGridView2.CurrentRow == null || dataGridView2.CurrentRow.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa ở bảng Danh Sách Điểm!");
                return;
            }

            DataGridViewRow selectedRow = dataGridView2.CurrentRow;
            if (selectedRow.Cells["Id"].Value == null) return;

            // Lấy ID trực tiếp
            int idCanXoa = int.Parse(selectedRow.Cells["Id"].Value.ToString());

            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                try
                {
                    // URL Xóa
                    string url = baseUrl + $"api/ctsv/diem/{idCanXoa}";
                    HttpResponseMessage response = await client.DeleteAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Xóa thành công!");
                        LoadDSDiem(); // Tải lại bảng để thấy Xếp loại mới do Backend tính
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
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }


        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            textBox_MaSV.Text = row.Cells["MaSV"].Value?.ToString().Trim();
            textBox_MaSV.Enabled = false; // Khóa lại
            dataGridView1.ReadOnly = true;
            // Reset các ô nhập liệu khác để nhập mới
            textBox_GPA.Clear();
            textBox_Drl.Clear();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

            // Đổ dữ liệu lên TextBox để người dùng sửa
            textBox_MaSV.Text = row.Cells["MaSV"].Value?.ToString().Trim();
            textBox_MaSV.Enabled = false;
            textBox_GPA.Text = row.Cells["GPA"].Value?.ToString();
            comboBox_hocKy.Text = row.Cells["HocKy"].Value?.ToString();
            comboBox_Namhoc.Text = row.Cells["NamHoc"].Value?.ToString();
            textBox_Drl.Text = row.Cells["DiemRenLuyen"].Value?.ToString();
        }
    }
}
