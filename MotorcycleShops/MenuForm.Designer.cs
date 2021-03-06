﻿namespace MotorcycleShops
{
    partial class MenuForm
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
            this.btnNewSaleReceipt = new System.Windows.Forms.Button();
            this.btnNewMaintenanceBill = new System.Windows.Forms.Button();
            this.btnNewMotorcycle = new System.Windows.Forms.Button();
            this.btnEditMotorcycle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Motorcycle Shops Manager";
            // 
            // btnNewSaleReceipt
            // 
            this.btnNewSaleReceipt.Location = new System.Drawing.Point(74, 81);
            this.btnNewSaleReceipt.Name = "btnNewSaleReceipt";
            this.btnNewSaleReceipt.Size = new System.Drawing.Size(174, 34);
            this.btnNewSaleReceipt.TabIndex = 1;
            this.btnNewSaleReceipt.Text = "New Sale Receipt";
            this.btnNewSaleReceipt.UseVisualStyleBackColor = true;
            this.btnNewSaleReceipt.Click += new System.EventHandler(this.btnNewSaleReceipt_Click);
            // 
            // btnNewMaintenanceBill
            // 
            this.btnNewMaintenanceBill.Location = new System.Drawing.Point(380, 81);
            this.btnNewMaintenanceBill.Name = "btnNewMaintenanceBill";
            this.btnNewMaintenanceBill.Size = new System.Drawing.Size(174, 34);
            this.btnNewMaintenanceBill.TabIndex = 1;
            this.btnNewMaintenanceBill.Text = "New Maintenance Bill";
            this.btnNewMaintenanceBill.UseVisualStyleBackColor = true;
            this.btnNewMaintenanceBill.Click += new System.EventHandler(this.btnNewMaintenanceBill_Click);
            // 
            // btnNewMotorcycle
            // 
            this.btnNewMotorcycle.Location = new System.Drawing.Point(74, 142);
            this.btnNewMotorcycle.Name = "btnNewMotorcycle";
            this.btnNewMotorcycle.Size = new System.Drawing.Size(174, 34);
            this.btnNewMotorcycle.TabIndex = 2;
            this.btnNewMotorcycle.Text = "New Motorcycle";
            this.btnNewMotorcycle.UseVisualStyleBackColor = true;
            this.btnNewMotorcycle.Click += new System.EventHandler(this.btnNewMotorcycle_Click);
            // 
            // btnEditMotorcycle
            // 
            this.btnEditMotorcycle.Location = new System.Drawing.Point(380, 142);
            this.btnEditMotorcycle.Name = "btnEditMotorcycle";
            this.btnEditMotorcycle.Size = new System.Drawing.Size(174, 34);
            this.btnEditMotorcycle.TabIndex = 3;
            this.btnEditMotorcycle.Text = "Edit Motorcycle";
            this.btnEditMotorcycle.UseVisualStyleBackColor = true;
            this.btnEditMotorcycle.Click += new System.EventHandler(this.btnEditMotorcycle_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 261);
            this.Controls.Add(this.btnEditMotorcycle);
            this.Controls.Add(this.btnNewMotorcycle);
            this.Controls.Add(this.btnNewMaintenanceBill);
            this.Controls.Add(this.btnNewSaleReceipt);
            this.Controls.Add(this.label1);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewSaleReceipt;
        private System.Windows.Forms.Button btnNewMaintenanceBill;
        private System.Windows.Forms.Button btnNewMotorcycle;
        private System.Windows.Forms.Button btnEditMotorcycle;
    }
}