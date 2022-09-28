using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenhNhanObject
{
    [Serializable]
    public class BenhNhan
    {
        public string ma { get; set; }
        public string cmnd { get; set; }
        public string hoten { get; set; }
        public string diachi { get; set; }

        public BenhNhan() { }
        public BenhNhan (string ma, string cmnd, string hoten, string diachi)
        {
            this.ma = ma;
            this.cmnd = cmnd;
            this.hoten = hoten;
            this.diachi = diachi;

        }
    }
}
