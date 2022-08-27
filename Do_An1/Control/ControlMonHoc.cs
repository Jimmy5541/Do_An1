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
            return monHocs;
        }
    }
}
