using ProyectEF.Entities;
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

namespace ProyectEF
{
    public partial class ViewSuppliers : Form
    {
        ControllerSuppliers controllerSupliers = new ControllerSuppliers();
        public ViewSuppliers()
        {            
            InitializeComponent();
            ListRefresh();
        }

        private void ViewSuppliers_Load(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eleminar este elemento", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(controllerSupliers.DeleteShippers(lbSuppliers.SelectedIndex), "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            ListRefresh();
        }

        public void ListRefresh()
        {
            lbSuppliers.DataSource = null;
            lbSuppliers.DataSource = controllerSupliers.GetSupliers();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (controllerSupliers.ExistSupplier((int)numId.Value))
            {
                txtCompanyName.Text = controllerSupliers.GetSupplier((int)numId.Value).CompanyName;
                txtPhone.Text = controllerSupliers.GetSupplier((int)numId.Value).Phone;
                txtAddress.Text = controllerSupliers.GetSupplier((int)numId.Value).Address;
                txtCity.Text = controllerSupliers.GetSupplier((int)numId.Value).City;
                txtCodePostal.Text = controllerSupliers.GetSupplier((int)numId.Value).PostalCode;
                txtContactName.Text = controllerSupliers.GetSupplier((int)numId.Value).ContactName;
                txtContactTitle.Text = controllerSupliers.GetSupplier((int)numId.Value).ContactTitle;   
                txtCountry.Text = controllerSupliers.GetSupplier((int)numId.Value).Country;
                txtFax.Text = controllerSupliers.GetSupplier((int)numId.Value).Fax;
                txtHomePage.Text = controllerSupliers.GetSupplier((int)numId.Value).HomePage;
                txtRegion.Text = controllerSupliers.GetSupplier((int)numId.Value).Region;
            }
            else
            {
                MessageBox.Show("No se encontro un proveedor con ese Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(controllerSupliers.AddSuppliers((int)numId.Value, txtCompanyName.Text,
                txtPhone.Text, txtCountry.Text, txtCity.Text, txtAddress.Text, txtHomePage.Text,
                txtContactName.Text, txtContactTitle.Text, txtFax.Text, txtCodePostal.Text));
                ListRefresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ocurrio un error {ex.Message}", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
