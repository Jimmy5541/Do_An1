using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An1.Model
{
    internal class MMonHoc
    {
        private string tenMonHoc;
        private string maMonHoc;
        private int soTinChi;
        private string loaiMonHoc;

        public MMonHoc()
        {
            tenMonHoc = "Unknown";
            maMonHoc = "000000";
            soTinChi = 0;
            loaiMonHoc = "Ly thuyet";
        }

        public MMonHoc(string ten,string ma,int sotc,string loai)
        {
            tenMonHoc = ten;
            maMonHoc = ma;
            soTinChi = sotc;
            loaiMonHoc = loai;
        }

        public string TenMonHoc { get => tenMonHoc; set => tenMonHoc = value; }
        public string MaMonHoc { get => maMonHoc; set => maMonHoc = value; }
        public int SoTinChi { get => soTinChi; set => soTinChi = value; }
        public string LoaiMonHoc { get => loaiMonHoc; set => loaiMonHoc = value; }
    }
}
