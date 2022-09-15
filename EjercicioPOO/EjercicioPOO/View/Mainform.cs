using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjercicioPOO.Controller;

namespace EjercicioPOO
{
    public partial class mainform : Form
    {
        ControllerTransport controllerTransport = new ControllerTransport();
        public mainform()
        {
            InitializeComponent();
            ListRefresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rbOmnibus.Checked)
            {
                MessageBox.Show(controllerTransport.AddOmnibus(Convert.ToInt32(numPassanger.Value)));

            }
            else
            {
                MessageBox.Show(controllerTransport.AddTaxi(Convert.ToInt32(numPassanger.Value)));
                
            }
            ListRefresh();
        }

        private void ListRefresh()
        {
            lbVehicles.DataSource = null;
            lbVehicles.DataSource = controllerTransport.PublicTransport();
        }

        private void btnDeleteVehi_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta seguro de eliminar este transporte?", "Elimanar",MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
              MessageBox.Show (controllerTransport.RemoveTransport(lbVehicles.SelectedIndex));
            }
            ListRefresh();
        }
    }
}
