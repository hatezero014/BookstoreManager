using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DAO
{
    public class KHACHHANGDAO
    {
        private static KHACHHANGDAO instance;

        public static KHACHHANGDAO Instance
        {
            get { if (instance == null) instance = new KHACHHANGDAO(); return instance; }
            private set { instance = value; }
        }

        private KHACHHANGDAO() { }
    }
}
