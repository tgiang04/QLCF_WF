using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF_APP.DTO;

namespace QLCF_APP.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;    
        public static BillDAO Instance 
        { 
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; } 
            private set => instance = value; 
        }

        private BillDAO() { }

        public int GetUncheckBillIDByTableID (int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select *from dbo.Bill where idTable = " + id +" and status = 0");

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.Id;
            }

            //return (int)DataProvider.Instance.ExecuteScalar("");
            return -1;
        }

        public void CheckOut(int id, int discount, float totalPrice)
        {
            string query = "update dbo.Bill set dateCheckOut = GETDATE(), status = 1, discount = " + discount + ", totalPrice = " + totalPrice + " where id = " + id;
            DataProvider.Instance.ExecuteQuery(query);
        }

        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idTable", new object[] { id });
        }

        public DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("exec  USP_GetListBillByDate @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }

        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select Max(id) from dbo.Bill");
            }
            catch
            {
                return 1;
            }
        }

    }
}
