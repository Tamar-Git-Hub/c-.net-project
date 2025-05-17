namespace UI
{
    partial class FormCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomer));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            button_delete = new Button();
            button_update = new Button();
            button_add = new Button();
            AddPanel = new Panel();
            textBox_ID_add = new TextBox();
            textBox2 = new TextBox();
            textBox_address_add = new TextBox();
            textBox_phone_add = new TextBox();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            textBox5 = new TextBox();
            UpdatePanel = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox_id = new TextBox();
            text_name = new TextBox();
            textBox_address = new TextBox();
            textBox_phone = new TextBox();
            dataGridView1 = new DataGridView();
            button_all = new Button();
            Filter = new Button();
            panal_one_product = new Panel();
            cancel = new Button();
            AddPanel.SuspendLayout();
            UpdatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panal_one_product.SuspendLayout();
            SuspendLayout();
            // 
            // button_delete
            // 
            button_delete.BackColor = Color.Chartreuse;
            button_delete.BackgroundImage = (Image)resources.GetObject("button_delete.BackgroundImage");
            button_delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_delete.ForeColor = Color.Brown;
            button_delete.Location = new Point(674, 108);
            button_delete.Margin = new Padding(3, 4, 3, 4);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(114, 40);
            button_delete.TabIndex = 25;
            button_delete.Text = "DELETE";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // button_update
            // 
            button_update.BackgroundImage = (Image)resources.GetObject("button_update.BackgroundImage");
            button_update.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_update.ForeColor = Color.Chocolate;
            button_update.Location = new Point(674, 60);
            button_update.Margin = new Padding(3, 4, 3, 4);
            button_update.Name = "button_update";
            button_update.Size = new Size(114, 40);
            button_update.TabIndex = 24;
            button_update.Text = "UPDATE";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += button_update_Click;
            // 
            // button_add
            // 
            button_add.BackgroundImage = (Image)resources.GetObject("button_add.BackgroundImage");
            button_add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_add.ForeColor = Color.Coral;
            button_add.Location = new Point(674, 12);
            button_add.Margin = new Padding(3, 4, 3, 4);
            button_add.Name = "button_add";
            button_add.Size = new Size(114, 40);
            button_add.TabIndex = 23;
            button_add.Text = "ADD";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // AddPanel
            // 
            AddPanel.AllowDrop = true;
            AddPanel.BackColor = Color.Transparent;
            AddPanel.Controls.Add(textBox_ID_add);
            AddPanel.Controls.Add(textBox2);
            AddPanel.Controls.Add(textBox_address_add);
            AddPanel.Controls.Add(textBox_phone_add);
            AddPanel.Controls.Add(label23);
            AddPanel.Controls.Add(label24);
            AddPanel.Controls.Add(label25);
            AddPanel.Controls.Add(label26);
            AddPanel.Controls.Add(textBox5);
            AddPanel.Location = new Point(12, 299);
            AddPanel.Name = "AddPanel";
            AddPanel.Size = new Size(774, 112);
            AddPanel.TabIndex = 28;
            // 
            // textBox_ID_add
            // 
            textBox_ID_add.BackColor = SystemColors.WindowText;
            textBox_ID_add.ForeColor = SystemColors.Window;
            textBox_ID_add.Location = new Point(40, 66);
            textBox_ID_add.Name = "textBox_ID_add";
            textBox_ID_add.Size = new Size(125, 27);
            textBox_ID_add.TabIndex = 41;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.WindowText;
            textBox2.ForeColor = Color.WhiteSmoke;
            textBox2.Location = new Point(221, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 40;
            // 
            // textBox_address_add
            // 
            textBox_address_add.BackColor = SystemColors.WindowText;
            textBox_address_add.ForeColor = SystemColors.Window;
            textBox_address_add.Location = new Point(387, 67);
            textBox_address_add.Name = "textBox_address_add";
            textBox_address_add.Size = new Size(125, 27);
            textBox_address_add.TabIndex = 39;
            // 
            // textBox_phone_add
            // 
            textBox_phone_add.BackColor = SystemColors.WindowText;
            textBox_phone_add.ForeColor = SystemColors.Window;
            textBox_phone_add.Location = new Point(548, 67);
            textBox_phone_add.Name = "textBox_phone_add";
            textBox_phone_add.Size = new Size(125, 27);
            textBox_phone_add.TabIndex = 38;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.DarkSalmon;
            label23.Location = new Point(426, 25);
            label23.Name = "label23";
            label23.Size = new Size(63, 20);
            label23.TabIndex = 37;
            label23.Text = "address";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.ForeColor = Color.Chocolate;
            label24.Location = new Point(251, 26);
            label24.Name = "label24";
            label24.Size = new Size(48, 20);
            label24.TabIndex = 36;
            label24.Text = "name";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.ForeColor = Color.Coral;
            label25.Location = new Point(83, 26);
            label25.Name = "label25";
            label25.Size = new Size(25, 20);
            label25.TabIndex = 35;
            label25.Text = "ID";
            label25.Click += label25_Click;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.ForeColor = Color.DarkRed;
            label26.Location = new Point(580, 25);
            label26.Name = "label26";
            label26.Size = new Size(53, 20);
            label26.TabIndex = 34;
            label26.Text = "phone";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(546, 66);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 33;
            // 
            // UpdatePanel
            // 
            UpdatePanel.BackColor = Color.Transparent;
            UpdatePanel.Controls.Add(label2);
            UpdatePanel.Controls.Add(label3);
            UpdatePanel.Controls.Add(label4);
            UpdatePanel.Controls.Add(label5);
            UpdatePanel.Controls.Add(textBox_id);
            UpdatePanel.Controls.Add(text_name);
            UpdatePanel.Controls.Add(textBox_address);
            UpdatePanel.Controls.Add(textBox_phone);
            UpdatePanel.Location = new Point(10, 299);
            UpdatePanel.Name = "UpdatePanel";
            UpdatePanel.Size = new Size(771, 134);
            UpdatePanel.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSalmon;
            label2.Location = new Point(401, 31);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 41;
            label2.Text = "address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Chocolate;
            label3.Location = new Point(246, 31);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 40;
            label3.Text = "name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Coral;
            label4.Location = new Point(78, 31);
            label4.Name = "label4";
            label4.Size = new Size(25, 20);
            label4.TabIndex = 39;
            label4.Text = "ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkRed;
            label5.Location = new Point(561, 31);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 38;
            label5.Text = "phone";
            // 
            // textBox_id
            // 
            textBox_id.BackColor = SystemColors.ActiveCaptionText;
            textBox_id.ForeColor = SystemColors.Menu;
            textBox_id.Location = new Point(15, 60);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(125, 27);
            textBox_id.TabIndex = 29;
            // 
            // text_name
            // 
            text_name.BackColor = SystemColors.InfoText;
            text_name.ForeColor = SystemColors.Menu;
            text_name.Location = new Point(196, 60);
            text_name.Name = "text_name";
            text_name.Size = new Size(125, 27);
            text_name.TabIndex = 28;
            // 
            // textBox_address
            // 
            textBox_address.BackColor = SystemColors.WindowText;
            textBox_address.ForeColor = SystemColors.Window;
            textBox_address.Location = new Point(362, 61);
            textBox_address.Name = "textBox_address";
            textBox_address.Size = new Size(125, 27);
            textBox_address.TabIndex = 27;
            // 
            // textBox_phone
            // 
            textBox_phone.BackColor = SystemColors.WindowText;
            textBox_phone.ForeColor = SystemColors.Window;
            textBox_phone.Location = new Point(526, 60);
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(125, 27);
            textBox_phone.TabIndex = 26;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(571, 223);
            dataGridView1.TabIndex = 29;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button_all
            // 
            button_all.BackgroundImage = (Image)resources.GetObject("button_all.BackgroundImage");
            button_all.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_all.ForeColor = Color.DarkSalmon;
            button_all.Location = new Point(611, 152);
            button_all.Name = "button_all";
            button_all.Size = new Size(57, 38);
            button_all.TabIndex = 55;
            button_all.Text = "ALL";
            button_all.UseVisualStyleBackColor = true;
            button_all.Click += button_all_Click;
            // 
            // Filter
            // 
            Filter.BackColor = SystemColors.ControlDarkDark;
            Filter.BackgroundImage = (Image)resources.GetObject("Filter.BackgroundImage");
            Filter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Filter.ForeColor = Color.DarkSalmon;
            Filter.ImageAlign = ContentAlignment.MiddleRight;
            Filter.Location = new Point(673, 151);
            Filter.Name = "Filter";
            Filter.Size = new Size(114, 40);
            Filter.TabIndex = 54;
            Filter.Text = "FILTER ";
            Filter.UseVisualStyleBackColor = false;
            Filter.Click += Filter_Click_1;
            // 
            // panal_one_product
            // 
            panal_one_product.BackColor = Color.Snow;
            panal_one_product.Controls.Add(cancel);
            panal_one_product.Location = new Point(630, 200);
            panal_one_product.Name = "panal_one_product";
            panal_one_product.Size = new Size(166, 160);
            panal_one_product.TabIndex = 56;
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
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(panal_one_product);
            Controls.Add(button_all);
            Controls.Add(Filter);
            Controls.Add(dataGridView1);
            Controls.Add(UpdatePanel);
            Controls.Add(AddPanel);
            Controls.Add(button_delete);
            Controls.Add(button_update);
            Controls.Add(button_add);
            Name = "FormCustomer";
            Text = "FormCustomer";
            AddPanel.ResumeLayout(false);
            AddPanel.PerformLayout();
            UpdatePanel.ResumeLayout(false);
            UpdatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panal_one_product.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button button_delete;
        private Button button_update;
        private Button button_add;
        private Panel AddPanel;
        private Panel UpdatePanel;
        private TextBox textBox_id;
        private TextBox text_name;
        private TextBox textBox_address;
        private TextBox textBox_phone;
        private TextBox textBox_ID_add;
        private TextBox textBox2;
        private TextBox textBox_address_add;
        private TextBox textBox_phone_add;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private TextBox textBox5;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button_all;
        private Button Filter;
        private Panel panal_one_product;
        private Button cancel;
    }
}