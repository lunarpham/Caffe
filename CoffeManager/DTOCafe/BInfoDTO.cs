using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeManager.DTOCafe
{
    public class BInfoDTO
    {
        public BInfoDTO(int id, int billid, int bevid, int count)
        {
            this.ID = id;
            
            this.IDHD = billid;
            
            this.IDTD = bevid;
           
            this.SoLuong = count;
        }

        public BInfoDTO(DataRow row)
        {
            this.ID = (int)row["ID"];
            
            this.IDHD = (int)row["IDHoaDon"];
            
            this.IDTD = (int)row["IDThucDon"];
           
            this.SoLuong = (int)row["count"];
        }

        private int id;

        public int ID
        {
            get { return id; }

            set { id = value; }
        }

        private int billid;

        public int IDHD
        {
            get { return billid; }

            set { billid = value; }
        }

        private int bevid;

        public int IDTD
        {
            get { return bevid; }

            set { bevid = value; }
        }

        private int count;

        public int SoLuong
        {
            get { return count; }

            set { count = value; }
        }
    }
}
