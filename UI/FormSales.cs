using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FormSales : Form
    {
        static readonly BlApi.IBI s_bl = BlApi.Factory.Get();
        Sale s;
        public FormSales()
        {
            InitializeComponent();
            addPanel.Visible = false;
            updatePanel.Visible = false;
            panal_one_product.Visible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = s_bl.sale.ReadAll();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                int codeIndex = (int)selectedRow.Cells["codeIndex"].Value;
                int id = (int)selectedRow.Cells["ProductId"].Value;
                int minAmount = (int)selectedRow.Cells["MinAmount"].Value;
                double price = Convert.ToDouble(selectedRow.Cells["Price"].Value);
                bool club = (bool)selectedRow.Cells["Club"].Value;
                DateTime startSaleDate = (DateTime)selectedRow.Cells["StartSaleDate"].Value;
                DateTime endSaleDate = (DateTime)selectedRow.Cells["EndSaleDate"].Value;
                s = new Sale(codeIndex, id, minAmount, price, club, startSaleDate, endSaleDate);
                textBox_code_u.Text = codeIndex.ToString();
                textBox_productId_u.Text = id.ToString();
                numericUpDown_minamount_u.Text = minAmount.ToString();
                numericUpDown_price_u.Text = price.ToString();
                checkBox_club_u.Checked = club;
                dateTimePicker_start.Text = startSaleDate.ToString();
                dateTimePicker_end.Text = endSaleDate.ToString();
                if (!updatePanel.Visible)
                {
                    panal_one_product.Visible = true;
                    Label itemLabel = new Label();
                    itemLabel.Text = $"codeIndex: {s.codeIndex}\n" +
                                     $"ProductId: {s.ProductId}\n" +
                                     $"minAmount: {s.MinAmount}\n" +
                                     $"Price: {s.Price}\n" +
                                     $"Club: {s.Club}" +
                                     $"Start Sale: {s.StartSaleDate}"+
                                     $"End Sale: {s.EndSaleDate}"
                                     ;

                    itemLabel.AutoSize = true;
                    itemLabel.ForeColor = Color.OrangeRed;
                    panal_one_product.Controls.Add(itemLabel); panal_one_product.Visible = true;
                }
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (updatePanel.Visible)
            {
                Sale sale = new Sale(int.Parse(textBox_code_u.Text), int.Parse(textBox_productId_u.Text), (int)numericUpDown_minamount_u.Value,
                                  (double)numericUpDown_price_u.Value, checkBox_club_u.Checked, dateTimePicker_start.Value, dateTimePicker_end.Value);
                try
                {
                    s_bl.sale.Update(sale);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                dataGridView1.DataSource = s_bl.sale.ReadAll();
                updatePanel.Visible = false;

            }
            else
            {
                updatePanel.Visible = true;
                addPanel.Visible = false;
                panal_one_product.Visible = false;

            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (addPanel.Visible)
            {
                Sale sale = new Sale(int.Parse(textBox_code.Text), int.Parse(textBox_productID.Text), (int)numericUpDown_min.Value,
                                     (double)numericUpDown_price.Value, checkBox_club.Checked, dateTime_start.Value, dateTime_end.Value);
                try
                {
                    s_bl.sale.Create(sale);
                    dataGridView1.DataSource = s_bl.sale.ReadAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                addPanel.Visible = false;

            }
            else
            {
                addPanel.Visible = true;
                updatePanel.Visible = false;
                panal_one_product.Visible = false;
            }

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            panal_one_product.Visible = false;
            try
            {
                s_bl.sale.Delete(s.codeIndex);
            }
            catch
            {
                MessageBox.Show("Something went wrong. Couldn't delete");
            }
            dataGridView1.DataSource = s_bl.sale.ReadAll();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = comboBox_filter.SelectedItem.ToString();
            if (filter == "with club")
            {
                var sales = s_bl.sale.ReadAll(s => s.Club == true);
                dataGridView1.DataSource = sales.Select(s => new { s.codeIndex, s.ProductId, s.MinAmount, s.Price, s.Club, s.StartSaleDate, s.EndSaleDate }).ToList();
            }
            else if (filter == "without club")
            {
                var sales = s_bl.sale.ReadAll(s => s.Club == false);
                dataGridView1.DataSource = sales.Select(s => new { s.codeIndex, s.ProductId, s.MinAmount, s.Price, s.Club, s.StartSaleDate, s.EndSaleDate }).ToList();
            }
            else
                dataGridView1.DataSource = s_bl.sale.ReadAll();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            panal_one_product.Visible = false;
        }
    }
}
