namespace MotorcycleShops
{
    partial class btnCreate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtChassis = new System.Windows.Forms.TextBox();
            this.txtEngine = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvQuotation = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnBillDetail = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.btnCreateBill = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuotation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(637, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maintenance Bill";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(136, 207);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 32);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtChassis
            // 
            this.txtChassis.Location = new System.Drawing.Point(136, 162);
            this.txtChassis.Name = "txtChassis";
            this.txtChassis.Size = new System.Drawing.Size(200, 20);
            this.txtChassis.TabIndex = 2;
            // 
            // txtEngine
            // 
            this.txtEngine.Location = new System.Drawing.Point(136, 131);
            this.txtEngine.Name = "txtEngine";
            this.txtEngine.Size = new System.Drawing.Size(200, 20);
            this.txtEngine.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Chassis Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Engine Number";
            // 
            // dgvQuotation
            // 
            this.dgvQuotation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuotation.Location = new System.Drawing.Point(365, 66);
            this.dgvQuotation.Name = "dgvQuotation";
            this.dgvQuotation.ReadOnly = true;
            this.dgvQuotation.Size = new System.Drawing.Size(817, 228);
            this.dgvQuotation.TabIndex = 16;
            this.dgvQuotation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuotation_CellContentClick);
            this.dgvQuotation.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvQuotation_DataError);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(1188, 66);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(58, 112);
            this.btnSelect.TabIndex = 17;
            this.btnSelect.Text = "Select Or Remove";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnBillDetail
            // 
            this.btnBillDetail.Location = new System.Drawing.Point(1188, 175);
            this.btnBillDetail.Name = "btnBillDetail";
            this.btnBillDetail.Size = new System.Drawing.Size(58, 119);
            this.btnBillDetail.TabIndex = 18;
            this.btnBillDetail.Text = "Bill Detail";
            this.btnBillDetail.UseVisualStyleBackColor = true;
            this.btnBillDetail.Click += new System.EventHandler(this.btnChooseEmployees_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Customer Payment";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(136, 262);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(200, 20);
            this.txtCustomer.TabIndex = 3;
            // 
            // btnCreateBill
            // 
            this.btnCreateBill.Location = new System.Drawing.Point(641, 315);
            this.btnCreateBill.Name = "btnCreateBill";
            this.btnCreateBill.Size = new System.Drawing.Size(168, 50);
            this.btnCreateBill.TabIndex = 4;
            this.btnCreateBill.Text = "Create Maintenance Bill";
            this.btnCreateBill.UseVisualStyleBackColor = true;
            this.btnCreateBill.Click += new System.EventHandler(this.btnCreateBill_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(133, 102);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 10;
            // 
            // btnCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 395);
            this.Controls.Add(this.btnCreateBill);
            this.Controls.Add(this.btnBillDetail);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dgvQuotation);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.txtChassis);
            this.Controls.Add(this.txtEngine);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Name = "btnCreate";
            this.Text = "MaitenanceBillForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuotation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtChassis;
        private System.Windows.Forms.TextBox txtEngine;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvQuotation;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnBillDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Button btnCreateBill;
        private System.Windows.Forms.Label lblID;
    }
}