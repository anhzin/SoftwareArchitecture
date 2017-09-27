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
    public partial class BillDetailForm : Form
    {
        private BillDetail billDetail = null;
        public BillDetailForm(BillDetail billDetail)
        {
            InitializeComponent();
            this.billDetail = billDetail;
            InitForm();            
        }

        private void InitForm()
        {
            nupQuantity.Value = (decimal)billDetail.Quantity;
            txtNote.DataBindings.Add("Text", billDetail, "Note");
            
            var list = EmployeeDAL.GetInstance().GetAllItems();
            dgvEmployees.DataSource = list;            
        }

        private void dgvEmployees_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            billDetail.Quantity = (int)nupQuantity.Value;
            this.Close();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvEmployees.CurrentRow.Index;
            DataGridViewRow row = dgvEmployees.Rows[selectedRowIndex];
            var id = (long)row.Cells[0].Value;
            if (row.DefaultCellStyle.BackColor != Color.Yellow)
            {
                row.DefaultCellStyle.BackColor = Color.Yellow;
                AddItem(id);
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.White;
                RemoveItem(id);
            }
        }

        private void AddItem(long id)
        {
            var billEmployees = new BillEmployee()
            {
                EmployeeID = id,
            };
            billDetail.BillEmployees.Add(billEmployees);
        }
        private void RemoveItem(long id)
        {
            billDetail.BillEmployees.Remove(billDetail.BillEmployees.Single(i => i.EmployeeID == id));
        }

        private void dgvEmployees_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var row = dgvEmployees.Rows[e.RowIndex];
            var id = (long)row.Cells[0].Value;
            if (billDetail.BillEmployees.Count(i => i.EmployeeID == id) > 0)
            {
                row.DefaultCellStyle.BackColor = Color.Yellow;
            }

        }
    }
}
