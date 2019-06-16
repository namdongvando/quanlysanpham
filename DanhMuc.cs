using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham
{
    class DanhMuc:DanhMucTable
    {

        public string CategoryID { set; get; }
        public string CategoryName { set; get; }
        public string Description { set; get; }
        public string Picture { set; get; }

        public DanhMuc(string v1, string v2, string v3, string v4)
        {
            this.CategoryID = v1;
            this.CategoryName = v2;
            this.Description = v3;
            this.Picture = v4;
        }

        public DanhMuc()
        {
        }

        public List<DanhMuc> DSDanhMuc() {
            return this.DanhMucs();
        }


    }
}
