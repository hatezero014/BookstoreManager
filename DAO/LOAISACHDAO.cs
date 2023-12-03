using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DAO
{
    public class LOAISACHDAO
    {
        private static LOAISACHDAO instance;

        public static LOAISACHDAO Instance
        {
            get { if (instance == null) instance = new LOAISACHDAO(); return instance; }
            private set { instance = value; }
        }

        private LOAISACHDAO() { }
    }
}
