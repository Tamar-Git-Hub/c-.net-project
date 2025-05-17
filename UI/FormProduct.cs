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
    public partial class FormProduct : Form
    {
        static readonly BlApi.IBI s_bl = BlApi.Factory.Get();
        Product p;
        public FormProduct()
        {
            InitializeComponent();
            panel_add.Visible = false;
            UpdatePanel.Visible = false;
            panel_filter.Visible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = s_bl.product.ReadAll();
            button_all.Visible = false;
            panal_one_product.Visible = false;


        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string code = selectedRow.Cells["Id"].Value.ToString();
                string name = selectedRow.Cells["Name"].Value.ToString();
                double price = Convert.ToDouble(selectedRow.Cells["Price"].Value);
                int amount = Convert.ToInt32(selectedRow.Cells["AmountInStock"].Value);
                Categories category = (Categories)selectedRow.Cells["category"].Value;
                int index = comboBox_category.FindStringExact(category.ToString());
                comboBox_category.SelectedIndex = index;
                p = new Product(int.Parse(code), name, price, amount, category);
                lable.Text = code;
                textBox_name_update.Text = name;
                numericUpDown_price.Value = (decimal)price;
                numericUpDown_amount.Value = amount;
                comboBox_category.SelectedItem = category;
                if (!UpdatePanel.Visible)
                {
                    panal_one_product.Visible = true;
                    Label itemLabel = new Label();
                    itemLabel.Text = $"Code: {p.Id}\n" +
                                     $"Name: {p.Name}\n" +
                                     $"Price: {p.Price}\n" +
                                     $"Amount: {p.AmountInStock}"+
                                     $"Category: {p.category}";

                    itemLabel.AutoSize = true;
                    itemLabel.ForeColor = Color.OrangeRed;
                    panal_one_product.Controls.Add(itemLabel); panal_one_product.Visible = true;
                }

            }
           
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (panel_add.Visible)
            {
                string input = comboBox_category_add.SelectedItem.ToString();
                Categories category = (Categories)Enum.Parse(typeof(Categories), input);
                Product product = new Product(0, textBox_name_add.Text, (double)numericUpDown_price_add.Value, (int)numericUpDown_amount_add.Value, category);
                try
                {
                    s_bl.product.Create(product);
                    dataGridView1.DataSource = s_bl.product.ReadAll();
                } catch
                {
                    MessageBox.Show("Something went wrong. Couldn't create");
                }

                panel_add.Visible = false;
                //panel_show_one.Visible = false;

            }
            else
            {
                panel_add.Visible = true;
                UpdatePanel.Visible = false;
                panel_filter.Visible = false;
                panal_one_product.Visible = false;
            }

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (UpdatePanel.Visible)
            {
                string input = comboBox_category.SelectedItem.ToString();
                Categories category = (Categories)Enum.Parse(typeof(Categories), input);
                Product product = new Product(int.Parse(lable.Text), textBox_name_update.Text, (double)numericUpDown_price.Value, (int)numericUpDown_amount.Value, category);
                try
                {
                    s_bl.product.Update(product);
                    dataGridView1.DataSource = s_bl.product.ReadAll();
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
                panel_add.Visible = false;
                panel_filter.Visible = false;
                panal_one_product.Visible = false;
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            panal_one_product.Visible = false;
            if (p != null)
            {
                try
                {
                    s_bl.product.Delete(p.Id);
                    dataGridView1.DataSource = s_bl.product.ReadAll();
                }
                catch
                {
                    MessageBox.Show("Something went wrong. Couldn't delete");
                }
            }
            else
            {
                MessageBox.Show("please choose a collem");
            }

        }

        private void FilterbyCategory_Click(object sender, EventArgs e)
        {
            panel_add.Visible = false;
            UpdatePanel.Visible = false;

            if (panel_filter.Visible)
            {
                string selectedCategory = "";
                if (radio_milky.Checked)
                    selectedCategory = "milky";
                else if (radio_parve.Checked)
                    selectedCategory = "parve";
                else if (radio_parveDrink.Checked)
                    selectedCategory = "parveDrink";
                else if (radio_milkDrink.Checked)
                    selectedCategory = "milkDrin";
                else
                    selectedCategory = "meaty";

                var products = s_bl.product.ReadAll(p => p.category.ToString().Contains(selectedCategory));
                dataGridView1.DataSource = products.Select(p => new { p.Id, p.Name, p.Price, p.AmountInStock, p.category }).ToList();

                panel_filter.Visible = false;
                button_all.Visible = true;
            }
            else
            {
                panel_filter.Visible = true;
                panal_one_product.Visible = false;

            }

        }

        private void button_all_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = s_bl.product.ReadAll();
            button_all.Visible = false;
            panal_one_product.Visible = false;

        }

        private void numericUpDown_one_ValueChanged(object sender, EventArgs e)
        {

        }

  

        private void cancel_Click(object sender, EventArgs e)
        {
            panal_one_product.Visible = false;
        }
    }
}
