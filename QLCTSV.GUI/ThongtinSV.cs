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
    public partial class ThongtinSV: Form
    {
        private static readonly HttpClient client = new HttpClient();
        private string baseUrl = "https://backendfinalproject-production-9fa0.up.railway.app/";
        public ThongtinSV()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTheme();
            LoadProfileData();
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
        private async void LoadProfileData()
        {
            string maSV = SVSignIn.TaiKhoanDangNhap;

            try
            {
                string url = $"{baseUrl}api/student/basic-info/{maSV}";

                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonContent = await response.Content.ReadAsStringAsync();

                    // --- SỬA LỖI Ở ĐÂY ---
                    // Đổi 'ThongtinSV' thành 'ThongTinCaNhanDTO'
                    ThongtinSVDTO sv = JsonConvert.DeserializeObject<ThongtinSVDTO>(jsonContent);
                    // ---------------------

                    if (sv != null)
                    {
                        textBox_MaSV.Text = sv.MaSV;
                        textBox_Ten.Text = sv.HoTen;
                        dateTimePicker_date.Value = sv.NgaySinh; 

                        comboBox_gt.Text = sv.GioiTinh;
                        textBox_Sdt.Text = sv.SoDienThoai;
                        textBox_diaChi.Text = sv.DiaChi;
                    }
                }
                else
                {
                    MessageBox.Show("Không thể tải thông tin sinh viên.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            comboBox_gt.Enabled = false;
            dateTimePicker_date.Enabled = false;
        }
    }
}
