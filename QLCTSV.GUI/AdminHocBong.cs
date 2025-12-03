using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;
using QLCTSV.DTO.AdminDTO;

namespace QLCTSV.GUI
{
    public partial class AdminHocBong : Form
    {
        // 1. Khởi tạo HttpClient
        private static readonly HttpClient client = new HttpClient();
        private string baseUrl = "https://backendfinalproject-production-9fa0.up.railway.app/";

        public AdminHocBong()
        {
            InitializeComponent();
        }

        private void AdminHocBong_Load(object sender, EventArgs e)
        {
            LoadTheme();
            SetupComboBox();
        }

        private void SetupComboBox()
        {
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

        private async void btnXem_Click(object sender, EventArgs e)
        {
            string namHoc = comboBox_namhoc.Text.Trim();
            string hocKi = comboBox_hocky.Text.Trim();

            if (string.IsNullOrEmpty(namHoc) || string.IsNullOrEmpty(hocKi))
            {
                MessageBox.Show("Vui lòng chọn Năm học và Học kỳ!");
                return;
            }

            try
            {
                string endpoint = $"api/ctsv/danh-sach-hoc-bong?hocKy={hocKi}&namHoc={namHoc}";
                string url = baseUrl + endpoint;
                // 2. Gọi API
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonContent = await response.Content.ReadAsStringAsync();

                    List<HocbongDTO> listHB = JsonConvert.DeserializeObject<List<HocbongDTO>>(jsonContent);

                    dataGridView1.DataSource = listHB;

                    FormatGrid();

                    if (listHB.Count == 0) MessageBox.Show("Kỳ này chưa có ai đạt học bổng.");
                }
                else
                {
                    MessageBox.Show($"Lỗi tải dữ liệu ({response.StatusCode}): {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void FormatGrid()
        {
            if (dataGridView1.Columns["MaSV"] != null) dataGridView1.Columns["MaSV"].HeaderText = "Mã SV";
            if (dataGridView1.Columns["HoTen"] != null) dataGridView1.Columns["HoTen"].HeaderText = "Họ Tên";
            if (dataGridView1.Columns["GPA"] != null) dataGridView1.Columns["GPA"].HeaderText = "Điểm TB Hệ 4";
            if (dataGridView1.Columns["DiemRenLuyen"] != null) dataGridView1.Columns["DiemRenLuyen"].HeaderText = "Điểm rèn luyện";
            if (dataGridView1.Columns["XepLoaiHocBong"] != null) dataGridView1.Columns["XepLoaiHocBong"].HeaderText = "Loại HB";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

        private void comboBox_namhoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_hocky_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}