namespace EjercicioPOO
{
    partial class mainform
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numPassanger = new System.Windows.Forms.NumericUpDown();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbOmnibus = new System.Windows.Forms.RadioButton();
            this.lbVehicles = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteVehi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPassanger)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(166, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido a la terminal de transporte público";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnAdd.ForeColor = System.Drawing.Color.Gold;
            this.btnAdd.Location = new System.Drawing.Point(165, 189);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 44);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(14, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad de pasajeros:";
            // 
            // numPassanger
            // 
            this.numPassanger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.numPassanger.Location = new System.Drawing.Point(212, 125);
            this.numPassanger.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPassanger.Name = "numPassanger";
            this.numPassanger.Size = new System.Drawing.Size(54, 26);
            this.numPassanger.TabIndex = 1;
            this.numPassanger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPassanger.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.radioButton1.ForeColor = System.Drawing.Color.Gold;
            this.radioButton1.Location = new System.Drawing.Point(137, 80);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 26);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.Text = "Taxi";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // rbOmnibus
            // 
            this.rbOmnibus.AutoSize = true;
            this.rbOmnibus.BackColor = System.Drawing.Color.Transparent;
            this.rbOmnibus.Checked = true;
            this.rbOmnibus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.rbOmnibus.ForeColor = System.Drawing.Color.Gold;
            this.rbOmnibus.Location = new System.Drawing.Point(137, 37);
            this.rbOmnibus.Name = "rbOmnibus";
            this.rbOmnibus.Size = new System.Drawing.Size(99, 26);
            this.rbOmnibus.TabIndex = 3;
            this.rbOmnibus.TabStop = true;
            this.rbOmnibus.Text = "Omnibus";
            this.rbOmnibus.UseVisualStyleBackColor = false;
            // 
            // lbVehicles
            // 
            this.lbVehicles.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lbVehicles.ForeColor = System.Drawing.Color.Gold;
            this.lbVehicles.FormattingEnabled = true;
            this.lbVehicles.ItemHeight = 22;
            this.lbVehicles.Location = new System.Drawing.Point(30, 120);
            this.lbVehicles.Name = "lbVehicles";
            this.lbVehicles.Size = new System.Drawing.Size(294, 246);
            this.lbVehicles.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbOmnibus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.numPassanger);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(345, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 253);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar transporte";
            // 
            // btnDeleteVehi
            // 
            this.btnDeleteVehi.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDeleteVehi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnDeleteVehi.ForeColor = System.Drawing.Color.Gold;
            this.btnDeleteVehi.Location = new System.Drawing.Point(345, 120);
            this.btnDeleteVehi.Name = "btnDeleteVehi";
            this.btnDeleteVehi.Size = new System.Drawing.Size(140, 41);
            this.btnDeleteVehi.TabIndex = 6;
            this.btnDeleteVehi.Text = "Eliminar Vehiculos";
            this.btnDeleteVehi.UseVisualStyleBackColor = false;
            this.btnDeleteVehi.Click += new System.EventHandler(this.btnDeleteVehi_Click);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EjercicioPOO.Properties.Resources.image_do_fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(655, 511);
            this.Controls.Add(this.btnDeleteVehi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbVehicles);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainform";
            this.Text = "Terminal de Transporte";
            ((System.ComponentModel.ISupportInitialize)(this.numPassanger)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPassanger;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbOmnibus;
        private System.Windows.Forms.ListBox lbVehicles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteVehi;
    }
}

