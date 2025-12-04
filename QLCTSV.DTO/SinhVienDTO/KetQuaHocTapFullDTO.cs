using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCTSV.DTO.SinhVienDTO
{
    public class ChiTietKyLuatDTO
    {
        public string HinhThuc { get; set; }        // Khớp JSON "hinhThuc"
        public string NgayQuyetDinh { get; set; }   // Khớp JSON "ngayQuyetDinh"
        public string LyDo { get; set; }            // Khớp JSON "lyDo"
    }
    public class KetQuaHocTapFullDTO
    {
        public double? GPA { get; set; }
        public int? DiemRenLuyen { get; set; }

        // Backend bạn đã có sẵn 2 trường này, chỉ cần map đúng tên
        public string XepLoaiHocLuc { get; set; }
        public string XepLoaiHocBong { get; set; }
        public List<ChiTietKyLuatDTO> DanhSachKyLuat { get; set; }

        public string message { get; set; } // Để hứng lỗi nếu có
    }
}
