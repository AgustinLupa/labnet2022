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
    public partial class OrderEntryForm : Form
    {
        private ILogic<Order_Details> _orderDetailsLogic = LogicController.GetOrder_DetailsLogic();
        private ILogic<Products> _productsLogic = LogicController.GetProductsLogic();
        private Order_Details _selectedItem;
        private int _orderId;

        public OrderEntryForm(int orderId)
        {
            InitializeComponent();
            LoadProducts();
            _orderId = orderId;
            Text = "New Order Entry";

            cbxSelectProduct.Enabled = true;
            gbxOrderEntryDetails.Enabled = false;
            btnAddNewEntry.Visible = true;
            btnModifyEntry.Visible = false;
        }

        public OrderEntryForm(Order_Details order_Details)
        {
            InitializeComponent();
            LoadProducts();
            Text = "Modify Order Entry";

            _selectedItem = order_Details;
            cbxSelectProduct.Text = _selectedItem.Products.ProductName;
            cbxSelectProduct.Enabled = false;
            numProductID.Value = _selectedItem.ProductID;
            numUnitPrice.Value = _selectedItem.UnitPrice;
            numQuantity.Value = _selectedItem.Quantity;
            numDiscount.Value = (decimal) _selectedItem.Discount;
            btnAddNewEntry.Visible = false;
            btnModifyEntry.Visible = true;
        }

        private void LoadProducts()
        {
            cbxSelectProduct.DataSource = null;
            cbxSelectProduct.DataSource = _productsLogic.GetAll();
            cbxSelectProduct.DisplayMember = "ProductName";
        }

        private void btnModifyEntry_Click(object sender, EventArgs e)
        {
            _selectedItem.UnitPrice = numUnitPrice.Value;
            _selectedItem.Quantity = (short) numQuantity.Value;
            _selectedItem.Discount = (float)numDiscount.Value;
            try
            {
                _orderDetailsLogic.Update(_selectedItem);
                MessageBox.Show("Order item successfully modified.", "Result", MessageBoxButtons.OK);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred.\n" + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void cbxSelectProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSelectProduct.SelectedIndex >= 0)
            {
                gbxOrderEntryDetails.Enabled = true;
                var selectedProduct = _productsLogic.GetAll().FirstOrDefault(p => p.ProductName == cbxSelectProduct.Text);
                if (selectedProduct != null)
                {
                    numProductID.Value = selectedProduct.ProductID;
                    numUnitPrice.Value = selectedProduct.UnitPrice;
                }
                return;
            }
            gbxOrderEntryDetails.Enabled = false;
        }

        private void btnAddNewEntry_Click(object sender, EventArgs e)
        {
            var orderItem = new Order_Details()
            {
                OrderID = _orderId,
                ProductID = (int) numProductID.Value,
                UnitPrice = numUnitPrice.Value,
                Quantity = (short)numQuantity.Value,
                Discount = (float)numDiscount.Value
            };
            try
            {
                _orderDetailsLogic.Add(orderItem);
                MessageBox.Show("Item added successfully", "Result", MessageBoxButtons.OK);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
