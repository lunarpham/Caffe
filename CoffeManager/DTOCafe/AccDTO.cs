using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace CoffeManager.DTOCafe
{
    public class AccDTO
    {
        public AccDTO (string tentk, string cv, int ltk, string pw = null)
        {
            this.TenTK = tentk;
           
            this.CV = cv;
          
            this.Pass = pw;
           
            this.LoaiTK = ltk;
        }

        public AccDTO (DataRow row)
        {
            this.TenTK = row["TenTK"].ToString();

            this.CV = row["ChucVu"].ToString();

            this.Pass = row["MatKhau"].ToString();

            this.LoaiTK = (int)row["LoaiID"];
        }

        private string tentk;

        public string TenTK
        {
            get { return tentk; }

            set { tentk = value; }
        }

        private string cv;

        public string CV
        {
            get { return cv; }

            set { cv = value; }
        }

        private string pw;

        public string Pass
        {
            get { return pw; }

            set { pw = value; }
        }

        private int ltk;

        public int LoaiTK
        {
            get { return ltk; }
            
            set { ltk = value; }
        }
    }
}
