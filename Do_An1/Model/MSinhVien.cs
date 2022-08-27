using System;
namespace Do_An1.Model
{
    public class MSinhVien
    {
        private string ho;
        private string ten;
        private string maSinhVien;
        private DateTime ngaySinh;
        private string queQuan;
        private string lop;
        private string gioiTinh;
        
        public MSinhVien()
        {
            ho = "Unknown";
            ten = "Unknown";
            maSinhVien = "000000";
            ngaySinh = DateTime.Parse("1/1/"+DateTime.Today.Year);
            queQuan = "Viet Nam";
            lop = "Unknown";
            gioiTinh = "Nam";
        }
        public MSinhVien(string ho, string ten, string masv, DateTime ngaysinh, string quequan, string lop, string gt)
        {
            this.ho = ho;
            this.ten = ten;
            maSinhVien = masv;
            ngaySinh = ngaysinh;
            queQuan = quequan;
            this.lop = lop;
            gioiTinh = gt;
        }

        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public string MaSinhVien { get => maSinhVien; set => maSinhVien = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Lop { get => lop; set => lop = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
    }
}

