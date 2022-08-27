using System;

namespace Do_An1.Model
{
    public class MKhoa
    {
        private string maKhoa;
        private string tenKhoa;
        private int namTL;
        public MKhoa()
        {
            maKhoa = "KH0000";
            tenKhoa = "Khoa";
            namTL = DateTime.Today.Year;
        }
        public MKhoa(string makhoa, string tenkhoa, int nam)
        {
            maKhoa = makhoa;
            tenKhoa = tenkhoa;
            namTL = nam;
        }

        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string TenKhoa { get => tenKhoa; set => tenKhoa = value; }
        public int NamTL { get => namTL; set => namTL = value; }

    }
}
