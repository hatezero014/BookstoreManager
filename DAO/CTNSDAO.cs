using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DAO
{
    public class CTNSDAO
    {
        private static CTNSDAO instance;

        public static CTNSDAO Instance
        {
            get { if (instance == null) instance = new CTNSDAO(); return instance; }
            private set { instance = value; }
        }

        private CTNSDAO() { }
    }
}
