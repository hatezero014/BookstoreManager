using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DTO
{
    public class NHACUNGCAP
    {
        public NHACUNGCAP(string maNCC, string tenNCC, string diaChi, string soDT)
        {
            this.MaNCC = maNCC;
            this.TenNCC = tenNCC;
            this.DiaChi = diaChi;
            this.SoDT = soDT;
        }

        public NHACUNGCAP(DataRow row)
        {
            this.MaNCC = row["MANCC"].ToString();
            this.TenNCC = row["TENNCC"].ToString();
            this.DiaChi = row["DIACHI"].ToString();
            this.SoDT = row["SODT"].ToString();
        }

        private string maNCC;

        private string tenNCC;

        private string diaChi;

        private string soDT;

        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDT { get => soDT; set => soDT = value; }
    }
}
