using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CoffeManager.DTOCafe
{
    public class BillDTO
    {
        public BillDTO(int tabid, DateTime? timeCheckin, DateTime? timeCheckout, int status, int km = 0)
        {
            this.IDBan = tabid;
            
            this.tgVao = timeCheckin;
            
            this.tgRa = timeCheckout;
            
            this.TrangThai = status;

            this.KhuyenMai = km;
        }
        
        public BillDTO(DataRow row)
        {
            
            this.IDBan = (int)row["ID"];
            
            this.tgVao = new DateTime();
             
            this.tgRa = new DateTime();

            this.TrangThai = (int)row["TrangThai"];

            if (row["GiamGia"].ToString() != "")
                this.KhuyenMai = (int)row["GiamGia"];
        }

        private int tabid;

        public int IDBan
        {
            get { return tabid; }

            set { tabid = value; }
        }

        private int status;

        public int TrangThai
        {
            get { return status; }

            set { status = value; }
        }

        private DateTime? timeCheckin;

        public DateTime? tgVao
        {
            get { return timeCheckin; }

            set { timeCheckin = value; }
        }

        private DateTime? timeCheckout;

        public DateTime? tgRa
        {
            get { return timeCheckout; }

            set { timeCheckout = value; }
        }

        private int km;

        public int KhuyenMai
        {
            get { return km; }

            set { km = value; }
        }
    }
}
