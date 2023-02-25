using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeManager.DTOCafe;

namespace CoffeManager.DAOCafe
{
    public class AccDAO
    {
        private static AccDAO instance;

        public static AccDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccDAO();

                return instance;
            }

            private set { instance = value; }
        }  
        private AccDAO() { }

        public bool Login(string tentk, string mk)
        {
            string query = "USP_DangNhap @tentk , @matkhau";

            DataTable result = DataProviderCF.Instance.ExecuteQuery(query, new object[] { tentk, mk });

            return result.Rows.Count > 0;
        }



        public bool CapNhatTK(string tentk, string mk, string mkmoi)
        {
            int result = DataProviderCF.Instance.ExecuteNonQuery("exec USP_CapNhatTK @tentk , @mk , @mkmoi", new object[] {tentk, mk, mkmoi,});

            return result > 0;
        }

        public DataTable DSTK()
        {
            return DataProviderCF.Instance.ExecuteQuery("select TenTK, ChucVu, LoaiID from TaiKhoan");
        }

        public AccDTO DangNhapVoiUSN(string tentk)
        {
            DataTable data = DataProviderCF.Instance.ExecuteQuery("select * from TaiKhoan where TenTK = '" + tentk + "'");

            foreach (DataRow item in data.Rows)
            {
                return new AccDTO(item);
            }

            return null;
        }

        public bool ThemTK(string tentk, string cv, int type)
        {
            string query = string.Format("insert TaiKhoan ( TenTK , ChucVu , LoaiID)VALUES ( N'{0}', N'{1}', {2} )", tentk, cv, type);

            int result = DataProviderCF.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool CapNhatTK(string tentk, int type)
        {
            string query = string.Format("update TaiKhoan set LoaiID = {1} WHERE TenTK = N'{0}' ", tentk, type);

            int result = DataProviderCF.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool XoaTK(string tentk)
        {
            string query = string.Format("delete TaiKhoan where TenTK = N'{0}'", tentk);

            int result = DataProviderCF.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DatlaiMK(string tentk)
        {
            string query = string.Format("update TaiKhoan set MatKhau = N'6969' where TenTK = N'{0}'", tentk);

            int result = DataProviderCF.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}

