namespace UI
{
    partial class FormSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSales));
            button_delete = new Button();
            button_update = new Button();
            button_add = new Button();
            dataGridView1 = new DataGridView();
            addPanel = new Panel();
            dateTime_end = new DateTimePicker();
            dateTime_start = new DateTimePicker();
            checkBox_club = new CheckBox();
            numericUpDown_price = new NumericUpDown();
            numericUpDown_min = new NumericUpDown();
            textBox_productID = new TextBox();
            textBox_code = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            updatePanel = new Panel();
            label8 = new Label();
            label10 = new Label();
            label9 = new Label();
            dateTimePicker_end = new DateTimePicker();
            label11 = new Label();
            dateTimePicker_start = new DateTimePicker();
            label12 = new Label();
            checkBox_club_u = new CheckBox();
            label13 = new Label();
            numericUpDown_price_u = new NumericUpDown();
            label14 = new Label();
            numericUpDown_minamount_u = new NumericUpDown();
            textBox_productId_u = new TextBox();
            textBox_code_u = new TextBox();
            comboBox_filter = new ComboBox();
            label15 = new Label();
            panal_one_product = new Panel();
            cancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            addPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_price).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_min).BeginInit();
            updatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_price_u).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_minamount_u).BeginInit();
            panal_one_product.SuspendLayout();
            SuspendLayout();
            // 
            // button_delete
            // 
            button_delete.BackgroundImage = (Image)resources.GetObject("button_delete.BackgroundImage");
            button_delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_delete.ForeColor = Color.Brown;
            button_delete.Location = new Point(674, 109);
            button_delete.Margin = new Padding(3, 4, 3, 4);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(114, 40);
            button_delete.TabIndex = 32;
            button_delete.Text = "DELETE";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // button_update
            // 
            button_update.BackgroundImage = (Image)resources.GetObject("button_update.BackgroundImage");
            button_update.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_update.ForeColor = Color.Chocolate;
            button_update.Location = new Point(674, 61);
            button_update.Margin = new Padding(3, 4, 3, 4);
            button_update.Name = "button_update";
            button_update.Size = new Size(114, 40);
            button_update.TabIndex = 31;
            button_update.Text = "UPDATE";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += button_update_Click;
            // 
            // button_add
            // 
            button_add.BackColor = Color.CornflowerBlue;
            button_add.BackgroundImage = (Image)resources.GetObject("button_add.BackgroundImage");
            button_add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_add.ForeColor = Color.Coral;
            button_add.Location = new Point(674, 13);
            button_add.Margin = new Padding(3, 4, 3, 4);
            button_add.Name = "button_add";
            button_add.Size = new Size(114, 40);
            button_add.TabIndex = 30;
            button_add.Text = "ADD";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(573, 223);
            dataGridView1.TabIndex = 29;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // addPanel
            // 
            addPanel.BackColor = Color.Transparent;
            addPanel.Controls.Add(dateTime_end);
            addPanel.Controls.Add(dateTime_start);
            addPanel.Controls.Add(checkBox_club);
            addPanel.Controls.Add(numericUpDown_price);
            addPanel.Controls.Add(numericUpDown_min);
            addPanel.Controls.Add(textBox_productID);
            addPanel.Controls.Add(textBox_code);
            addPanel.Controls.Add(label7);
            addPanel.Controls.Add(label6);
            addPanel.Controls.Add(label5);
            addPanel.Controls.Add(label4);
            addPanel.Controls.Add(label3);
            addPanel.Controls.Add(label2);
            addPanel.Controls.Add(label1);
            addPanel.Location = new Point(12, 251);
            addPanel.Name = "addPanel";
            addPanel.Size = new Size(733, 157);
            addPanel.TabIndex = 33;
            // 
            // dateTime_end
            // 
            dateTime_end.Location = new Point(337, 128);
            dateTime_end.Name = "dateTime_end";
            dateTime_end.Size = new Size(250, 27);
            dateTime_end.TabIndex = 13;
            // 
            // dateTime_start
            // 
            dateTime_start.Location = new Point(37, 124);
            dateTime_start.Name = "dateTime_start";
            dateTime_start.Size = new Size(226, 27);
            dateTime_start.TabIndex = 12;
            // 
            // checkBox_club
            // 
            checkBox_club.AutoSize = true;
            checkBox_club.BackColor = SystemColors.ControlLightLight;
            checkBox_club.Location = new Point(569, 54);
            checkBox_club.Name = "checkBox_club";
            checkBox_club.Size = new Size(18, 17);
            checkBox_club.TabIndex = 11;
            checkBox_club.UseVisualStyleBackColor = false;
            // 
            // numericUpDown_price
            // 
            numericUpDown_price.BackColor = SystemColors.WindowText;
            numericUpDown_price.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDown_price.ForeColor = SystemColors.Window;
            numericUpDown_price.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown_price.Location = new Point(429, 54);
            numericUpDown_price.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDown_price.Name = "numericUpDown_price";
            numericUpDown_price.Size = new Size(98, 27);
            numericUpDown_price.TabIndex = 10;
            // 
            // numericUpDown_min
            // 
            numericUpDown_min.BackColor = SystemColors.WindowText;
            numericUpDown_min.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDown_min.ForeColor = SystemColors.Window;
            numericUpDown_min.Location = new Point(274, 54);
            numericUpDown_min.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown_min.Name = "numericUpDown_min";
            numericUpDown_min.Size = new Size(106, 27);
            numericUpDown_min.TabIndex = 9;
            // 
            // textBox_productID
            // 
            textBox_productID.BackColor = SystemColors.WindowText;
            textBox_productID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_productID.ForeColor = SystemColors.Window;
            textBox_productID.Location = new Point(148, 54);
            textBox_productID.Name = "textBox_productID";
            textBox_productID.Size = new Size(91, 27);
            textBox_productID.TabIndex = 8;
            // 
            // textBox_code
            // 
            textBox_code.BackColor = SystemColors.WindowText;
            textBox_code.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_code.ForeColor = SystemColors.Window;
            textBox_code.Location = new Point(21, 54);
            textBox_code.Name = "textBox_code";
            textBox_code.Size = new Size(91, 27);
            textBox_code.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.OrangeRed;
            label7.Location = new Point(374, 101);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 6;
            label7.Text = "End Sale At";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Tomato;
            label6.Location = new Point(75, 101);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 5;
            label6.Text = "Start Sale At";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(569, 18);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 4;
            label5.Text = "club";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(442, 18);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 3;
            label4.Text = "price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSalmon;
            label3.Location = new Point(274, 18);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 2;
            label3.Text = "min amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Chocolate;
            label2.Location = new Point(162, 18);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 1;
            label2.Text = "product ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Snow;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(37, 18);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "code";
            // 
            // updatePanel
            // 
            updatePanel.BackColor = Color.Transparent;
            updatePanel.Controls.Add(label8);
            updatePanel.Controls.Add(label10);
            updatePanel.Controls.Add(label9);
            updatePanel.Controls.Add(dateTimePicker_end);
            updatePanel.Controls.Add(label11);
            updatePanel.Controls.Add(dateTimePicker_start);
            updatePanel.Controls.Add(label12);
            updatePanel.Controls.Add(checkBox_club_u);
            updatePanel.Controls.Add(label13);
            updatePanel.Controls.Add(numericUpDown_price_u);
            updatePanel.Controls.Add(label14);
            updatePanel.Controls.Add(numericUpDown_minamount_u);
            updatePanel.Controls.Add(textBox_productId_u);
            updatePanel.Controls.Add(textBox_code_u);
            updatePanel.Location = new Point(9, 251);
            updatePanel.Name = "updatePanel";
            updatePanel.Size = new Size(733, 157);
            updatePanel.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.OrangeRed;
            label8.Location = new Point(399, 100);
            label8.Name = "label8";
            label8.Size = new Size(88, 20);
            label8.TabIndex = 38;
            label8.Text = "End Sale At";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(553, 21);
            label10.Name = "label10";
            label10.Size = new Size(38, 20);
            label10.TabIndex = 41;
            label10.Text = "club";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Tomato;
            label9.Location = new Point(100, 100);
            label9.Name = "label9";
            label9.Size = new Size(96, 20);
            label9.TabIndex = 37;
            label9.Text = "Start Sale At";
            // 
            // dateTimePicker_end
            // 
            dateTimePicker_end.Location = new Point(337, 128);
            dateTimePicker_end.Name = "dateTimePicker_end";
            dateTimePicker_end.Size = new Size(250, 27);
            dateTimePicker_end.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DarkRed;
            label11.Location = new Point(442, 21);
            label11.Name = "label11";
            label11.Size = new Size(43, 20);
            label11.TabIndex = 40;
            label11.Text = "price";
            // 
            // dateTimePicker_start
            // 
            dateTimePicker_start.Location = new Point(58, 127);
            dateTimePicker_start.Name = "dateTimePicker_start";
            dateTimePicker_start.Size = new Size(226, 27);
            dateTimePicker_start.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.DarkSalmon;
            label12.Location = new Point(274, 21);
            label12.Name = "label12";
            label12.Size = new Size(95, 20);
            label12.TabIndex = 39;
            label12.Text = "min amount";
            // 
            // checkBox_club_u
            // 
            checkBox_club_u.AutoSize = true;
            checkBox_club_u.Location = new Point(569, 54);
            checkBox_club_u.Name = "checkBox_club_u";
            checkBox_club_u.Size = new Size(18, 17);
            checkBox_club_u.TabIndex = 11;
            checkBox_club_u.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Chocolate;
            label13.Location = new Point(146, 21);
            label13.Name = "label13";
            label13.Size = new Size(84, 20);
            label13.TabIndex = 38;
            label13.Text = "product ID";
            // 
            // numericUpDown_price_u
            // 
            numericUpDown_price_u.BackColor = SystemColors.WindowText;
            numericUpDown_price_u.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDown_price_u.ForeColor = SystemColors.Window;
            numericUpDown_price_u.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown_price_u.Location = new Point(429, 54);
            numericUpDown_price_u.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDown_price_u.Name = "numericUpDown_price_u";
            numericUpDown_price_u.Size = new Size(98, 27);
            numericUpDown_price_u.TabIndex = 10;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Snow;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Coral;
            label14.Location = new Point(37, 21);
            label14.Name = "label14";
            label14.Size = new Size(42, 20);
            label14.TabIndex = 37;
            label14.Text = "code";
            label14.Click += label14_Click;
            // 
            // numericUpDown_minamount_u
            // 
            numericUpDown_minamount_u.BackColor = SystemColors.WindowText;
            numericUpDown_minamount_u.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDown_minamount_u.ForeColor = SystemColors.Window;
            numericUpDown_minamount_u.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown_minamount_u.Location = new Point(274, 54);
            numericUpDown_minamount_u.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown_minamount_u.Name = "numericUpDown_minamount_u";
            numericUpDown_minamount_u.Size = new Size(106, 27);
            numericUpDown_minamount_u.TabIndex = 9;
            // 
            // textBox_productId_u
            // 
            textBox_productId_u.BackColor = SystemColors.WindowText;
            textBox_productId_u.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_productId_u.ForeColor = SystemColors.Window;
            textBox_productId_u.Location = new Point(148, 54);
            textBox_productId_u.Name = "textBox_productId_u";
            textBox_productId_u.Size = new Size(91, 27);
            textBox_productId_u.TabIndex = 8;
            // 
            // textBox_code_u
            // 
            textBox_code_u.BackColor = SystemColors.WindowText;
            textBox_code_u.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_code_u.ForeColor = SystemColors.Window;
            textBox_code_u.Location = new Point(21, 54);
            textBox_code_u.Name = "textBox_code_u";
            textBox_code_u.Size = new Size(91, 27);
            textBox_code_u.TabIndex = 7;
            // 
            // comboBox_filter
            // 
            comboBox_filter.BackColor = SystemColors.WindowText;
            comboBox_filter.ForeColor = SystemColors.Window;
            comboBox_filter.FormattingEnabled = true;
            comboBox_filter.Items.AddRange(new object[] { "all", "with club", "without club" });
            comboBox_filter.Location = new Point(656, 156);
            comboBox_filter.Name = "comboBox_filter";
            comboBox_filter.Size = new Size(132, 28);
            comboBox_filter.TabIndex = 35;
            comboBox_filter.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = SystemColors.Control;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Salmon;
            label15.Location = new Point(599, 160);
            label15.Name = "label15";
            label15.Size = new Size(56, 20);
            label15.TabIndex = 36;
            label15.Text = "FILTER";
            // 
            // panal_one_product
            // 
            panal_one_product.BackColor = Color.Snow;
            panal_one_product.Controls.Add(cancel);
            panal_one_product.Location = new Point(622, 190);
            panal_one_product.Name = "panal_one_product";
            panal_one_product.Size = new Size(166, 160);
            panal_one_product.TabIndex = 58;
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
            // FormSales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(panal_one_product);
            Controls.Add(label15);
            Controls.Add(updatePanel);
            Controls.Add(comboBox_filter);
            Controls.Add(addPanel);
            Controls.Add(button_delete);
            Controls.Add(button_update);
            Controls.Add(button_add);
            Controls.Add(dataGridView1);
            Name = "FormSales";
            Text = "FormSales";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            addPanel.ResumeLayout(false);
            addPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_price).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_min).EndInit();
            updatePanel.ResumeLayout(false);
            updatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_price_u).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_minamount_u).EndInit();
            panal_one_product.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_delete;
        private Button button_update;
        private Button button_add;
        private DataGridView dataGridView1;
        private Panel addPanel;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
        private NumericUpDown numericUpDown_price;
        private NumericUpDown numericUpDown_min;
        private TextBox textBox_productID;
        private TextBox textBox_code;
        private Label label7;
        private DateTimePicker dateTime_start;
        private CheckBox checkBox_club;
        private DateTimePicker dateTime_end;
        private Panel updatePanel;
        private DateTimePicker dateTimePicker_end;
        private DateTimePicker dateTimePicker_start;
        private CheckBox checkBox_club_u;
        private NumericUpDown numericUpDown_price_u;
        private NumericUpDown numericUpDown_minamount_u;
        private TextBox textBox_productId_u;
        private TextBox textBox_code_u;
        private ComboBox comboBox_filter;
        private Label label15;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label8;
        private Label label9;
        private Panel panal_one_product;
        private Button cancel;
    }
}