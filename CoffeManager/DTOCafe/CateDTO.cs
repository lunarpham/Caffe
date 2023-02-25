using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeManager.DTOCafe
{
    public class CateDTO
    {
        public CateDTO(string ctname, int id)
        {
            this.LoaiDoUong = ctname;

            this.CateID = id;
        }

        public CateDTO(DataRow row)
        {
            this.LoaiDoUong = row["TenDoUong"].ToString();

            this.CateID = (int)row["ID"];
        }

        private string ctname;

        public string LoaiDoUong
        {
            get { return ctname; }

            set { ctname = value; }
        }

        private int id;

        public int CateID
        {
            get { return id; }

            set { id = value; }
        }
    }
}
