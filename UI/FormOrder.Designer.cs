namespace UI
{
    partial class FormOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
            button_order = new Button();
            button_add = new Button();
            label2 = new Label();
            numericUpDown_amount = new NumericUpDown();
            label1 = new Label();
            numericUpDown_add = new NumericUpDown();
            listBox1 = new ListBox();
            label_total = new Label();
            comboBoxProducts = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_amount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_add).BeginInit();
            SuspendLayout();
            // 
            // button_order
            // 
            button_order.BackColor = SystemColors.ButtonHighlight;
            button_order.BackgroundImage = (Image)resources.GetObject("button_order.BackgroundImage");
            button_order.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_order.ForeColor = Color.Red;
            button_order.Location = new Point(72, 315);
            button_order.Margin = new Padding(3, 4, 3, 4);
            button_order.Name = "button_order";
            button_order.Size = new Size(300, 31);
            button_order.TabIndex = 15;
            button_order.Text = "PLACE AN ORDER";
            button_order.UseVisualStyleBackColor = false;
            button_order.Click += button_order_Click;
            // 
            // button_add
            // 
            button_add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_add.ForeColor = Color.Chocolate;
            button_add.Location = new Point(571, 356);
            button_add.Margin = new Padding(3, 4, 3, 4);
            button_add.Name = "button_add";
            button_add.Size = new Size(167, 31);
            button_add.TabIndex = 14;
            button_add.Text = "ADD TO CART";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(538, 305);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 13;
            label2.Text = "AMOUNT";
            // 
            // numericUpDown_amount
            // 
            numericUpDown_amount.BackColor = SystemColors.InactiveCaptionText;
            numericUpDown_amount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDown_amount.ForeColor = SystemColors.Window;
            numericUpDown_amount.Location = new Point(636, 303);
            numericUpDown_amount.Margin = new Padding(3, 4, 3, 4);
            numericUpDown_amount.Name = "numericUpDown_amount";
            numericUpDown_amount.Size = new Size(142, 27);
            numericUpDown_amount.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(571, 230);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 11;
            label1.Text = "PRODUCT ID";
            // 
            // numericUpDown_add
            // 
            numericUpDown_add.BackColor = SystemColors.WindowText;
            numericUpDown_add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDown_add.ForeColor = SystemColors.Window;
            numericUpDown_add.Location = new Point(641, 254);
            numericUpDown_add.Margin = new Padding(3, 4, 3, 4);
            numericUpDown_add.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown_add.Name = "numericUpDown_add";
            numericUpDown_add.Size = new Size(137, 27);
            numericUpDown_add.TabIndex = 9;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(43, 2);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(745, 224);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label_total
            // 
            label_total.AutoSize = true;
            label_total.Location = new Point(165, 242);
            label_total.Name = "label_total";
            label_total.Size = new Size(0, 20);
            label_total.TabIndex = 16;
            // 
            // comboBoxProducts
            // 
            comboBoxProducts.BackColor = SystemColors.InactiveCaptionText;
            comboBoxProducts.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxProducts.ForeColor = Color.White;
            comboBoxProducts.FormattingEnabled = true;
            comboBoxProducts.Location = new Point(398, 254);
            comboBoxProducts.Name = "comboBoxProducts";
            comboBoxProducts.Size = new Size(217, 28);
            comboBoxProducts.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(62, 242);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 18;
            label3.Text = "total price : ";
            // 
            // FormOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(comboBoxProducts);
            Controls.Add(label_total);
            Controls.Add(button_order);
            Controls.Add(button_add);
            Controls.Add(label2);
            Controls.Add(numericUpDown_amount);
            Controls.Add(label1);
            Controls.Add(numericUpDown_add);
            Controls.Add(listBox1);
            Name = "FormOrder";
            Text = "Order";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_amount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_add).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_order;
        private Button button_add;
        private Label label2;
        private NumericUpDown numericUpDown_amount;
        private Label label1;
        private NumericUpDown numericUpDown_add;
        private ListBox listBox1;
        private Label label_total;
        private ComboBox comboBoxProducts;
        private Label label3;
    }
}