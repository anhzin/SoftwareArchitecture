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
    public partial class btnCreate : Form
    {
        private Bike bike = null;
        string customer = "";
        private List<BillDetail> currentList = null;
        public btnCreate()
        {
            InitializeComponent();
            InitForm();
        }

        private void InitForm()
        {
            lblID.Text = "";
            var list = QuotationTableDAL.GetInstance().GetAllItems();
            dgvQuotation.DataSource = list;
            this.currentList = new List<BillDetail>();
        }

        private void dgvQuotation_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
        }

        private void dgvQuotation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int selectedRowIndex = e.RowIndex;
            DataGridViewRow row = dgvQuotation.Rows[selectedRowIndex];
            //row.DefaultCellStyle.BackColor = Color.Red;

            //string empID = row.Cells[0].Value.ToString();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvQuotation.CurrentRow.Index;
            DataGridViewRow row = dgvQuotation.Rows[selectedRowIndex];
            var id = (long)row.Cells[0].Value;
            if (row.DefaultCellStyle.BackColor != Color.Yellow)
            {
                row.DefaultCellStyle.BackColor = Color.Yellow;
                AddQuotationItem(id);
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.White;
                RemoveQuotationItem(id);
            }
        }

        private void AddQuotationItem(long id)
        {
            var billDetail = new BillDetail()
            {
                QuotationID = id,
                Quantity = 1,
            };
            currentList.Add(billDetail);
        }
        private void RemoveQuotationItem(long id)
        {
            currentList.Remove(currentList.Single(q => q.QuotationID == id));
        }

        private void btnChooseEmployees_Click(object sender, EventArgs e)
        {

            int selectedRowIndex = dgvQuotation.CurrentRow.Index;
            DataGridViewRow row = dgvQuotation.Rows[selectedRowIndex];
            var id = (long)row.Cells[0].Value;
            if (row.DefaultCellStyle.BackColor != Color.Yellow)
            {
                return;
            }
            var billDetail = currentList.Single(i => i.QuotationID == id);
            var billDetailForm = new BillDetailForm(billDetail);
            billDetailForm.ShowDialog(this);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var engine = txtEngine.Text;
            var chassis = txtChassis.Text;
            bike = BikeDAL.GetInstance().SearchBike(engine, chassis);
            if(bike == null)
            {
                MessageBox.Show("Bike not found");
                lblID.Text = "";
                return;
            }
            else
            {
                lblID.Text = bike.ID + "";
            }
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            customer = txtCustomer.Text;
            btnSearch_Click(null, null);
            if(bike == null)
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(customer))
            {
                MessageBox.Show("Customer Payment is empty");
                return;
            }if(currentList.Count == 0)
            {
                MessageBox.Show("Please Select products or services");
                return;
            }
            StoreData();
        }

        private void StoreData()
        {
            var cashier = AccountInformation.GetInstance().CurrentAccount.Employee;
            var bill = new MaintenanceBill()
            {
                BikeID = bike.ID,
                Date = DateTime.Now,
                CashierID = cashier.ID,
                StoreID = cashier.StoreID,
                CustomerPayment = customer
            };
            bill.ID = MaintenanceBillDAL.GetInstance().Insert(bill);
            foreach (var item in currentList)
            {
                item.BillID = bill.ID;
                var billDetailID = BillDetailDAL.GetInstance().Insert(item);
                //foreach (var billEmp in item.BillEmployees)
                //{
                //    billEmp.BillDetailID = billDetailID;
                //    BillEmployeesDAL.GetInstance().Insert(billEmp);
                //}
            }
            MessageBox.Show("Create Bill Success");
            this.Close();
        }
    }
}
