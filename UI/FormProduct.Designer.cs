namespace UI
{
    partial class FormProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduct));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            button_delete = new Button();
            button_update = new Button();
            button_add = new Button();
            dataGridView1 = new DataGridView();
            panel_add = new Panel();
            label3 = new Label();
            label1 = new Label();
            label6 = new Label();
            label11 = new Label();
            textBox_name_add = new TextBox();
            numericUpDown_amount_add = new NumericUpDown();
            comboBox_category_add = new ComboBox();
            numericUpDown_price_add = new NumericUpDown();
            UpdatePanel = new Panel();
            lable = new Label();
            label12 = new Label();
            label13 = new Label();
            comboBox_category = new ComboBox();
            numericUpDown_amount = new NumericUpDown();
            numericUpDown_price = new NumericUpDown();
            textBox_name_update = new TextBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            panel_filter = new Panel();
            radio_parveDrink = new RadioButton();
            radio_milkDrink = new RadioButton();
            radio_meaty = new RadioButton();
            radio_parve = new RadioButton();
            radio_milky = new RadioButton();
            FilterbyCategory = new Button();
            button_all = new Button();
            panal_one_product = new Panel();
            cancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel_add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_amount_add).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_price_add).BeginInit();
            UpdatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_amount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_price).BeginInit();
            panel_filter.SuspendLayout();
            panal_one_product.SuspendLayout();
            SuspendLayout();
            // 
            // button_delete
            // 
            button_delete.BackgroundImage = (Image)resources.GetObject("button_delete.BackgroundImage");
            button_delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_delete.ForeColor = Color.Brown;
            button_delete.Location = new Point(674, 99);
            button_delete.Margin = new Padding(3, 4, 3, 4);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(114, 40);
            button_delete.TabIndex = 18;
            button_delete.Text = "DELETE";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // button_update
            // 
            button_update.BackgroundImage = (Image)resources.GetObject("button_update.BackgroundImage");
            button_update.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_update.ForeColor = Color.Chocolate;
            button_update.Location = new Point(674, 51);
            button_update.Margin = new Padding(3, 4, 3, 4);
            button_update.Name = "button_update";
            button_update.Size = new Size(114, 40);
            button_update.TabIndex = 17;
            button_update.Text = "UPDATE";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += button_update_Click;
            // 
            // button_add
            // 
            button_add.BackColor = SystemColors.ControlDark;
            button_add.BackgroundImage = (Image)resources.GetObject("button_add.BackgroundImage");
            button_add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_add.ForeColor = Color.Coral;
            button_add.Location = new Point(674, 5);
            button_add.Margin = new Padding(3, 4, 3, 4);
            button_add.Name = "button_add";
            button_add.Size = new Size(114, 40);
            button_add.TabIndex = 16;
            button_add.Text = "ADD";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 11);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(572, 209);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel_add
            // 
            panel_add.BackColor = Color.Transparent;
            panel_add.Controls.Add(label3);
            panel_add.Controls.Add(label1);
            panel_add.Controls.Add(label6);
            panel_add.Controls.Add(label11);
            panel_add.Controls.Add(textBox_name_add);
            panel_add.Controls.Add(numericUpDown_amount_add);
            panel_add.Controls.Add(comboBox_category_add);
            panel_add.Controls.Add(numericUpDown_price_add);
            panel_add.Location = new Point(9, 338);
            panel_add.Name = "panel_add";
            panel_add.Size = new Size(747, 94);
            panel_add.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(557, 20);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 49;
            label3.Text = "name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Chocolate;
            label1.Location = new Point(228, 20);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 48;
            label1.Text = "price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Coral;
            label6.Location = new Point(29, 20);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 47;
            label6.Text = "amount in stock";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DarkSalmon;
            label11.Location = new Point(394, 20);
            label11.Name = "label11";
            label11.Size = new Size(70, 20);
            label11.TabIndex = 46;
            label11.Text = "categoty";
            // 
            // textBox_name_add
            // 
            textBox_name_add.BackColor = SystemColors.MenuText;
            textBox_name_add.ForeColor = SystemColors.Window;
            textBox_name_add.Location = new Point(522, 62);
            textBox_name_add.Name = "textBox_name_add";
            textBox_name_add.Size = new Size(114, 27);
            textBox_name_add.TabIndex = 29;
            // 
            // numericUpDown_amount_add
            // 
            numericUpDown_amount_add.BackColor = Color.Black;
            numericUpDown_amount_add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDown_amount_add.ForeColor = SystemColors.ControlLightLight;
            numericUpDown_amount_add.Location = new Point(26, 60);
            numericUpDown_amount_add.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDown_amount_add.Name = "numericUpDown_amount_add";
            numericUpDown_amount_add.Size = new Size(150, 27);
            numericUpDown_amount_add.TabIndex = 28;
            // 
            // comboBox_category_add
            // 
            comboBox_category_add.BackColor = SystemColors.MenuText;
            comboBox_category_add.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_category_add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox_category_add.ForeColor = SystemColors.Window;
            comboBox_category_add.FormattingEnabled = true;
            comboBox_category_add.Items.AddRange(new object[] { "milky", "parve", "meaty", "milkDrink", "parveDrink" });
            comboBox_category_add.Location = new Point(354, 61);
            comboBox_category_add.Name = "comboBox_category_add";
            comboBox_category_add.Size = new Size(151, 28);
            comboBox_category_add.TabIndex = 19;
            // 
            // numericUpDown_price_add
            // 
            numericUpDown_price_add.BackColor = SystemColors.InactiveCaptionText;
            numericUpDown_price_add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDown_price_add.ForeColor = SystemColors.Window;
            numericUpDown_price_add.Location = new Point(192, 60);
            numericUpDown_price_add.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown_price_add.Name = "numericUpDown_price_add";
            numericUpDown_price_add.Size = new Size(150, 27);
            numericUpDown_price_add.TabIndex = 17;
            // 
            // UpdatePanel
            // 
            UpdatePanel.AllowDrop = true;
            UpdatePanel.BackColor = Color.Transparent;
            UpdatePanel.Controls.Add(lable);
            UpdatePanel.Controls.Add(label12);
            UpdatePanel.Controls.Add(label13);
            UpdatePanel.Controls.Add(comboBox_category);
            UpdatePanel.Controls.Add(numericUpDown_amount);
            UpdatePanel.Controls.Add(numericUpDown_price);
            UpdatePanel.Controls.Add(textBox_name_update);
            UpdatePanel.Controls.Add(label16);
            UpdatePanel.Controls.Add(label17);
            UpdatePanel.Controls.Add(label18);
            UpdatePanel.Controls.Add(label19);
            UpdatePanel.Controls.Add(label20);
            UpdatePanel.Location = new Point(9, 328);
            UpdatePanel.Name = "UpdatePanel";
            UpdatePanel.Size = new Size(750, 110);
            UpdatePanel.TabIndex = 30;
            // 
            // lable
            // 
            lable.AutoSize = true;
            lable.BackColor = Color.Black;
            lable.ForeColor = SystemColors.HighlightText;
            lable.Location = new Point(665, 67);
            lable.Name = "lable";
            lable.Size = new Size(0, 20);
            lable.TabIndex = 49;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Chocolate;
            label12.Location = new Point(221, 22);
            label12.Name = "label12";
            label12.Size = new Size(43, 20);
            label12.TabIndex = 43;
            label12.Text = "price";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Coral;
            label13.Location = new Point(27, 22);
            label13.Name = "label13";
            label13.Size = new Size(122, 20);
            label13.TabIndex = 42;
            label13.Text = "amount in stock";
            // 
            // comboBox_category
            // 
            comboBox_category.BackColor = Color.Black;
            comboBox_category.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_category.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox_category.ForeColor = Color.White;
            comboBox_category.FormattingEnabled = true;
            comboBox_category.Items.AddRange(new object[] { "milky", "parve", "meaty", "milkDrink", "parveDrink" });
            comboBox_category.Location = new Point(351, 63);
            comboBox_category.Name = "comboBox_category";
            comboBox_category.Size = new Size(151, 28);
            comboBox_category.TabIndex = 39;
            // 
            // numericUpDown_amount
            // 
            numericUpDown_amount.BackColor = SystemColors.WindowText;
            numericUpDown_amount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDown_amount.ForeColor = SystemColors.Window;
            numericUpDown_amount.Location = new Point(11, 63);
            numericUpDown_amount.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDown_amount.Name = "numericUpDown_amount";
            numericUpDown_amount.Size = new Size(150, 27);
            numericUpDown_amount.TabIndex = 38;
            // 
            // numericUpDown_price
            // 
            numericUpDown_price.BackColor = SystemColors.WindowText;
            numericUpDown_price.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDown_price.ForeColor = SystemColors.InactiveBorder;
            numericUpDown_price.Location = new Point(173, 64);
            numericUpDown_price.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown_price.Name = "numericUpDown_price";
            numericUpDown_price.Size = new Size(150, 27);
            numericUpDown_price.TabIndex = 37;
            // 
            // textBox_name_update
            // 
            textBox_name_update.BackColor = SystemColors.WindowText;
            textBox_name_update.ForeColor = Color.White;
            textBox_name_update.Location = new Point(511, 64);
            textBox_name_update.Name = "textBox_name_update";
            textBox_name_update.Size = new Size(125, 27);
            textBox_name_update.TabIndex = 36;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.DarkSalmon;
            label16.Location = new Point(387, 21);
            label16.Name = "label16";
            label16.Size = new Size(70, 20);
            label16.TabIndex = 35;
            label16.Text = "categoty";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(219, 21);
            label17.Name = "label17";
            label17.Size = new Size(42, 20);
            label17.TabIndex = 34;
            label17.Text = "price";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(25, 21);
            label18.Name = "label18";
            label18.Size = new Size(114, 20);
            label18.TabIndex = 33;
            label18.Text = "amount in stock";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.DarkRed;
            label19.Location = new Point(538, 22);
            label19.Name = "label19";
            label19.Size = new Size(48, 20);
            label19.TabIndex = 32;
            label19.Text = "name";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.Red;
            label20.Location = new Point(649, 22);
            label20.Name = "label20";
            label20.Size = new Size(42, 20);
            label20.TabIndex = 31;
            label20.Text = "code";
            // 
            // panel_filter
            // 
            panel_filter.BackColor = Color.Transparent;
            panel_filter.Controls.Add(radio_parveDrink);
            panel_filter.Controls.Add(radio_milkDrink);
            panel_filter.Controls.Add(radio_meaty);
            panel_filter.Controls.Add(radio_parve);
            panel_filter.Controls.Add(radio_milky);
            panel_filter.Location = new Point(403, 226);
            panel_filter.Name = "panel_filter";
            panel_filter.Size = new Size(156, 128);
            panel_filter.TabIndex = 50;
            // 
            // radio_parveDrink
            // 
            radio_parveDrink.AutoSize = true;
            radio_parveDrink.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radio_parveDrink.ForeColor = Color.Red;
            radio_parveDrink.Location = new Point(11, 100);
            radio_parveDrink.Name = "radio_parveDrink";
            radio_parveDrink.Size = new Size(110, 24);
            radio_parveDrink.TabIndex = 15;
            radio_parveDrink.TabStop = true;
            radio_parveDrink.Text = "parve drink";
            radio_parveDrink.UseVisualStyleBackColor = true;
            // 
            // radio_milkDrink
            // 
            radio_milkDrink.AutoSize = true;
            radio_milkDrink.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radio_milkDrink.ForeColor = Color.DarkSalmon;
            radio_milkDrink.Location = new Point(11, 78);
            radio_milkDrink.Name = "radio_milkDrink";
            radio_milkDrink.Size = new Size(100, 24);
            radio_milkDrink.TabIndex = 14;
            radio_milkDrink.TabStop = true;
            radio_milkDrink.Text = "milk drink";
            radio_milkDrink.UseVisualStyleBackColor = true;
            // 
            // radio_meaty
            // 
            radio_meaty.AutoSize = true;
            radio_meaty.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radio_meaty.ForeColor = Color.Brown;
            radio_meaty.Location = new Point(11, 54);
            radio_meaty.Name = "radio_meaty";
            radio_meaty.Size = new Size(74, 24);
            radio_meaty.TabIndex = 13;
            radio_meaty.TabStop = true;
            radio_meaty.Text = "meaty";
            radio_meaty.UseVisualStyleBackColor = true;
            // 
            // radio_parve
            // 
            radio_parve.AutoSize = true;
            radio_parve.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radio_parve.ForeColor = Color.Chocolate;
            radio_parve.Location = new Point(11, 28);
            radio_parve.Name = "radio_parve";
            radio_parve.Size = new Size(70, 24);
            radio_parve.TabIndex = 12;
            radio_parve.TabStop = true;
            radio_parve.Text = "parve";
            radio_parve.UseVisualStyleBackColor = true;
            // 
            // radio_milky
            // 
            radio_milky.AutoSize = true;
            radio_milky.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radio_milky.ForeColor = Color.Coral;
            radio_milky.Location = new Point(11, 3);
            radio_milky.Name = "radio_milky";
            radio_milky.Size = new Size(68, 24);
            radio_milky.TabIndex = 11;
            radio_milky.TabStop = true;
            radio_milky.Text = "milky";
            radio_milky.UseVisualStyleBackColor = true;
            // 
            // FilterbyCategory
            // 
            FilterbyCategory.BackColor = SystemColors.ControlDarkDark;
            FilterbyCategory.BackgroundImage = (Image)resources.GetObject("FilterbyCategory.BackgroundImage");
            FilterbyCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FilterbyCategory.ForeColor = Color.DarkSalmon;
            FilterbyCategory.ImageAlign = ContentAlignment.MiddleRight;
            FilterbyCategory.Location = new Point(677, 142);
            FilterbyCategory.Name = "FilterbyCategory";
            FilterbyCategory.Size = new Size(114, 40);
            FilterbyCategory.TabIndex = 19;
            FilterbyCategory.Text = "FILTER ";
            FilterbyCategory.UseVisualStyleBackColor = false;
            FilterbyCategory.Click += FilterbyCategory_Click;
            // 
            // button_all
            // 
            button_all.BackgroundImage = (Image)resources.GetObject("button_all.BackgroundImage");
            button_all.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_all.ForeColor = Color.DarkSalmon;
            button_all.Location = new Point(608, 144);
            button_all.Name = "button_all";
            button_all.Size = new Size(57, 38);
            button_all.TabIndex = 51;
            button_all.Text = "ALL";
            button_all.UseVisualStyleBackColor = true;
            button_all.Click += button_all_Click;
            // 
            // panal_one_product
            // 
            panal_one_product.BackColor = Color.Snow;
            panal_one_product.Controls.Add(cancel);
            panal_one_product.Location = new Point(625, 188);
            panal_one_product.Name = "panal_one_product";
            panal_one_product.Size = new Size(166, 160);
            panal_one_product.TabIndex = 57;
            // 
            // cancel
            // 
            cancel.BackgroundImage = (Image)resources.GetObject("cancel.BackgroundImage");
            cancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancel.ForeColor = SystemColors.ActiveCaptionText;
            cancel.Location = new Point(3, 128);
            cancel.Name = "cancel";
            cancel.Size = new Size(94, 29);
            cancel.TabIndex = 0;
            cancel.Text = "cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(panal_one_product);
            Controls.Add(button_all);
            Controls.Add(panel_filter);
            Controls.Add(FilterbyCategory);
            Controls.Add(UpdatePanel);
            Controls.Add(panel_add);
            Controls.Add(button_delete);
            Controls.Add(button_update);
            Controls.Add(button_add);
            Controls.Add(dataGridView1);
            Name = "FormProduct";
            Text = "FormProduct";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel_add.ResumeLayout(false);
            panel_add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_amount_add).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_price_add).EndInit();
            UpdatePanel.ResumeLayout(false);
            UpdatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_amount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_price).EndInit();
            panel_filter.ResumeLayout(false);
            panel_filter.PerformLayout();
            panal_one_product.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button button_delete;
        private Button button_update;
        private Button button_add;
        private DataGridView dataGridView1;
        private ComboBox comboBox_category_add;
        private NumericUpDown numericUpDown_amount_add;
        private NumericUpDown numericUpDown_price_add;
        private Panel panel_add;
        private TextBox textBox_name_update;
        private TextBox textBox_name;
        private Panel UpdatePanel;
        private Label lable;
        private TextBox textBox3;
        private Label label12;
        private Label label13;
        private ComboBox comboBox_category;
        private NumericUpDown numericUpDown_amount;
        private NumericUpDown numericUpDown_price;
        //private TextBox textBox_name;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private TextBox textBox_name_add;
        private Button FilterbyCategory;
        private Panel panel_filter;
        private RadioButton radio_parve;
        private RadioButton radio_milky;
        private RadioButton radio_parveDrink;
        private RadioButton radio_milkDrink;
        private RadioButton radio_meaty;
        private Button button_all;
        private Button button_show_one;
        private NumericUpDown numericUpDown_one;
        private Label label3;
        private Label label1;
        private Label label6;
        private Label label11;
        private Panel panal_one_product;
        private Button cancel;
    }
}