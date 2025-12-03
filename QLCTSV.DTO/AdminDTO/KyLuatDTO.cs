using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCTSV.DTO.AdminDTO
{
    public class KyLuatDTO
    {
        public int Id { get; set; }
        public string MaSV { get; set; }
        public string HocKy { get; set; }
        public string HoTen { get; set; }
        public string NamHoc { get; set; }

        // --- 2 CỘT RIÊNG BIỆT ---
        public string HinhThuc { get; set; } // VD: Cảnh báo
        public string LyDo { get; set; }     // VD: Gian lận thi cử
        // -------------------------

        public DateTime NgayQuyetDinh { get; set; }
    }
}
