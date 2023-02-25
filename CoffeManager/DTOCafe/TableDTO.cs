using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeManager.DTOCafe
{
    public class TableDTO
    {
        public TableDTO(string tabnum, string tabstat, int ID)
        {
            this.TabNum = tabnum;
            
            this.TabStat = tabstat;
            
            this.ID = id;
        }
        public TableDTO(DataRow row)
        {
            this.ID = (int)row["ID"];
            
            this.TabNum = row["SoBan"].ToString();
            
            this.TabStat = row["TrangThai"].ToString();
        }
        private string tabnum;

        public string TabNum
        {
            get { return tabnum; } 
            
            set { tabnum = value; } 
        }

        private string tabstat;

        public string TabStat
        {
            get { return tabstat; }
            
            set { tabstat = value; }
        }

        private int id;

        public int ID
        {
            get { return id; }
            
            set { id = value; }
        }
    }
}
