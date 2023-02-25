using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeManager.DTOCafe;

namespace CoffeManager.DAOCafe
{
    public class BInfoDAO
    {
        private static BInfoDAO instance;

        public static BInfoDAO Instance
        {
            get { if (instance == null) instance = new BInfoDAO(); return BInfoDAO.instance; }

            private set { BInfoDAO.instance = value; }
        }

        private BInfoDAO() { }

        public void XoaTTHDtheoIDTD(int id)
        {
            DataProviderCF.Instance.ExecuteQuery("delete ThongTinHoaDon where IDThucDon = " + id);
        }

        public List<BInfoDTO> LayDSHD(int id)
        {
            List<BInfoDTO> listBillInfo = new List<BInfoDTO>();

            DataTable data = DataProviderCF.Instance.ExecuteQuery("select * from dbo.ThongTinHoaDon where IDHoaDon = " + id);

            foreach (DataRow item in data.Rows)
            {
                BInfoDTO info = new BInfoDTO(item);

                listBillInfo.Add(info);
            }

            return listBillInfo;
        }

        public void NhapTTHD(int idhd, int idtd, int sl)
        {
            DataProviderCF.Instance.ExecuteNonQuery("USP_NhapTTHD @idhoadon , @idthucdon , @soluong", new object[]{idhd, idtd, sl});
        }
    }

}
