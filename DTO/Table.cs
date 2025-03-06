using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF_APP.DTO
{
    public class Table
    {
        public Table(int id, string name, string status) 
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;   
        }

        private int iD;

        private string name;

        private string status;

        public Table(DataRow row)
        {
            this.ID = (int)row["id"];
                    
            this.Name = row["name"].ToString();
    
            this.Status = row["status"].ToString();
        }



        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
        public int ID { get => iD; set => iD = value; }
    }
}
