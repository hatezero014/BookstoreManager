using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DTO
{
    public class NHAXUATBAN
    {
        public NHAXUATBAN(string maNXB, string tenNXB)
        {
            this.MaNXB = maNXB;
            this.TenNXB = tenNXB;
        }

        public NHAXUATBAN(DataRow row)
        {
            this.MaNXB = row["MANXB"].ToString();
            this.TenNXB = row["TENNXB"].ToString();
        }

        private string maNXB;

        private string tenNXB;
        public string MaNXB { get => maNXB; set => maNXB = value; }
        public string TenNXB { get => tenNXB; set => tenNXB = value; }
    }
}
