using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeManager.DTOCafe;

namespace CoffeManager.DAOCafe
{
    public class BevDAO
    {
        private static BevDAO instance;

        public static BevDAO Instance
        {
            get { if (instance == null)instance = new BevDAO(); return BevDAO.instance; }
            
            private set { BevDAO.instance = value; }
        }

        private BevDAO() { }

        public List<BevDTO> IDDanhSachTD(int id)
        {
            List<BevDTO> list = new List<BevDTO>();

            string query = "select * from ThucDon where IDLoaiDoUong = " + id;

            DataTable data = DataProviderCF.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                BevDTO food = new BevDTO(item);
                
                list.Add(food);
            }

            return list;
        }

        public List<BevDTO> LayDSTD()
        {
            List<BevDTO> list = new List<BevDTO>();

            string query = "select * from ThucDon";

            DataTable data = DataProviderCF.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                BevDTO food = new BevDTO(item);
                
                list.Add(food);
            }

            return list;
        }

        public List<BevDTO> HthiDSTD()
        {
            List<BevDTO> listMenu = new List<BevDTO>();

            string query = "select * from ThucDon";

            DataTable data = DataProviderCF.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                BevDTO menu = new BevDTO(item);

                listMenu.Add(menu);
            }
            return listMenu;
        }

        public List<BevDTO> TraCuuThucDon(string tentd)
        {
            List<BevDTO> list = new List<BevDTO>();

            string query = string.Format("select * from ThucDon where TenDoUong like N'%{0}%'", tentd);

            DataTable data = DataProviderCF.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                BevDTO food = new BevDTO(item);

                list.Add(food);
            }
            return list;
        }
        public bool ThemTD(string tentd, int idtd, float gt)
        {
            string query = string.Format("insert ThucDon ( TenDoUong , IDLoaiDoUong , DonGia )VALUES  ( N'{0}', {1}, {2})", tentd, idtd, gt);
            
            int result = DataProviderCF.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool CapNhatTD(string tentd, int idtd, float gt, int id)
        {
            string query = string.Format("update ThucDon set TenDoUong = N'{0}' , IDLoaiDoUong = {1} , DonGia = {2} WHERE ID = {3}", tentd, idtd, gt, id);
            
            int result = DataProviderCF.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool XoaTD(int id)
        {
            BInfoDAO.Instance.XoaTTHDtheoIDTD(id);
           
            string query = string.Format("delete ThucDon where ID = {0}", id);

            int result = DataProviderCF.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
