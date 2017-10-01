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
    public partial class ListBikeForm : Form
    {
        private List<Bike> dataSource = null;
        public ListBikeForm()
        {
            InitializeComponent();
            InitForm();
        }
        private void InitForm()
        {
            btnGetAll_Click(null, null);
        }

        private void dgvListBike_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            dataSource = BikeDAL.GetInstance().GetAllBikes();
            dgvListBike.DataSource = dataSource;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataSource = BikeDAL.GetInstance().FilterBike(txtEngine.Text, txtChassis.Text, txtCode.Text);
            dgvListBike.DataSource = dataSource;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvListBike.CurrentRow.Index;
            DataGridViewRow row = dgvListBike.Rows[selectedRowIndex];
            var id = (long)row.Cells[0].Value;
            var bike = dataSource.Single(i => i.ID == id);

            this.Opacity = 0;
            var bikeForm = new BikeForm(bike, Mode.MODE_EDITING);
            bikeForm.ShowDialog(this);
            btnSearch_Click(null, null);
            this.Opacity = 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvListBike.CurrentRow.Index;
            DataGridViewRow row = dgvListBike.Rows[selectedRowIndex];
            var id = (long)row.Cells[0].Value;
            var success = BikeDAL.GetInstance().Delete(id);
            if (success)
            {
                MessageBox.Show("Delete success");
                btnSearch_Click(null, null);
            }
            else
            {
                MessageBox.Show("Delete Fail");
            }
        }
    }
}
