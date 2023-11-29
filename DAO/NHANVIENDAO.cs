using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DAO
{
    public class NHANVIENDAO
    {
        private static NHANVIENDAO instance;

        public static NHANVIENDAO Instance
        {
            get { if (instance == null) instance = new NHANVIENDAO(); return instance; }
            private set { instance = value; }
        }

        private NHANVIENDAO() { }
    }
}
