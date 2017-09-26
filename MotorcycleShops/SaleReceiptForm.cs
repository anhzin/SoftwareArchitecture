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
    public partial class SaleReceiptForm : Form
    {
        private BikeDAL bikeDAL = BikeDAL.GetInstance();
        private Bike bike = null; 
        public SaleReceiptForm()
        {
            InitializeComponent();
            lblID.Text = "";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var chassis = txtChassis.Text;
            var engine = txtEngine.Text;
            bike = bikeDAL.SearchBike(engine, chassis);
            if (bike == null)
            {
                lblID.Text = "";
                MessageBox.Show("Bike not found", "Alert", MessageBoxButtons.OK);
                return;
            }            

            var name = txtName.Text;
            var dob = dtpDOB.Value;
            var address = txtAddress.Text;
            var phone = txtPhone.Text;
            var email = txtEmail.Text;
            if(string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Name and Phone can not is empty", "Alert", MessageBoxButtons.OK);
                return;
            }
            var customer = new Customer()
            {
                Name = name,
                DOB = dob,
                Address = address,
                PhoneNumber = phone,
                Email = email
            };
            var result = CustomerDAL.GetInstance().InsertCustomer(customer);
            if (!result.Success)
            {
                MessageBox.Show(result.Error, "Alert", MessageBoxButtons.OK);
                return;
            }
            bike.CustomerID = result.CurrentIdentity;

            result = SaleReceiptDAL.GetInstance().CreateNewSaleReceipt(customer.PhoneNumber, bike);
            if (!result.Success)
            {
                MessageBox.Show(result.Error, "Alert", MessageBoxButtons.OK);
                return;
            }
            else
            {
                MessageBox.Show("Create sale receipt success", "Alert", MessageBoxButtons.OK);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var chassis = txtChassis.Text;
            var engine = txtEngine.Text;
            bike = bikeDAL.SearchBike(engine, chassis);
            if(bike == null)
            {
                lblID.Text = "";
                MessageBox.Show("Bike not found", "Alert", MessageBoxButtons.OK);
            }
            else
            {
                lblID.Text = bike.ID + "";
                var bikeForm = new BikeForm(bike, false);
                bikeForm.ShowDialog(this);
            }
        }
    }
}
