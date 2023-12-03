using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DTO
{
    public class LOAISACH
    {
        public LOAISACH(string maLS, string tenLS)
        {
            this.MaLS = maLS;
            this.TenLS = tenLS;
        }

        public LOAISACH(DataRow row)
        {
            this.MaLS = row["MALS"].ToString();
            this.TenLS = row["TENLS"].ToString();
        }

        private string maLS;

        private string tenLS;

        public string MaLS { get => maLS; set => maLS = value; }
        public string TenLS { get => tenLS; set => tenLS = value; }
    }
}
