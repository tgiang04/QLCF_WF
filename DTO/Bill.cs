using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF_APP.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int status, int discount = 0)
        {
            this.Id = id;
            this.DateCheckIN = dateCheckIn;
            this.DateCheckOUT = dateCheckOut;
            this.Status = status;
            this.Discount = discount;

        }

        public Bill(DataRow row)
        {
            this.Id = (int)row["id"];
            this.DateCheckIN = (DateTime)row["dateCheckIn"];
            var dateCheckOutTemp = row["dateCheckOut"];
            if (dateCheckOutTemp.ToString() != "")
            {
                this.DateCheckOUT = (DateTime)row["dateCheckOut"];
            }
            this.Status = (int)row["status"];
            if (row["discount"].ToString() != "")
                this.discount = (int)row["discount"];
        }
        
        private int status;

        private DateTime? dateCheckIN;

        private DateTime? dateCheckOUT;

        private int id;

        private int discount;   

        public int Id { get => id; set => id = value; }
        public DateTime? DateCheckIN { get => dateCheckIN; set => dateCheckIN = value; }
        public DateTime? DateCheckOUT { get => dateCheckOUT; set => dateCheckOUT = value; }
        public int Status { get => status; set => status = value; }
        public int Discount { get => discount; set => discount = value; }
    }
}
