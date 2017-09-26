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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnNewSaleReceipt_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
            var saleReceiptForm = new SaleReceiptForm();
            saleReceiptForm.ShowDialog(this);
            this.Opacity = 1;
        }

        private void btnNewMaintenanceBill_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
            var maintenancebillForm = new MaintenanceBillForm();
            maintenancebillForm.ShowDialog(this);
            this.Opacity = 1;
        }

        private void btnNewMotorcycle_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
            var bikeForm = new BikeForm(null, true);
            bikeForm.ShowDialog(this);
            this.Opacity = 1;
        }
    }
}
