namespace MotorcycleShops
{
    partial class MaintenanceBillForm
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
            this.btnChooseEmployees = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuotation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maintenance Bill";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(136, 186);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 32);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtChassis
            // 
            this.txtChassis.Location = new System.Drawing.Point(136, 141);
            this.txtChassis.Name = "txtChassis";
            this.txtChassis.Size = new System.Drawing.Size(200, 20);
            this.txtChassis.TabIndex = 14;
            // 
            // txtEngine
            // 
            this.txtEngine.Location = new System.Drawing.Point(136, 110);
            this.txtEngine.Name = "txtEngine";
            this.txtEngine.Size = new System.Drawing.Size(200, 20);
            this.txtEngine.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Chassis Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Engine Number";
            // 
            // dgvQuotation
            // 
            this.dgvQuotation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuotation.Location = new System.Drawing.Point(365, 81);
            this.dgvQuotation.Name = "dgvQuotation";
            this.dgvQuotation.ReadOnly = true;
            this.dgvQuotation.Size = new System.Drawing.Size(881, 213);
            this.dgvQuotation.TabIndex = 16;
            this.dgvQuotation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuotation_CellContentClick);
            this.dgvQuotation.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvQuotation_DataError);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(836, 319);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(145, 40);
            this.btnSelect.TabIndex = 17;
            this.btnSelect.Text = "Select Or Remove";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnChooseEmployees
            // 
            this.btnChooseEmployees.Location = new System.Drawing.Point(1012, 319);
            this.btnChooseEmployees.Name = "btnChooseEmployees";
            this.btnChooseEmployees.Size = new System.Drawing.Size(123, 40);
            this.btnChooseEmployees.TabIndex = 18;
            this.btnChooseEmployees.Text = "button1";
            this.btnChooseEmployees.UseVisualStyleBackColor = true;
            this.btnChooseEmployees.Click += new System.EventHandler(this.btnChooseEmployees_Click);
            // 
            // MaintenanceBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 395);
            this.Controls.Add(this.btnChooseEmployees);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dgvQuotation);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtChassis);
            this.Controls.Add(this.txtEngine);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Name = "MaintenanceBillForm";
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
        private System.Windows.Forms.Button btnChooseEmployees;
    }
}