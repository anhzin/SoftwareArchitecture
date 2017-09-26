using BussinessLogic.DataAccess;
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
    public partial class ChooseEmployeesForm : Form
    {
        public ChooseEmployeesForm()
        {
            InitializeComponent();
            InitForm();
        }

        private void InitForm()
        {
            var list = EmployeeDAL.GetInstance().GetAllItems();
            dgvEmployees.DataSource = list;
        }

        private void dgvEmployees_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;
            DataGridViewRow row = dgvEmployees.Rows[selectedRowIndex];
            if (row.DefaultCellStyle.BackColor != Color.Yellow)
            {
                row.DefaultCellStyle.BackColor = Color.Yellow;
                
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.White;
                
            }
        }
    }
}
