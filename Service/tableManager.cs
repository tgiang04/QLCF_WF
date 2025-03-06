using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocuSign.eSign.Model;
using QLCF_APP.DAO;
using QLCF_APP.DTO;
using static QLCF_APP.AccountProfile;

namespace QLCF_APP
{
    public partial class tableManager : Form
    {
        Account loginAccount;

        public Account LoginAccount 
        { 
            get => loginAccount; 
            set { loginAccount = value; ChangeAccount(LoginAccount.Type); }
        }

        public tableManager(Account acc)
        {
            InitializeComponent();
            loadTable();
            LoadCategory();
            LoadComboboxTable(cbSwitchTable);
            this.LoginAccount = acc;
        }

        #region Method

        void ChangeAccount(int type)
        {
            managerToolStripMenuItem.Enabled = type == 1;
            thôngTinTàiKhoảnToolStripMenuItem.Text += " (" + LoginAccount.DisplayName + ")";
        }
        void loadTable()
        {
            flpTable.Controls.Clear();

            List<Table> tableList =  TableDAO.Instance.LoadTableList();
            
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;

                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.Status) 
                {
                    case "Trống": btn.BackColor = Color.Aqua;
                        break;
                    default: btn.BackColor = Color.LightYellow;
                        break;
                }
                flpTable.Controls.Add(btn);
            }
        }

        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<QLCF_APP.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTableID(id);
            float totalPrice = 0;
            foreach (QLCF_APP.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;

                lsvBill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");

            txbTotalPrice.Text = totalPrice.ToString("c", culture);
    
        }

        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }

        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetListFoodByCategoryID(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Name";
        }

        void LoadComboboxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }

        #endregion

        #region Events

        private void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng xuất thành công");
            this.Close();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AccountProfile A = new AccountProfile(loginAccount);
            A.UpdateAccount += A_UpdateAccount;
            A.ShowDialog();

        }

        void A_UpdateAccount(object sender, AccountEventArgs e)
        {
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Account.DisplayName + ")";
        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manager M = new Manager(); 
            M.loginAccount = LoginAccount;
            M.InsertFood += M_InsertFood;
            M.UpdateFood += M_UpdateFood;
            M.DeleteFood += M_DeleteFood;
            M.ShowDialog();
        }

        private void M_DeleteFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
            loadTable();
        }

        private void M_UpdateFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
        }

        private void M_InsertFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;

            id = selected.ID;

            LoadFoodListByCategoryID(id);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int FoodID = (cbFood.SelectedItem as Food).Id;
            int count = (int)nmFoodCount.Value;

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), FoodID, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, FoodID, count);
            }

            ShowBill(table.ID);
            loadTable();
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int discount = (int)nmDiscount.Value;
            double totalPrice = Convert.ToDouble(txbTotalPrice.Text.Split(',')[0].Replace(".", ""));
            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;

            if (idBill != -1)
            {
             if(MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho {0}\n ", table.Name,  finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {   
                    BillDAO.Instance.CheckOut(idBill, discount, (float)finalTotalPrice);
                    ShowBill(table.ID);
                    loadTable();
                }
            }
        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            int id1 = (lsvBill.Tag as Table).ID;
            int id2 = (cbSwitchTable.SelectedItem as Table).ID;

            if (MessageBox.Show(string.Format("Bạn có chắc chắn muốn chuyển {0} qua {1}", (lsvBill.Tag as Table).Name, (cbSwitchTable.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)

                TableDAO.Instance.SwitchTable(id1, id2);

            loadTable();
        }

        #endregion


    }
}
