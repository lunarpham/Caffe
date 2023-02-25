using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeManager.DTOCafe;


namespace CoffeManager.DAOCafe
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }

        public static int ChieuRongBan = 280;

        public static int ChieuCaoBan = 70;

        private TableDAO() { }

        public void ChuyenBan (int id1, int id2)
        {
            DataProviderCF.Instance.ExecuteQuery("USP_ChuyenBan @idban1 , @idban2", new object[] { id1, id2 });
        }

        public void GopBan(int id1, int id2)
        {
            try
            {
                DataProviderCF.Instance.ExecuteNonQuery("USP_GopBan @idban1 , @idban2", new object[] { id1, id2 });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable LayDSBA()
        {
            try
            {
                return DataProviderCF.Instance.ExecuteQuery("USP_LayDSBA");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ThemBan(string tenban)
        {
            string query = "USP_ThemBan @tenban";
            int result = DataProviderCF.Instance.ExecuteNonQuery(query, new object[] { tenban });
            return result > 0;
        }

        public bool SuaBan(int id, string tenban)
        {
            string query = "USP_SuaBan @idbanan , @tenban";
            int result = DataProviderCF.Instance.ExecuteNonQuery(query, new object[] { id, tenban });
            return result > 0;
        }

        public bool XoaBan(int id)
        {
            string query = string.Format("USP_XoaBan @idbanan");
            int result = DataProviderCF.Instance.ExecuteNonQuery(query, new object[] { id });
            return result > 0;
        }

        public List<TableDTO> TaoBanAn()
        {
            List<TableDTO> tableList = new List<TableDTO>();

            DataTable data = DataProviderCF.Instance.ExecuteQuery("USP_DanhSachBanAn");
            Console.WriteLine(data);
            foreach (DataRow item in data.Rows)
            {
                Console.WriteLine(item);
                TableDTO table = new TableDTO(item);

                tableList.Add(table);
            }    
            
            return tableList;
        }

        public DataTable DSBA()
        {
            return DataProviderCF.Instance.ExecuteQuery("select ID, SoBan from BanAn");
        }
    }
}
