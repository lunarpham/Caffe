using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeManager.DTOCafe
{
    public class BevDTO
    {
        public BevDTO(string bname, int id, int idct, float price)
        {
            this.TenDoUong = bname;
                
            this.IDDoUong = id;
                
            this.IDThucDon = idct;
                
            this.DonGia = price;
        }

        public BevDTO(DataRow row)
        {
            this.IDDoUong = (int)row["ID"];
               
            this.TenDoUong = row["TenDoUong"].ToString();
               
            this.IDThucDon = (int)row["IDLoaiDoUong"];
                
            this.DonGia = (float)Convert.ToDouble(row["DonGia"].ToString());
        }

        private string bname;

        public string TenDoUong
        {
            get { return bname; }
               
            set { bname = value; }
        }

        private int id;

        public int IDDoUong
        {
            get { return id; }
               
            set { id = value; }
        }

        private int idct;

        public int IDThucDon
        {
            get { return idct; }
              
            set { idct = value; }
        }

        private float price;

        public float DonGia
        {
            get { return price; }
              
            set { price = value; }
        }
    }
}
