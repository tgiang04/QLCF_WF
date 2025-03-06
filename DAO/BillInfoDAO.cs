using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF_APP.DTO;

namespace QLCF_APP.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance 
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance;} 
            private set => Instance = value; 
        }

        private BillInfoDAO() { }

        public List<BillInfo> GetListBillInfor(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select *from dbo.BillInfo where idBill = " + id);

            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }
            
            return listBillInfo;
        }

        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBillInfo @idBill , @idFood , @count", new object[] { idBill, idFood, count });
        }

        public void DeleteBillInfo(int idFood) 
        {
            DataProvider.Instance.ExecuteNonQuery("delete dbo.BillInfo where idFood = " + idFood);
        }
    }
}
