using System.Xml;
using Do_An1.Model;

namespace Do_An1.Control
{
    public class ControlKhoa
    {
        public List<MKhoa> khoas = new List<MKhoa>();
        public ControlKhoa()
        {
        }
        private void add(MKhoa khoa)
        { khoas.Add(khoa); }

        private void delete(MKhoa khoa)
        { khoas.Remove(khoa); }
        public List<MKhoa> find(string dk)
        {
            return khoas.Where(t => t.MaKhoa == dk || t.TenKhoa.Contains(dk)).ToList();
        }
        public List<MKhoa> readData()
        {
            XmlDocument read = new XmlDocument();
            read.Load(@"\..\..\Data\DataKhoa.xml");
            XmlNodeList nodeList = read.SelectNodes("/DSKhoa/Khoa");
            foreach (XmlNode node in nodeList)
            {
                string makhoa = node["makhoa"].InnerText;
                string tenkhoa = node["tenkhoa"].InnerText;
                int namtl = Convert.ToInt32(node["namTL"].InnerText);
                MKhoa k = new MKhoa(makhoa, tenkhoa, namtl);
                khoas.Add(k);
            }
            return khoas;
        }
    }
}