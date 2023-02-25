using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeManager.DTOCafe;

namespace CoffeManager.DAOCafe
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
        
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }

        /// <summary>
        /// Success: bill ID
        /// Failure: -1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int IDHoaDonTheoBanAn(int id)
        {
            DataTable data = DataProviderCF.Instance.ExecuteQuery("select * from dbo.HoaDon where IDBanAn = " + id +" and TrangThai = 0");

            if (data.Rows.Count > 0)
            {
                BillDTO bill = new BillDTO(data.Rows[0]);

                return bill.IDBan;
            }
            return -1;
        }

        public void CkOut(int id, int km, float tt)
        {
            string query = "update HoaDon set ThoiGianRa = getdate(), TrangThai = 1, " + " GiamGia = " + km + ", TongTien = " + tt + " where id = " + id;
            DataProviderCF.Instance.ExecuteNonQuery(query);
        }

        public void NhapHoaDon(int id)
        {
            DataProviderCF.Instance.ExecuteNonQuery("exec USP_NhapHD @idbanan", new object[]{id});
        }

        public DataTable DSHDTheoNgay (DateTime tgv, DateTime tgr)
        {
            return DataProviderCF.Instance.ExecuteQuery("exec USP_LayDSHDTheoNgay @tgv , @tgr", new object[] { tgv , tgr });
        }

        public DataTable DSHDTheoNgayVaTrang(DateTime tgv, DateTime tgr, int st)
        {
            return DataProviderCF.Instance.ExecuteQuery("exec USP_DSHDTheoNgayVaTrang @tgv , @tgr , @st", new object[] { tgv, tgr, tgr });
        }

        public int SoHD(DateTime tgv, DateTime tgr)
        {
            return (int)DataProviderCF.Instance.ExecuteScalar("exec USP_SoHD @tgv , @tgr", new object[] { tgv, tgr });
        }


        public int MaxIDHD()
        { 
            try { return (int)DataProviderCF.Instance.ExecuteScalar("select max(id) from HoaDon"); }

            catch { return -1; }
        }

    }
}
