namespace Lab.TP4.UI
{
    partial class OrderDetailsForm
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
            this.components = new System.ComponentModel.Container();
            this.gbxSelectedOrder = new System.Windows.Forms.GroupBox();
            this.btnDeleteEntry = new System.Windows.Forms.Button();
            this.btnModifyEntry = new System.Windows.Forms.Button();
            this.btnAddEntry = new System.Windows.Forms.Button();
            this.lbxOrderDetails = new System.Windows.Forms.ListBox();
            this.numSearchOrderId = new System.Windows.Forms.NumericUpDown();
            this.btnSearchOrder = new System.Windows.Forms.Button();
            this.lbSearchMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timLabelTimer = new System.Windows.Forms.Timer(this.components);
            this.gbxSelectedOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSearchOrderId)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxSelectedOrder
            // 
            this.gbxSelectedOrder.Controls.Add(this.btnDeleteEntry);
            this.gbxSelectedOrder.Controls.Add(this.btnModifyEntry);
            this.gbxSelectedOrder.Controls.Add(this.btnAddEntry);
            this.gbxSelectedOrder.Controls.Add(this.lbxOrderDetails);
            this.gbxSelectedOrder.Enabled = false;
            this.gbxSelectedOrder.Location = new System.Drawing.Point(12, 93);
            this.gbxSelectedOrder.Name = "gbxSelectedOrder";
            this.gbxSelectedOrder.Size = new System.Drawing.Size(704, 382);
            this.gbxSelectedOrder.TabIndex = 0;
            this.gbxSelectedOrder.TabStop = false;
            // 
            // btnDeleteEntry
            // 
            this.btnDeleteEntry.Location = new System.Drawing.Point(600, 167);
            this.btnDeleteEntry.Name = "btnDeleteEntry";
            this.btnDeleteEntry.Size = new System.Drawing.Size(99, 34);
            this.btnDeleteEntry.TabIndex = 1;
            this.btnDeleteEntry.Text = "Delete";
            this.btnDeleteEntry.UseVisualStyleBackColor = true;
            this.btnDeleteEntry.Click += new System.EventHandler(this.btnDeleteEntry_Click);
            // 
            // btnModifyEntry
            // 
            this.btnModifyEntry.Location = new System.Drawing.Point(600, 97);
            this.btnModifyEntry.Name = "btnModifyEntry";
            this.btnModifyEntry.Size = new System.Drawing.Size(99, 34);
            this.btnModifyEntry.TabIndex = 1;
            this.btnModifyEntry.Text = "Modify Entry";
            this.btnModifyEntry.UseVisualStyleBackColor = true;
            this.btnModifyEntry.Click += new System.EventHandler(this.btnModifyEntry_Click);
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.Location = new System.Drawing.Point(600, 29);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(99, 34);
            this.btnAddEntry.TabIndex = 1;
            this.btnAddEntry.Text = "Add Entry";
            this.btnAddEntry.UseVisualStyleBackColor = true;
            this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
            // 
            // lbxOrderDetails
            // 
            this.lbxOrderDetails.FormattingEnabled = true;
            this.lbxOrderDetails.Location = new System.Drawing.Point(6, 29);
            this.lbxOrderDetails.Name = "lbxOrderDetails";
            this.lbxOrderDetails.Size = new System.Drawing.Size(588, 342);
            this.lbxOrderDetails.TabIndex = 0;
            // 
            // numSearchOrderId
            // 
            this.numSearchOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSearchOrderId.Location = new System.Drawing.Point(28, 54);
            this.numSearchOrderId.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.numSearchOrderId.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSearchOrderId.Name = "numSearchOrderId";
            this.numSearchOrderId.Size = new System.Drawing.Size(120, 22);
            this.numSearchOrderId.TabIndex = 1;
            this.numSearchOrderId.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // btnSearchOrder
            // 
            this.btnSearchOrder.Location = new System.Drawing.Point(175, 54);
            this.btnSearchOrder.Name = "btnSearchOrder";
            this.btnSearchOrder.Size = new System.Drawing.Size(112, 23);
            this.btnSearchOrder.TabIndex = 2;
            this.btnSearchOrder.Text = "Search";
            this.btnSearchOrder.UseVisualStyleBackColor = true;
            this.btnSearchOrder.Click += new System.EventHandler(this.btnSearchOrder_Click);
            // 
            // lbSearchMessage
            // 
            this.lbSearchMessage.AutoSize = true;
            this.lbSearchMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearchMessage.ForeColor = System.Drawing.Color.IndianRed;
            this.lbSearchMessage.Location = new System.Drawing.Point(375, 64);
            this.lbSearchMessage.Name = "lbSearchMessage";
            this.lbSearchMessage.Size = new System.Drawing.Size(0, 20);
            this.lbSearchMessage.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Oder by ID";
            // 
            // timLabelTimer
            // 
            this.timLabelTimer.Interval = 5000;
            this.timLabelTimer.Tick += new System.EventHandler(this.timLabelTimer_Tick);
            // 
            // OrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSearchMessage);
            this.Controls.Add(this.btnSearchOrder);
            this.Controls.Add(this.numSearchOrderId);
            this.Controls.Add(this.gbxSelectedOrder);
            this.Name = "OrderDetailsForm";
            this.Text = "Orders Details";
            this.gbxSelectedOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSearchOrderId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSelectedOrder;
        private System.Windows.Forms.ListBox lbxOrderDetails;
        private System.Windows.Forms.NumericUpDown numSearchOrderId;
        private System.Windows.Forms.Button btnSearchOrder;
        private System.Windows.Forms.Label lbSearchMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteEntry;
        private System.Windows.Forms.Button btnModifyEntry;
        private System.Windows.Forms.Button btnAddEntry;
        private System.Windows.Forms.Timer timLabelTimer;
    }
}