namespace Lab.TP4.UI
{
    partial class OrderEntryForm
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
            this.cbxSelectProduct = new System.Windows.Forms.ComboBox();
            this.lbProductName = new System.Windows.Forms.Label();
            this.gbxOrderEntryDetails = new System.Windows.Forms.GroupBox();
            this.numUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.btnModifyEntry = new System.Windows.Forms.Button();
            this.btnAddNewEntry = new System.Windows.Forms.Button();
            this.numProductID = new System.Windows.Forms.NumericUpDown();
            this.lbProductID = new System.Windows.Forms.Label();
            this.gbxOrderEntryDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProductID)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxSelectProduct
            // 
            this.cbxSelectProduct.FormattingEnabled = true;
            this.cbxSelectProduct.Location = new System.Drawing.Point(12, 49);
            this.cbxSelectProduct.Name = "cbxSelectProduct";
            this.cbxSelectProduct.Size = new System.Drawing.Size(246, 21);
            this.cbxSelectProduct.TabIndex = 0;
            this.cbxSelectProduct.SelectedIndexChanged += new System.EventHandler(this.cbxSelectProduct_SelectedIndexChanged);
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductName.Location = new System.Drawing.Point(13, 23);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(59, 16);
            this.lbProductName.TabIndex = 1;
            this.lbProductName.Text = "Product :";
            // 
            // gbxOrderEntryDetails
            // 
            this.gbxOrderEntryDetails.Controls.Add(this.lbDiscount);
            this.gbxOrderEntryDetails.Controls.Add(this.lbQuantity);
            this.gbxOrderEntryDetails.Controls.Add(this.lbProductID);
            this.gbxOrderEntryDetails.Controls.Add(this.lbUnitPrice);
            this.gbxOrderEntryDetails.Controls.Add(this.numDiscount);
            this.gbxOrderEntryDetails.Controls.Add(this.numQuantity);
            this.gbxOrderEntryDetails.Controls.Add(this.numProductID);
            this.gbxOrderEntryDetails.Controls.Add(this.numUnitPrice);
            this.gbxOrderEntryDetails.Controls.Add(this.btnAddNewEntry);
            this.gbxOrderEntryDetails.Controls.Add(this.btnModifyEntry);
            this.gbxOrderEntryDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxOrderEntryDetails.Location = new System.Drawing.Point(275, 23);
            this.gbxOrderEntryDetails.Name = "gbxOrderEntryDetails";
            this.gbxOrderEntryDetails.Size = new System.Drawing.Size(181, 373);
            this.gbxOrderEntryDetails.TabIndex = 2;
            this.gbxOrderEntryDetails.TabStop = false;
            this.gbxOrderEntryDetails.Text = "Order Entry Details";
            // 
            // numUnitPrice
            // 
            this.numUnitPrice.DecimalPlaces = 2;
            this.numUnitPrice.Location = new System.Drawing.Point(17, 127);
            this.numUnitPrice.Name = "numUnitPrice";
            this.numUnitPrice.Size = new System.Drawing.Size(139, 22);
            this.numUnitPrice.TabIndex = 0;
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(14, 97);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(64, 16);
            this.lbUnitPrice.TabIndex = 1;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(17, 197);
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(139, 22);
            this.numQuantity.TabIndex = 0;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(14, 167);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(55, 16);
            this.lbQuantity.TabIndex = 1;
            this.lbQuantity.Text = "Quantity";
            // 
            // numDiscount
            // 
            this.numDiscount.DecimalPlaces = 2;
            this.numDiscount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numDiscount.Location = new System.Drawing.Point(17, 271);
            this.numDiscount.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(139, 22);
            this.numDiscount.TabIndex = 0;
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Location = new System.Drawing.Point(14, 241);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(59, 16);
            this.lbDiscount.TabIndex = 1;
            this.lbDiscount.Text = "Discount";
            // 
            // btnModifyEntry
            // 
            this.btnModifyEntry.Location = new System.Drawing.Point(17, 313);
            this.btnModifyEntry.Name = "btnModifyEntry";
            this.btnModifyEntry.Size = new System.Drawing.Size(139, 46);
            this.btnModifyEntry.TabIndex = 2;
            this.btnModifyEntry.Text = "Confirm Modifications";
            this.btnModifyEntry.UseVisualStyleBackColor = true;
            this.btnModifyEntry.Click += new System.EventHandler(this.btnModifyEntry_Click);
            // 
            // btnAddNewEntry
            // 
            this.btnAddNewEntry.Location = new System.Drawing.Point(17, 313);
            this.btnAddNewEntry.Name = "btnAddNewEntry";
            this.btnAddNewEntry.Size = new System.Drawing.Size(139, 46);
            this.btnAddNewEntry.TabIndex = 2;
            this.btnAddNewEntry.Text = "Confirm and Add";
            this.btnAddNewEntry.UseVisualStyleBackColor = true;
            this.btnAddNewEntry.Click += new System.EventHandler(this.btnAddNewEntry_Click);
            // 
            // numProductID
            // 
            this.numProductID.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numProductID.Location = new System.Drawing.Point(17, 61);
            this.numProductID.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numProductID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numProductID.Name = "numProductID";
            this.numProductID.ReadOnly = true;
            this.numProductID.Size = new System.Drawing.Size(139, 22);
            this.numProductID.TabIndex = 0;
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Location = new System.Drawing.Point(14, 31);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(69, 16);
            this.lbProductID.TabIndex = 1;
            this.lbProductID.Text = "Product ID";
            // 
            // OrderEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 408);
            this.Controls.Add(this.gbxOrderEntryDetails);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.cbxSelectProduct);
            this.Name = "OrderEntryForm";
            this.Text = "New Order Entry";
            this.gbxOrderEntryDetails.ResumeLayout(false);
            this.gbxOrderEntryDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProductID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxSelectProduct;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.GroupBox gbxOrderEntryDetails;
        private System.Windows.Forms.NumericUpDown numUnitPrice;
        private System.Windows.Forms.Button btnModifyEntry;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.NumericUpDown numDiscount;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Button btnAddNewEntry;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.NumericUpDown numProductID;
    }
}