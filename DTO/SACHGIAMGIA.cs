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
        SACHGIAMGIA(string maSach, decimal giaGiam, DateTime giamDen)
        {
            this.MaSach = maSach;
            this.GiaGiam = giaGiam;
            this.GiamDen = giamDen;
        }

        SACHGIAMGIA(DataRow row)
        {
            this.MaSach = row["MASACH"].ToString();
            this.GiaGiam = (decimal)row["GIAGIAM"];
            this.GiamDen = (DateTime)row["GIAMDEN"];
        }

        private string maSach;

        private decimal giaGiam;

        private DateTime giamDen;

        public string MaSach { get => maSach; set => maSach = value; }
        public decimal GiaGiam { get => giaGiam; set => giaGiam = value; }
        public DateTime GiamDen { get => giamDen; set => giamDen = value; }
    }
}
