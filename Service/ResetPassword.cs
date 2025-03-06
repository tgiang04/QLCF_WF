using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCF_APP.DAO;
using QLCF_APP.DTO;

namespace QLCF_APP
{
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        void UpdateAccountInfo() 
        {
            string displayName = txbDisplayName.Text;
            string password = tbOldPassword.Text;
            string newpassword = tbNewPassword.Text;
            string reenterpassword = tbRePassword.Text;
            string userName = txbUserName.Text;

            if (newpassword.Equals(reenterpassword))
            {
                
                if (AccountDAO.Instance.UpdateAccount(userName, displayName, password, newpassword))
                {
                    MessageBox.Show("Cập nhật thành công");
                    if (updateAccount != null)
                    {
                        updateAccount(this, new AccountEventArgs(AccountDAO.Instance.GetAccountByUserName(userName)));
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đúng mật khẩu");
            }
        }

        private event EventHandler<AccountEventArgs> updateAccount;
        public event EventHandler<AccountEventArgs> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public class AccountEventArgs : EventArgs
        {
            private Account account;
            public Account Account { get => account; set => account = value; }
            public AccountEventArgs(Account acc)
            {
                this.Account = acc;
            }
        }
    }
}
