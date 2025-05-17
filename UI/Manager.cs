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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void button_customers_Click(object sender, EventArgs e)
        {
            FormCustomer customer = new FormCustomer();
            this.Hide();
            customer.FormClosed += Customer_FormClosed;
            customer.Show();
        }

        private void Customer_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void button_product_Click(object sender, EventArgs e)
        {
            FormProduct product = new FormProduct();
            this.Hide();
            product.FormClosed += Product_FormClosed;
            product.Show();
        }

        private void Product_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void button_sales_Click(object sender, EventArgs e)
        {
            FormSales formSales = new FormSales();
            this.Hide();
            formSales.FormClosed += FormSales_FormClosed;
            formSales.Show();
        }

        private void FormSales_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
