using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DAO
{
    public class SACHGIAMGIADAO
    {
        private static SACHGIAMGIADAO instance;

        public static SACHGIAMGIADAO Instance
        {
            get { if (instance == null) instance = new SACHGIAMGIADAO(); return instance; }
            private set { instance = value; }
        }

        private SACHGIAMGIADAO() { }
    }
}
