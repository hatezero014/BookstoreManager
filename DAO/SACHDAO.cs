using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManager.DAO
{
    public class SACHDAO
    {
        private static SACHDAO instance;

        public static SACHDAO Instance
        {
            get { if (instance == null) instance = new SACHDAO(); return instance; }
            private set { instance = value; }
        }

        private SACHDAO() { }
    }
}
