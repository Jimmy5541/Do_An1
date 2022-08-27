using System;

namespace Do_An1.Model
{
    public class MLopHoc
    {
        private string maLop;
        private string tenLop;
        private string khoaQuanLy;
        public MLopHoc()
        {
            maLop = "LH0000";
            tenLop = "Unknown";
            khoaQuanLy = "Unknown";
        }
        public MLopHoc(string malop, string tenlop)
        {
            maLop = malop;
            tenLop = tenlop;
        }
        public MLopHoc(string malop, string tenlop, string khoaquanly)
        {
            maLop = malop;
            tenLop = tenlop;
            khoaQuanLy = khoaquanly;
        }

        public string MaLop { get => maLop; set => maLop = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }
        public string KhoaQuanLy { get => khoaQuanLy; set => khoaQuanLy = value; }

    }
}