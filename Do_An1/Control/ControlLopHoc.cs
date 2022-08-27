using System.Xml;
using Do_An1.Model;

namespace Do_An1.Control
{
    public class ControlLopHoc
    {
        public List<MLopHoc> lopHocs = new List<MLopHoc>();
        public void add(MLopHoc lop)
        { lopHocs.Add(lop); }
        public void delete(MLopHoc lop)
        { lopHocs.Remove(lop); }
        public List<MLopHoc> find(string dk)
        {
            return lopHocs.Where(t => t.MaLop == dk || t.MaLop.Contains(dk)).ToList();
        }
        public List<MLopHoc> readData()
        {
            XmlDocument read = new XmlDocument();
            read.Load(@"\..\..\Data\DataLopHoc.xml");
            XmlNodeList nodeList = read.SelectNodes("/DSLopHoc/LopHoc");
            foreach (XmlNode node in nodeList)
            {
                string makhoa = node["malop"].InnerText;
                string tenkhoa = node["tenlop"].InnerText;
                string khoaql = node["khoa"].InnerText;
                MLopHoc k = new MLopHoc(makhoa, tenkhoa, khoaql);
                lopHocs.Add(k);
            }
            return lopHocs;
        }
        ControlLopHoc()
        { }
    }
}