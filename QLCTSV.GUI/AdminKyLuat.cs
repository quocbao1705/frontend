using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using QLCTSV.DTO.AdminDTO; // Đảm bảo namespace DTO đúng

namespace QLCTSV.GUI
{
    public partial class AdminKyLuat : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private string baseUrl = "https://backendfinalproject-production-9fa0.up.railway.app/";

        // ĐÃ XÓA: private int _selectedId = -1; (Không cần dùng nữa)

        public AdminKyLuat()
        {
            InitializeComponent();
        }

        private void AdminKyLuat_Load(object sender, EventArgs e)
        {
            LoadTheme();
            SetupComboBox();
            SetupDataGridView(); // Cấu hình code cho chắc chắn

            LoadDSSinhVien(); // Bảng dưới (dataGridView1)
            LoadDSKyLuat();   // Bảng trên (dataGridView2)
        }

        // Cấu hình code để tránh trường hợp bạn quên chỉnh trong Design
        private void SetupDataGridView()
        {
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
            dataGridView2.ReadOnly = true;
        }

        private void SetupComboBox()
        {
            if (comboBox_hocKy.Items.Count == 0)
                comboBox_hocKy.Items.AddRange(new string[] { "1", "2", "3" });

            if (comboBox_namhoc.Items.Count == 0)
                comboBox_namhoc.Items.AddRange(new string[] { "2023-2024", "2024-2025", "2025-2026", "2026-2027" });

            if (comboBox_hinhthuc.Items.Count == 0)
                comboBox_hinhthuc.Items.AddRange(new string[] {
                    "Nhắc nhở", "Cảnh báo học vụ", "Đình chỉ học tập", "Buộc thôi học"
                });

            comboBox_hocKy.SelectedIndex = 0;
            comboBox_namhoc.SelectedIndex = 0;
        }

        // ==========================================================
        // 1. LOAD DATA
        // ==========================================================
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

        private async void LoadDSKyLuat()
        {
            // Reset grid để tránh lỗi hiển thị
            dataGridView2.DataSource = null;
            try
            {
                string url = baseUrl + "api/ctsv/danh-sach-ky-luat-sinh-vien";
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var listKL = JsonConvert.DeserializeObject<List<KyLuatDTO>>(json);
                    dataGridView2.DataSource = listKL;
                    FormatGridKyLuat();
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi load Kỷ luật: " + ex.Message); }
        }

        private void FormatGridKyLuat()
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
            if (dataGridView2.Columns["HinhThuc"] != null) dataGridView2.Columns["HinhThuc"].HeaderText = "Hình Thức";
            if (dataGridView2.Columns["LyDo"] != null) dataGridView2.Columns["LyDo"].HeaderText = "Lý Do";
            if (dataGridView2.Columns["NgayQuyetDinh"] != null) dataGridView2.Columns["NgayQuyetDinh"].HeaderText = "Ngày Quyết Định";
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // ==========================================================
        // 2. SỰ KIỆN CLICK (Chỉ hiển thị lên TextBox, không lưu ID)
        // ==========================================================

        // Click bảng Sinh Viên (Bảng Dưới) -> Để chuẩn bị THÊM mới
        private void dataGridView_SinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            textBox_MaSV.Text = row.Cells["MaSV"].Value?.ToString().Trim();
            textBox_MaSV.Enabled = false; // Khóa lại
            dataGridView1.ReadOnly = true;
            // Reset các ô nhập liệu khác để nhập mới
            comboBox_hinhthuc.SelectedIndex = -1;
            textBox_lyDo.Clear();
            dateTimePicker_date.Value = DateTime.Now;
        }

        // Click bảng Kỷ Luật (Bảng Trên) -> Để chuẩn bị SỬA/XÓA
        private void dataGridView_KyLuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

            // Đổ dữ liệu lên TextBox để người dùng sửa
            textBox_MaSV.Text = row.Cells["MaSV"].Value?.ToString().Trim();
            comboBox_hinhthuc.Text = row.Cells["HinhThuc"].Value?.ToString();
            textBox_lyDo.Text = row.Cells["LyDo"].Value?.ToString();
            comboBox_hocKy.Text = row.Cells["HocKy"].Value?.ToString();
            comboBox_namhoc.Text = row.Cells["NamHoc"].Value?.ToString();

            dataGridView1.ReadOnly = true;
            if (DateTime.TryParse(row.Cells["NgayQuyetDinh"].Value?.ToString(), out DateTime date))
            {
                dateTimePicker_date.Value = date;
            }

