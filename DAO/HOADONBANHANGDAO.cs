using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DAO
{
    public class HOADONBANHANGDAO
    {
        private static HOADONBANHANGDAO instance;

        public static HOADONBANHANGDAO Instance
        {
            get { if (instance == null) instance = new HOADONBANHANGDAO(); return instance; }
            private set { instance = value; }
        }

        private HOADONBANHANGDAO() { }
    }
}
