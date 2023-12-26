using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DTO
{
    public class SACHGIAMGIA
    {
        public SACHGIAMGIA(string maSach, string tenSach, decimal giaTruocGiam, decimal giaGiam, DateTime giamDen)
        {
            this.TenSach = tenSach;
            this.giaTruocGiam = giaTruocGiam;
            this.MaSach = maSach;
            this.GiaGiam = giaGiam;
            this.GiamDen = giamDen;
        }

        public SACHGIAMGIA(DataRow row)
        {
            this.TenSach = row["TENSACH"].ToString();
            this.MaSach = row["MASACH"].ToString();
            this.GiaGiam = (decimal)row["GIAGIAM"];
            this.GiamDen = (DateTime)row["GIAMDEN"];
            this.GiaTruocGiam = (decimal)row["GIATRUOCGIAM"];
        }

        private decimal giaTruocGiam;

        private string maSach;

        private decimal giaGiam;

        private DateTime giamDen;

        private string tenSach;

        public string MaSach { get => maSach; set => maSach = value; }
        public decimal GiaGiam { get => giaGiam; set => giaGiam = value; }
        public DateTime GiamDen { get => giamDen; set => giamDen = value; }
        public decimal GiaTruocGiam { get => giaTruocGiam; set => giaTruocGiam = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
    }
}
