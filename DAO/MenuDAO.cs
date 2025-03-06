﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF_APP.DTO;

namespace QLCF_APP.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set => instance = value;
        }

        private MenuDAO() { }

        public List<Menu> GetListMenuByTableID(int id)
        {
            List<Menu> listMenu = new List<Menu>();

            string query = "select f.name, bi.count, f.price, f.price*bi.count as totalPrice \r\nfrom dbo.BillInfo as bi, dbo.Bill as b, dbo.Food as f\r\nwhere bi.idBill = b.id and bi.idFood = f.id and b.status = 0 and b.idTable = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
