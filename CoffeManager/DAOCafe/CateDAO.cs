using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeManager.DTOCafe;

namespace CoffeManager.DAOCafe
{
    public class CateDAO
    {
        private static CateDAO instance;

        public static CateDAO Instance
        {
            get { if (instance == null) instance = new CateDAO(); return CateDAO.instance; }

            private set { CateDAO.instance = value; }
        }

        private CateDAO() { }

        public List<CateDTO> LayDanhSachTD()
        {
            List<CateDTO> list = new List<CateDTO>();

            string query = "select * from LoaiDoUong";

            DataTable data = DataProviderCF.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                CateDTO ctgr = new CateDTO(item);

                list.Add(ctgr);
            }

            return list;
        }

        public CateDTO DSTDVoiID(int id)
        {
            CateDTO ctgr = null;

            string query = "select * from LoaiDoUong where ID = " + id;

            DataTable data = DataProviderCF.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ctgr = new CateDTO(item);

                return ctgr;
            }

            return ctgr;
        }
    }
}
