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
    public partial class MaintenanceBillForm : Form
    {
        private List<QuotationTable> list = null;
        private List<QuotationTable> ds = null;
        public MaintenanceBillForm()
        {
            InitializeComponent();
            InitForm();
        }

        private void InitForm()
        {
            var list = QuotationTableDAL.GetInstance().GetAllItems();
            dgvQuotation.DataSource = list;
            ds = list;
            this.list = new List<QuotationTable>();
        }

        private void dgvQuotation_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

            if (e.Context == DataGridViewDataErrorContexts.Commit)
            {
            }
            if (e.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            {
            }
            if (e.Context == DataGridViewDataErrorContexts.Parsing)
            {
            }
            if (e.Context == DataGridViewDataErrorContexts.LeaveControl)
            {
            }

            if ((e.Exception) is ConstraintException)
            {
                //DataGridView view = (DataGridView)sender;
                //view.Rows[e.RowIndex].ErrorText = "an error";
                //view.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "an error";

                //e.ThrowException = false;
            }
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
            var obj = ds[selectedRowIndex];
            if (row.DefaultCellStyle.BackColor != Color.Yellow)
            {
                row.DefaultCellStyle.BackColor = Color.Yellow;
                list.Add(obj);
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.White;
                list.Remove(obj);
            }
        }

        private void btnChooseEmployees_Click(object sender, EventArgs e)
        {
            var chooseEmployeesForm = new ChooseEmployeesForm();
            chooseEmployeesForm.ShowDialog(this);
        }
    }
}
