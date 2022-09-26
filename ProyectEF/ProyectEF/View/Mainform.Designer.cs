namespace ProyectEF
{
    partial class Mainform
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnShipper = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::ProyectEF.Properties.Resources.animated_welcome_image_0212;
            this.pictureBox1.Location = new System.Drawing.Point(165, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnShipper
            // 
            this.btnShipper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShipper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShipper.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShipper.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnShipper.Image = global::ProyectEF.Properties.Resources.Aesthetic_Colors_GIF___Aesthetic_Colors_Purple___Discover___Share_GIFs;
            this.btnShipper.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShipper.Location = new System.Drawing.Point(194, 201);
            this.btnShipper.Name = "btnShipper";
            this.btnShipper.Size = new System.Drawing.Size(269, 79);
            this.btnShipper.TabIndex = 1;
            this.btnShipper.Text = "Mostrar Transportistas";
            this.btnShipper.UseVisualStyleBackColor = true;
            this.btnShipper.Click += new System.EventHandler(this.btnShipper_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupplier.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSupplier.Image = global::ProyectEF.Properties.Resources.Aesthetic_Colors_GIF___Aesthetic_Colors_Purple___Discover___Share_GIFs;
            this.btnSupplier.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSupplier.Location = new System.Drawing.Point(194, 344);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(269, 79);
            this.btnSupplier.TabIndex = 2;
            this.btnSupplier.Text = "Mostrar Proveedores";
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectEF.Properties.Resources._218587;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(672, 534);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.btnShipper);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Mainform";
            this.Text = "Ejercio con bases";
            this.Load += new System.EventHandler(this.Mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnShipper;
        private System.Windows.Forms.Button btnSupplier;
    }
}