            textBox_MaSV.Enabled = false;
            // KHÔNG CẦN LƯU _selectedId Ở ĐÂY NỮA
        }

        // ==========================================================
        // 3. CHỨC NĂNG THÊM - SỬA - XÓA
        // ==========================================================

        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_MaSV.Text))
            {
                MessageBox.Show("Vui lòng chọn Sinh viên từ bảng dưới!");
                return;
            }

            var input = new KyLuatDTO()
            {
                MaSV = textBox_MaSV.Text.Trim(),
                HinhThuc = comboBox_hinhthuc.Text,
                LyDo = textBox_lyDo.Text,
                HocKy = comboBox_hocKy.Text,
                NamHoc = comboBox_namhoc.Text,
                NgayQuyetDinh = dateTimePicker_date.Value.ToUniversalTime()
            };

            if (string.IsNullOrEmpty(input.HinhThuc) || string.IsNullOrEmpty(input.LyDo))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                string json = JsonConvert.SerializeObject(input);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                string url = baseUrl + "api/ctsv/nhap-ky-luat";

                HttpResponseMessage response = await client.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Thêm thành công!");
                    LoadDSKyLuat();
                    btnHuy_Click(sender, e);
                }
                else
                {
                    string err = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Lỗi: " + err);
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            // 1. KIỂM TRA QUAN TRỌNG: Người dùng có đang chọn dòng nào ở BẢNG KỶ LUẬT không?
            // CurrentRow là dòng hiện tại đang được bôi đen
            if (dataGridView2.CurrentRow == null || dataGridView2.CurrentRow.Index < 0)
            {
                MessageBox.Show("Vui lòng CHỌN DÒNG CẦN SỬA ở bảng Kỷ Luật (Bảng trên)!", "Chưa chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy ID trực tiếp từ Grid (Chính xác tuyệt đối)
            DataGridViewRow selectedRow = dataGridView2.CurrentRow;

            // Kiểm tra xem dòng này có ID không (tránh dòng trống)
            if (selectedRow.Cells["Id"].Value == null) return;

            int idCanSua = int.Parse(selectedRow.Cells["Id"].Value.ToString());

            // Lấy MaSV gốc từ Grid để tạo URL (An toàn hơn lấy từ TextBox)
            string maSVOriginal = selectedRow.Cells["MaSV"].Value.ToString().Trim();

            try
            {
                // 2. Tạo DTO
                var input = new KyLuatDTO()
                {
                    Id = idCanSua, // Gán ID lấy từ Grid
                    MaSV = textBox_MaSV.Text.Trim(), // Data mới
                    HinhThuc = comboBox_hinhthuc.Text,
                    LyDo = textBox_lyDo.Text,
                    HocKy = comboBox_hocKy.Text,
                    NamHoc = comboBox_namhoc.Text,
                    NgayQuyetDinh = dateTimePicker_date.Value.Date.ToUniversalTime()
                };

                string json = JsonConvert.SerializeObject(input);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                // URL backend yêu cầu: .../update-kyluat/{MaSV}
                // Dùng Uri.EscapeDataString để xử lý ký tự lạ nếu có
                string url = baseUrl + $"api/ctsv/update-kyluat/{Uri.EscapeDataString(maSVOriginal)}";

                HttpResponseMessage response = await client.PutAsync(url, content);

                // ... Đoạn try ở trên giữ nguyên ...

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    LoadDSKyLuat();
                    btnHuy_Click(sender, e);
                }
                else
                {
                    // ĐỌC LỖI CHI TIẾT TỪ SERVER
                    string errorBody = await response.Content.ReadAsStringAsync();

                    // Hiện thông báo lỗi đầy đủ để debug
                    // Bạn hãy chụp màn hình lỗi này gửi tôi nếu nó hiện ra
                    MessageBox.Show($"Server trả về lỗi ({response.StatusCode}):\n\n{errorBody}", "Chi tiết lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // ...
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra chọn dòng trực tiếp từ GridView
            if (dataGridView2.CurrentRow == null || dataGridView2.CurrentRow.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa ở bảng Kỷ Luật!");
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
                    string url = baseUrl + $"api/ctsv/ky-luat/{idCanXoa}";
                    HttpResponseMessage response = await client.DeleteAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Xóa thành công!");
                        LoadDSKyLuat();
                        btnHuy_Click(sender, e);
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            textBox_MaSV.Clear();
            textBox_lyDo.Clear();
            comboBox_hinhthuc.SelectedIndex = -1;
            dateTimePicker_date.Value = DateTime.Now;
            textBox_MaSV.Enabled = true;

            // Xóa chọn trên lưới để tránh nhầm lẫn
            dataGridView2.ClearSelection();
            dataGridView1.ClearSelection();
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
            label_HTKL.ForeColor = ThemeColor.PrimaryColor;
            if (label_HTKL != null) label_HTKL.ForeColor = ThemeColor.PrimaryColor;
            if (label_DSSV != null) label_DSSV.ForeColor = ThemeColor.PrimaryColor;
        }
    }
}