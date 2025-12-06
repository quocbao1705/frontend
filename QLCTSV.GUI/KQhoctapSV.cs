using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using QLCTSV.DTO.SinhVienDTO;

namespace QLCTSV.GUI
{
    public partial class KQhoctapSV: Form
    {
        private static readonly HttpClient client = new HttpClient();
        private string baseUrl = "https://backendfinalproject-production-9fa0.up.railway.app/";
        public KQhoctapSV()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTheme(); 
            SetupComboBox();
            ResetDisplay();
        }
        private void SetupComboBox()
        {
            // Thêm dữ liệu mẫu nếu chưa có
            if (comboBox_hocky.Items.Count == 0)
            {
                comboBox_hocky.Items.AddRange(new string[] { "1", "2", "3" });
                comboBox_hocky.SelectedIndex = 0;
            }
            if (comboBox_namhoc.Items.Count == 0)
            {
                comboBox_namhoc.Items.AddRange(new string[] { "2023-2024", "2024-2025", "2025-2026", "2026-2027" });
                comboBox_namhoc.SelectedIndex = 0;
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
        }
        private void ResetDisplay()
        {
            label_gpa.Text = "--";
            label_drl.Text = "--";
            label_hocLuc.Text = "---";
            label_hocBong.Text = "---";

            // Màu mặc định
            richTextBox_kyLuat.BackColor = Color.Gray;
            panel_gpa.BackColor = Color.Gray;
            panel_drl.BackColor = Color.Gray;
            panel_hocLuc.BackColor = Color.Gray;
            panel_hocBong.BackColor = Color.Gray;
        }

        private async void button_xem_Click(object sender, EventArgs e)
        {
            string selectedHk = comboBox_hocky.Text.Trim();
            string hk = selectedHk;
            string nh = comboBox_namhoc.Text.Trim();
            string maSV = SVSignIn.TaiKhoanDangNhap;

            try
            {
                string url = $"{baseUrl}api/student/academic-result/{maSV}?HocKy={hk}&NamHoc={nh}";
                HttpResponseMessage response = await client.GetAsync(url);
                string jsonContent = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    KetQuaHocTapFullDTO kq = JsonConvert.DeserializeObject<KetQuaHocTapFullDTO>(jsonContent);

                    if (kq == null || (kq.GPA == null && string.IsNullOrEmpty(kq.message)))
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu kỳ này.");
                        ResetDisplay();
                    }
                    else if (!string.IsNullOrEmpty(kq.message))
                    {
                        // Trường hợp backend trả về message "Chưa có dữ liệu..."
                        MessageBox.Show(kq.message);
                        ResetDisplay();
                    }
                    else
                    {
                        // --- HIỂN THỊ DỮ LIỆU ---
                        DisplayData(kq);
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi tải dữ liệu: " + response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void DisplayData(KetQuaHocTapFullDTO kq)
        {
            // 1. GPA
            double gpa = kq.GPA ?? 0;
            label_gpa.Text = gpa.ToString("0.0"); // Hiển thị 1 số lẻ (VD: 3.5)

            // Đổi màu panel GPA theo điểm
            if (gpa >= 3.6) panel_gpa.BackColor = Color.SeaGreen;       // Xuất sắc
            else if (gpa >= 3.2) panel_gpa.BackColor = Color.DodgerBlue; // Giỏi
            else if (gpa >= 2.5) panel_gpa.BackColor = Color.Orange;     // Khá
            else panel_gpa.BackColor = Color.IndianRed;                  // TB/Yếu

            // 2. Điểm Rèn Luyện
            int drl = kq.DiemRenLuyen ?? 0;
            label_drl.Text = drl.ToString();

            if (drl >= 90) panel_drl.BackColor = Color.SeaGreen;
            else if (drl >= 80) panel_drl.BackColor = Color.DodgerBlue;
            else panel_drl.BackColor = Color.Orange;

            // 3. Học Lực
            label_hocLuc.Text = string.IsNullOrEmpty(kq.XepLoaiHocLuc) ? "Chưa xếp loại" : kq.XepLoaiHocLuc;
            // Màu ăn theo GPA cho đồng bộ
            panel_hocLuc.BackColor = panel_gpa.BackColor;

            // 4. Học Bổng
            string hb = kq.XepLoaiHocBong;
            if (string.IsNullOrEmpty(hb) || hb == "Không")
            {
                label_hocBong.Text = "Không";
                panel_hocBong.BackColor = Color.Gray;
            }
            else
            {
                label_hocBong.Text = hb;
                panel_hocBong.BackColor = Color.HotPink; // Màu nổi bật cho học bổng
            }

            // 5. Kỷ Luật
            if (kq.DanhSachKyLuat == null || kq.DanhSachKyLuat.Count == 0)
            {
                // Tốt: Không bị kỷ luật
                richTextBox_kyLuat.BackColor = Color.SeaGreen; // Màu xanh an toàn
            }
            else
            {
                // Xấu: Có kỷ luật -> Duyệt danh sách để hiển thị
                string noiDungViPham = "";

                foreach (var kl in kq.DanhSachKyLuat)
                {
                    // Format ngày cho đẹp (chỉ lấy dd/MM/yyyy)
                    string ngayDep = "";
                    if (DateTime.TryParse(kl.NgayQuyetDinh, out DateTime dateVal))
                    {
                        ngayDep = dateVal.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        ngayDep = kl.NgayQuyetDinh; // Giữ nguyên nếu không parse được
                    }

                    // Format hiển thị: "- Cảnh cáo học vụ (04/12/2025): ngu"
                    noiDungViPham += $"- {kl.HinhThuc} ({ngayDep}): {kl.LyDo}\n";
                }

                richTextBox_kyLuat.Text = noiDungViPham.Trim();
                richTextBox_kyLuat.BackColor = Color.OrangeRed; // Đổi màu nền
                richTextBox_kyLuat.ForeColor = Color.White;
                richTextBox_kyLuat.ReadOnly = true;
            }
        }
    }
}
