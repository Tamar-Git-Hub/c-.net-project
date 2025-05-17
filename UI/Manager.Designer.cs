namespace UI
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            button_product = new Button();
            button_customers = new Button();
            button_sales = new Button();
            SuspendLayout();
            // 
            // button_product
            // 
            button_product.BackColor = Color.OrangeRed;
            button_product.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_product.ForeColor = Color.Snow;
            button_product.Location = new Point(2, -5);
            button_product.Name = "button_product";
            button_product.Size = new Size(100, 30);
            button_product.TabIndex = 0;
            button_product.Text = "Products";
            button_product.UseVisualStyleBackColor = false;
            button_product.Click += button_product_Click;
            // 
            // button_customers
            // 
            button_customers.BackColor = Color.Red;
            button_customers.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_customers.ForeColor = Color.Snow;
            button_customers.Location = new Point(87, -5);
            button_customers.Name = "button_customers";
            button_customers.Size = new Size(100, 30);
            button_customers.TabIndex = 1;
            button_customers.Text = "Customers";
            button_customers.UseVisualStyleBackColor = false;
            button_customers.Click += button_customers_Click;
            // 
            // button_sales
            // 
            button_sales.BackColor = Color.Crimson;
            button_sales.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_sales.ForeColor = Color.Snow;
            button_sales.Location = new Point(181, -4);
            button_sales.Name = "button_sales";
            button_sales.Size = new Size(100, 30);
            button_sales.TabIndex = 2;
            button_sales.Text = "Sales";
            button_sales.UseVisualStyleBackColor = false;
            button_sales.Click += button_sales_Click;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button_sales);
            Controls.Add(button_customers);
            Controls.Add(button_product);
            Name = "Manager";
            Text = "Manager";
            ResumeLayout(false);
        }

        #endregion

        private Button button_product;
        private Button button_customers;
        private Button button_sales;
    }
}