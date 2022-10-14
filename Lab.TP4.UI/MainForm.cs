using Lab.TP4.Entities;
using Lab.TP4.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab.TP4.UI
{
    public partial class MainForm : Form
    {
        private readonly ILogic<Orders> _ordersLogic = LogicController.GetOrdersLogic();

        public MainForm()
        {
            InitializeComponent();
            RefreshOrdersView();
        }

        public void RefreshOrdersView()
        {
            dgvOrders.DataSource = null;
            dgvOrders.DataSource = _ordersLogic.GetAll();
            dgvOrders.Columns[14].Visible = false;
        }

        private void btnViewOrderDetails_Click(object sender, EventArgs e)
        {
            var detailsView = new OrderDetailsForm();
            detailsView.ShowDialog();
        }
    }
}
