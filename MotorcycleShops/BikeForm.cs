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
            txtCapacity.Text = bike.Capacity == null ? "" : bike.Capacity + "";
            txtCustomerID.Text = bike.CustomerID == null ? "" : bike.CustomerID + "";
            txtPrice.Text = bike.Price == null ? "" : bike.Price + "";
            txtStoreID.Text = bike.StoreID == null ? "" : bike.StoreID + "";

            lblID.DataBindings.Add("Text", bike, "ID");
            txtEngine.DataBindings.Add("Text", bike, "EngineNumber");
            txtChassis.DataBindings.Add("Text", bike, "ChassisNumber");
            txtBrand.DataBindings.Add("Text", bike, "Brand");            
            txtCode.DataBindings.Add("Text", bike, "ModelCode");
            txtColor.DataBindings.Add("Text", bike, "Color");            
            txtPlate.DataBindings.Add("Text", bike, "PlateNumber");            
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
        
        private void parseData()
        {
            int tmp;
            if(int.TryParse(txtCapacity.Text, out tmp))
            {
                bike.Capacity = tmp;
            }
            long tmpLong;
            if(long.TryParse(txtPrice.Text, out tmpLong))
            {
                bike.Price = tmpLong;
            }
            if(long.TryParse(txtCustomerID.Text, out tmpLong))
            {
                bike.CustomerID = tmpLong;
            }
            if(long.TryParse(txtStoreID.Text, out tmpLong))
            {
                bike.StoreID = tmpLong;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            parseData();
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
            parseData();
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
