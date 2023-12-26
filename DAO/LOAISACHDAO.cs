using BookstoreManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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

        public List<LOAISACH> GetListLoaiSach()
        {
            string query = $"SELECT * FROM LOAISACH";

            List<LOAISACH> result = new List<LOAISACH>();

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                result.Add(new LOAISACH(row));
            }

            return result;
        }

        public LOAISACH GetLoaiSachByID(string maLS)
        {
            string query = $"SELECT * FROM LOAISACH WHERE MALS = '{maLS}'";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            LOAISACH result = null;

            if (data.Rows.Count > 0)
            {
                result = new LOAISACH(data.Rows[0]);
            }

            return result;
        }

        public bool DeleteLSByID(string maLS)
        {
            string query = $"DELETE LOAISACH WHERE MALS = '{maLS}'";

            return DataProvider.Instance.ExcuteNonQuery(query) > 0;
        }

        public bool UpdateLSByID(string maLS, string tenLS)
        {
            string query = $"UPDATE LOAISACH SET TENLS = N'{tenLS}' WHERE MALS = '{maLS}'";

            return DataProvider.Instance.ExcuteNonQuery(query) > 0;
        }

        public bool InsertLS(string maLS, string tenLS)
        {
            string query = $"INSERT INTO LOAISACH VALUES ('{maLS}', N'{tenLS}')";

            return DataProvider.Instance.ExcuteNonQuery(query) > 0;
        }

        public string GetIDOfLS()
        {
            string query = "SELECT TOP 1 * FROM LOAISACH ORDER BY MALS DESC";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            string result = "LS001";

            if (data != null)
            {
                LOAISACH loaiSach = new LOAISACH(data.Rows[0]);

                result = loaiSach.MaLS;
            }

            return result;
        }
    }
}
