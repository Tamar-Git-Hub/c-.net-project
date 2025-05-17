using BO;
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
    public partial class FormCustomer : Form
    {
        static readonly BlApi.IBI s_bl = BlApi.Factory.Get();
        Customer c;
        public FormCustomer()
        {
            InitializeComponent();
            UpdatePanel.Visible = false;
            AddPanel.Visible = false;
            panal_one_product.Visible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = s_bl.customer.ReadAll();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string id = selectedRow.Cells["Identity"].Value.ToString();
                string name = selectedRow.Cells["Name"].Value.ToString();
                string address = selectedRow.Cells["Address"].Value.ToString();
                string phone = selectedRow.Cells["Phone"].Value.ToString();

                c = new Customer(int.Parse(id), name, address, phone);
                textBox_id.Text = id;
                text_name.Text = name;
                textBox_address.Text = address;
                textBox_phone.Text = phone;
                if (!UpdatePanel.Visible)
                {
                    panal_one_product.Visible = true;
                    Label itemLabel = new Label();
                    itemLabel.Text = $"ID: {c.Identity}\n" +
                                     $"Name: {c.Name}\n" +
                                     $"Addess: {c.Address}\n" +
                                     $"Phone: {c.Phone}";
                    itemLabel.AutoSize = true;
                    itemLabel.ForeColor = Color.OrangeRed;
                    panal_one_product.Controls.Add(itemLabel);
                }

            }
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            if (AddPanel.Visible)
            {

                Customer customer = new Customer(int.Parse(textBox_ID_add.Text), textBox2.Text, textBox_address_add.Text, textBox_phone_add.Text);
                try
                {
                    s_bl.customer.Create(customer);
                    dataGridView1.DataSource = s_bl.customer.ReadAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                AddPanel.Visible = false;

            }
            else
            {
                AddPanel.Visible = true;
                UpdatePanel.Visible = false;
                panal_one_product.Visible = false;
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (UpdatePanel.Visible)
            {
                Customer customer = new Customer(int.Parse(textBox_id.Text), text_name.Text, textBox_address.Text, textBox_phone.Text);
                try
                {
                    s_bl.customer.Update(customer);
                    dataGridView1.DataSource = s_bl.customer.ReadAll();
                }
                catch
                {
                    MessageBox.Show("Something went wrong. Couldn't update");
                }
                UpdatePanel.Visible = false;
            }
            else
            {
                UpdatePanel.Visible = true;
                AddPanel.Visible = false;
                panal_one_product.Visible = false;
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            panal_one_product.Visible = false;
            UpdatePanel.Visible = false;
            AddPanel.Visible = false;
            if (c != null)
            {
                try
                {
                    s_bl.customer.Delete(c.Identity);
                    dataGridView1.DataSource = s_bl.customer.ReadAll();
                }
                catch
                {
                    MessageBox.Show("Something went wrong. Couldn't delete");
                }
            }
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            panal_one_product.Visible = false;
        }


        private void Filter_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = s_bl.customer.ReadAll().Take(10).ToList();
        }

        private void button_all_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = s_bl.customer.ReadAll();
        }
    }
}
