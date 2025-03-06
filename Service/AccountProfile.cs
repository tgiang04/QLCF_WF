using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCF_APP.DTO;

namespace QLCF_APP
{
    public partial class AccountProfile : Form
    {

        Account loginAccount;

        public Account LoginAccount
        {
            get => loginAccount;
            set { loginAccount = value; ChangeAccount(); }
        }

        public AccountProfile(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
        }

        private event EventHandler<AccountEventArgs> updateAccount;
        public event EventHandler<AccountEventArgs> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }

        void ChangeAccount()
        {
            txbUserName.Text = LoginAccount.UserName;
            tbDisplayName.Text = LoginAccount.DisplayName;
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            ResetPassword R = new ResetPassword();
            R.ShowDialog();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
