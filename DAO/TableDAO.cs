﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF_APP.DTO;

namespace QLCF_APP.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }

        private TableDAO() { }

        public static int TableWidth = 100;
        public static int TableHeight = 100;

        public void SwitchTable(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("USP_SwitchTable @idTable1 , @idTable2", new object[] { id1, id2 });
        }

        public List<Table> LoadTableList() 
        {
            List<Table> tableList = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");

            foreach (DataRow item in data.Rows) 
            {
                Table table = new Table(item);
                tableList.Add(table);
            }

            return tableList;
        }

    }
}
