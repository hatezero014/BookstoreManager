using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DAO
{
    public class HOADONNHAPSACHDAO
    {
        private static HOADONNHAPSACHDAO instance;

        public static HOADONNHAPSACHDAO Instance
        {
            get { if (instance == null) instance = new HOADONNHAPSACHDAO(); return instance; }
            private set { instance = value; }
        }

        private HOADONNHAPSACHDAO() { }
    }
}
