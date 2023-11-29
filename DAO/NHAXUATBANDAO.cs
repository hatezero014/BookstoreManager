using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DAO
{
    public class NHAXUATBANDAO
    {
        private static NHAXUATBANDAO instance;

        public static NHAXUATBANDAO Instance
        {
            get { if (instance == null) instance = new NHAXUATBANDAO(); return instance; }
            private set { instance = value; }
        }

        private NHAXUATBANDAO() { }
    }
}
