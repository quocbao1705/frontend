using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCTSV.DTO
{
    public class ResetPasswordRequestDTO
    {
        public string MaSV { get; set; }
        public string SoDienThoaiXacThuc { get; set; }
        public string MatKhauMoi { get; set; }
    }

    public class ResponseMessageDTO
    {
        // Dùng để hứng thông báo lỗi hoặc thành công từ Backend
        public string Message { get; set; }
    }
}
