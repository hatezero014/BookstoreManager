using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DAO
{
    public class CTBHDAO
    {
        private static CTBHDAO instance;

        public static CTBHDAO Instance
        {
            get { if (instance == null) instance = new CTBHDAO(); return instance; }
            private set { instance = value; }
        }

        private CTBHDAO() { }
    }
}
