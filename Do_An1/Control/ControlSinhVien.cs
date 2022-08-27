using System;
using System.Xml;
using Do_An1.Model;
namespace Do_An1.Control
{
    public class ControlSinhVien
    {
        public List<MSinhVien> sinhViens = new List<MSinhVien>();
        private void add(MSinhVien sinhVien)
        { sinhViens.Add(sinhVien); }
        private void delete(MSinhVien sinhVien)
        { sinhViens.Remove(sinhVien); }
        public List<MSinhVien> find(string dk)
        {
            return sinhViens.Where(t => t.MaSinhVien == dk || t.Ho.Contains(dk) || t.Ten.Contains(dk)).ToList();
        }
        public List<MSinhVien> readData()
        {
            XmlDocument read = new XmlDocument();
            read.Load(@"\..\..\Data\DataSinhVien.xml");
            XmlNodeList nodeList = read.SelectNodes("/DSSinhVien/SinhVien");
            foreach (XmlNode node in nodeList)
            {
                string makhoa = node["ho"].InnerText;
                string tenkhoa = node["ten"].InnerText;
                string masinhvien = node["masinhvien"].InnerText;
                DateTime ngaysinh = DateTime.Parse(node["ngaysinh"].InnerText);
                string lop = node["lop"].InnerText;
                string quequan = node["quequan"].InnerText;
                string gioitinh = node["gioitinh"].InnerText;
                MSinhVien k = new MSinhVien(makhoa, tenkhoa, masinhvien, ngaysinh, quequan, lop, gioitinh);
                sinhViens.Add(k);
            }
            return sinhViens;
        }
        public ControlSinhVien()
        {
        }
    }
}

