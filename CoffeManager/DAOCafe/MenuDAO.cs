using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeManager.DTOCafe;

namespace CoffeManager.DAOCafe
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            
            private set { MenuDAO.instance = value; }
        }

        private MenuDAO() { }

        public List<MenuDTO> LayDSTDTheoBan(int id)
        {
            List<MenuDTO> listMenu = new List<MenuDTO>();

            string query = "\r\nselect bv.TenDoUong, ttd.count, bv.DonGia, bv.DonGia*ttd.count as TongGiaTien from dbo.ThongTinHoaDon as ttd, dbo.HoaDon as hd, dbo.ThucDon as bv \r\nwhere ttd.IDHoaDon = hd.ID and ttd.IDThucDon = bv.ID and hd.TrangThai = 0 and hd.IDBanAn = " + id;
            
            DataTable data = DataProviderCF.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                MenuDTO menu = new MenuDTO(item);
                
                listMenu.Add(menu);
            }
            return listMenu;
        }
    }
}
