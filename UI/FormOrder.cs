using BO;
using DO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FormOrder : Form
    {
        static readonly BlApi.IBI s_bl = BlApi.Factory.Get();
        Order order = new Order();
        double totalPrice = 0;
        private double totalPrices = 0;
        private List<BO.Product> allProducts;
        BO.Product p;
        public FormOrder()
        {
            InitializeComponent();
            InitProductComboBox();

        }
        private void InitProductComboBox()
        {
            allProducts = s_bl.product.ReadAll();
            comboBoxProducts.DataSource = allProducts;
            comboBoxProducts.DisplayMember = "Name";
            comboBoxProducts.ValueMember = "Id";
        }


        private void button_add_Click(object sender, EventArgs e)
        {

            int productId = (int)numericUpDown_add.Value;
            int amount = (int)numericUpDown_amount.Value;
            try
            {
               p = s_bl.product.Read(productId);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (amount == 0)
            {
                MessageBox.Show("Please add quantity");
            }
            if (p == null)
            {
                MessageBox.Show("Code does not exist");
            }
            if (p != null && amount > 0 && productId > 100)
            {
                s_bl.order.AddProductToOrder(order, productId, amount);
                listBox1.Items.Clear();

                foreach (var item in order.ProductsInOrder)
                {
                    string line = $"name: {item.Name}         amount: {item.Amount}         price: {item.Price}         total price: {item.TotalPrice}";
                    if (item.TotalPrice != item.Price * item.Amount)
                        line += $"     sale: - {item.Price * item.Amount - item.TotalPrice}";
                    listBox1.Items.Add(line);
                    totalPrice += item.TotalPrice;
                }
                label_total.Text = "";
                label_total.Text += totalPrice + " ₪";
                totalPrice = 0;
                numericUpDown_add.Value = 1000;
                numericUpDown_amount.Value = 0;

            }
            else
            {
                if (comboBoxProducts.SelectedItem is BO.Product product)
                {
                    try
                    {

                        //s_bl.order.AddProductToOrder(order, product.Id, amount);
                        productId = product.Id;
                    }
                    catch
                    {

                        MessageBox.Show("Code does not exist");
                    }
                }
            }
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_order_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    s_bl.order.DoOrder(order);
                    MessageBox.Show("Your order has been successfully received");
                }
                catch
                {
                    MessageBox.Show("Something went wrong.");
                }
                finally
                {
                    listBox1.Items.Clear();
                    totalPrice = 0;
                    label_total.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}