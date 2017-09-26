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
    public partial class BikeForm : Form
    {
        private bool _isEditable = true;
        private Bike bike;
        public BikeForm(Bike bike, bool editable)
        {
            InitializeComponent();
            if(bike == null)
            {
                bike = new Bike();
            }
            _isEditable = editable;
            this.bike = bike;
            BindingProperty();
        }
        private void BindingProperty()
        {
            lblID.DataBindings.Add("Text", bike, "ID");
            txtEngine.DataBindings.Add("Text", bike, "EngineNumber");
            txtChassis.DataBindings.Add("Text", bike, "ChassisNumber");
            txtBrand.DataBindings.Add("Text", bike, "Brand");
            txtCapacity.DataBindings.Add("Text", bike, "Capacity");
            txtCode.DataBindings.Add("Text", bike, "ModelCode");
            txtColor.DataBindings.Add("Text", bike, "Color");
            txtCustomerID.DataBindings.Add("Text", bike, "CustomerID");
            txtPlate.DataBindings.Add("Text", bike, "PlateNumber");
            txtPrice.DataBindings.Add("Text", bike, "Price");
            txtStoreID.DataBindings.Add("Text", bike, "StoreID");
            txtWarranty.DataBindings.Add("Text", bike, "WarrantyPeriod");            

            if (!_isEditable)
            {
                DisableEditing();
            }
        }

        private void DisableEditing()
        {
            btnAdd.Enabled = false;
            foreach (var item in this.Controls)
            {
                if(item is TextBox)
                {
                    ((TextBox)item).ReadOnly = true;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
