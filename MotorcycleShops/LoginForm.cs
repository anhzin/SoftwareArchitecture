using BussinessLogic.DataAccess;
using BussinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorcycleShops
{
    public partial class LoginForm : Form
    {
        private AccountInformation currentAccount = null;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ResetAccountInformation()
        {
            currentAccount = AccountInformation.GetInstance();
            currentAccount.CurrentAccount = null;
            currentAccount.CurrentAccount.Employee = null;            
        }

        private void InitAccountInformation(Account account)
        {
            currentAccount = AccountInformation.GetInstance();
            currentAccount.CurrentAccount = account;
            currentAccount.CurrentAccount.Employee = EmployeeDAL.GetInstance().GetEmployeeByID((long)account.EmployeeID);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            var accountDAL = AccountDAL.GetInstance();
            var account = accountDAL.GetAccountByUsername(username);
            if (password.Equals(account.Password))
            {
                InitAccountInformation(account);
                this.Opacity = 0;
                var menuForm = new MenuForm();
                menuForm.ShowDialog(this);
                this.Opacity = 1;
                ResetAccountInformation();               
            }
            else
            {
                MessageBox.Show("Username or password is wrong!", "Authentication fail", MessageBoxButtons.OK);
            }
        }
    }
}
