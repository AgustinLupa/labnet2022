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
    public partial class OrderDetailsForm : Form
    {
        private ILogic<Orders> _ordersLogic = LogicController.GetOrdersLogic();
        private ILogic<Order_Details> _orderDetailsLogic = LogicController.GetOrder_DetailsLogic();
        //private ILogic<Products> _productsLogic = LogicController.GetProductsLogic();

        private Orders _selectedOrder;
        public OrderDetailsForm()
        {
            InitializeComponent();
        }

        private void btnSearchOrder_Click(object sender, EventArgs e)
        {
            try
            {
                var orderId = (int)numSearchOrderId.Value;
               /* var order = _ordersLogic.GetById(orderId);
                _selectedOrder = order;*/

                ListOrderItems(orderId);
                gbxSelectedOrder.Enabled = true;
                gbxSelectedOrder.Text = $"Order Number : {orderId}";
            }
            catch (Exception ex)
            {
                lbSearchMessage.Text = ex.Message;
                lbxOrderDetails.DataSource = null;
                timLabelTimer.Start();
                gbxSelectedOrder.Enabled = false;
                gbxSelectedOrder.Text = "";
            }
        }

        private void ListOrderItems(int orderId)
        {
            _ordersLogic = LogicController.GetOrdersLogic();
            _orderDetailsLogic = LogicController.GetOrder_DetailsLogic();
            var order = _ordersLogic.GetById(orderId);
            _selectedOrder = order;
            lbxOrderDetails.DataSource = null;
            lbxOrderDetails.DataSource = _selectedOrder.Order_Details.ToList();
            //lbxOrderDetails.DataBindings.Add("Items", _selectedOrder.Order_Details.ToList(), "");
        }

        private void btnAddEntry_Click(object sender, EventArgs e)
        {
            var itemView = new OrderEntryForm(_selectedOrder.OrderID);
            itemView.ShowDialog();
            //_selectedOrder = _ordersLogic.GetById(_selectedOrder.OrderID);
            ListOrderItems(_selectedOrder.OrderID);
        }

        private void timLabelTimer_Tick(object sender, EventArgs e)
        {
            lbSearchMessage.Text = "";
            timLabelTimer.Stop();
        }

        private void btnDeleteEntry_Click(object sender, EventArgs e)
        {
            if (lbxOrderDetails.SelectedIndex < 0)
            {
                MessageBox.Show("Select a product from the list first", "Error", MessageBoxButtons.OK);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete this item from the Order?",
                "Confirm Delete", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var orderItem = _selectedOrder.Order_Details.ToList()[lbxOrderDetails.SelectedIndex];
                    _orderDetailsLogic.Remove(orderItem);
                    MessageBox.Show("The item has been removed", "Result", MessageBoxButtons.OK);
                    //_selectedOrder = _ordersLogic.GetById(_selectedOrder.OrderID);
                    ListOrderItems(_selectedOrder.OrderID);
                }
                catch (Exception)
                {
                    MessageBox.Show("The item could not be found, operation aborted.", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void btnModifyEntry_Click(object sender, EventArgs e)
        {
            if (lbxOrderDetails.SelectedIndex < 0)
            {
                MessageBox.Show("Select a product from the list first", "Error", MessageBoxButtons.OK);
                return;
            }
            try
            {
                var orderItem = _selectedOrder.Order_Details.ToList()[lbxOrderDetails.SelectedIndex];
                var itemView = new OrderEntryForm(orderItem);
                itemView.ShowDialog();
                //_selectedOrder = _ordersLogic.GetById(_selectedOrder.OrderID);
                ListOrderItems(_selectedOrder.OrderID);
            }
            catch (Exception)
            {
                MessageBox.Show("The item could not be found, operation aborted.", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
