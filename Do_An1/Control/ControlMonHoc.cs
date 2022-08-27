using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Do_An1.Model;

namespace Do_An1.Control
{
    internal class ControlMonHoc
    {
        public List<MMonHoc> monHocs = new List<MMonHoc>();

        public void add(MMonHoc monhoc)
        { monHocs.Add(monhoc); }
        public void delete(MMonHoc monhoc)
        { monHocs.Remove(monhoc); }
        public List<MMonHoc> find(string dieukien)
        { return monHocs.Where(x => x.MaMonHoc.Contains(dieukien) || x.TenMonHoc.Contains(dieukien)).ToList(); }
        public List<MMonHoc> readData()
        {
            XmlDocument read = new XmlDocument();
            read.Load(@"\..\..\Data\DataMonHoc.xml");
            XmlNodeList nodeList = read.SelectNodes("dsmonhoc/monhoc");
            foreach (XmlNode node in nodeList)
            {
                string ten = node["ten"].InnerText;
                string ma = node["ma"].InnerText;
                int sotc = Convert.ToInt32(node["sotinchi"].InnerText);
                string loai = node["loai"].InnerText;

                MMonHoc mh = new MMonHoc(ten, ma, sotc, loai);
                monHocs.Add(mh);
            }
            return monHocs;
        }
        public ControlMonHoc()
        { }
    }
}
