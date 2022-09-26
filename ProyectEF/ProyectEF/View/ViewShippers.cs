using ProyectEF.Exceptions;
using ProyectEF.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectEF.View
{
    public partial class ViewShippers : Form
    {
        ControllerShippers controllerShippers = new ControllerShippers();
        public ViewShippers()
        {            
            InitializeComponent();
            ListRefresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eleminar este elemento", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(controllerShippers.DeleteShippers(lbShippers.SelectedIndex), "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            ListRefresh();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        public void ListRefresh()
        {
            lbShippers.DataSource = null;
            lbShippers.DataSource = controllerShippers.GetShippers();
        }

        private void btnFindShipper_Click(object sender, EventArgs e)
        {
            if (controllerShippers.ExistShipper((int)numId.Value))
            {
                txtCompanyName.Text = controllerShippers.GetShipper((int)numId.Value).CompanyName;
                txtPhone.Text = controllerShippers.GetShipper((int)numId.Value).Phone;
            }
            else
            {
                MessageBox.Show("No se encontro un transportista con ese Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(controllerShippers.AddShippers((int)numId.Value, txtCompanyName.Text, txtPhone.Text));
            ListRefresh();
        }
    }
}
