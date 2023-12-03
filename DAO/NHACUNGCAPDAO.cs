using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DAO
{
    public class NHACUNGCAPDAO
    {
        private static NHACUNGCAPDAO instance;

        public static NHACUNGCAPDAO Instance
        {
            get { if (instance == null) instance = new NHACUNGCAPDAO(); return instance; }
            private set { instance = value; }
        }

        private NHACUNGCAPDAO() { }
    }
}
