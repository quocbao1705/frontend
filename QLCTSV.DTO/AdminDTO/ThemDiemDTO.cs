using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCTSV.DTO.AdminDTO
{
    public class ThemDiemDTO
    {
        public string MaSV { get; set; }
        public string HocKy { get; set; }
        public string NamHoc { get; set; }
        public double? GPA { get; set; } // Dấu ? để cho phép null nếu chưa có điểm
        public int? DiemRenLuyen { get; set; }
        public string XepLoaiHocLuc { get; set; }
    }
}
