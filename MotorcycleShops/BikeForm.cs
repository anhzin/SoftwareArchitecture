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
    public partial class BikeForm : Form
    {
        private Mode mode;
        private Bike bike;
        public BikeForm(Bike bike, Mode mode)
        {
            InitializeComponent();
            if(bike == null)
            {
                bike = new Bike();
            }
            this.mode = mode;
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

            switch (mode)
            {
                case Mode.MODE_READ_ONLY:
                    {
                        TurnOnReadOnlyMode();
                        break;
                    }                    
                case Mode.MODE_EDITING:
                    {
                        TurnOnEditingMode();
                        break;
                    }
                case Mode.MODE_CREATE:
                    {
                        TurnOnCreateMode();
                        break;
                    }
                default:
                    break;
            }

        }

        private void TurnOnReadOnlyMode()
        {
            btnAdd.Enabled = false;
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).ReadOnly = true;
                }
            }
        }
        private void TurnOnEditingMode()
        {
            btnAdd.Enabled = false;
            txtChassis.Enabled = false;
            txtEngine.Enabled = false;
        }
        private void TurnOnCreateMode()
        {
            btnModify.Enabled = false;
        }
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool success = BikeDAL.GetInstance().InsertBike(bike);
            if (success)
            {
                MessageBox.Show("Insert Success");
            }
            else
            {
                MessageBox.Show("Insert fail");
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            bool success = BikeDAL.GetInstance().UpdateBike(bike);
            if (success)
            {
                MessageBox.Show("Update Success");
            }
            else
            {
                MessageBox.Show("Update fail");
            }            
        }
    }
}
