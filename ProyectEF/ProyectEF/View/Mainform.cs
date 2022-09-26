using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectEF.Logic;
using ProyectEF.View;

namespace ProyectEF
{
    public partial class Mainform : Form
    {

        public Mainform()
        {            
            InitializeComponent();
        }
     
        private void Mainform_Load(object sender, EventArgs e)
        {

        }

        private void btnShipper_Click(object sender, EventArgs e)
        {
            ViewShippers viewShippers = new ViewShippers();
            viewShippers.Owner = this;
            viewShippers.Show();
            this.Hide();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            ViewSuppliers viewSuppliers = new ViewSuppliers();
            viewSuppliers.Owner = this;
            viewSuppliers.Show();
            this.Hide();
        }
    }
}
