namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button_manager = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.AntiqueWhite;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderColor = Color.WhiteSmoke;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Tomato;
            button1.Location = new Point(256, 441);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(168, 45);
            button1.TabIndex = 0;
            button1.Text = "cashier";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button_manager
            // 
            button_manager.BackColor = SystemColors.Window;
            button_manager.BackgroundImage = (Image)resources.GetObject("button_manager.BackgroundImage");
            button_manager.FlatAppearance.BorderColor = Color.White;
            button_manager.FlatStyle = FlatStyle.Flat;
            button_manager.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic);
            button_manager.ForeColor = Color.Tomato;
            button_manager.Location = new Point(430, 441);
            button_manager.Margin = new Padding(3, 4, 3, 4);
            button_manager.Name = "button_manager";
            button_manager.Size = new Size(146, 47);
            button_manager.TabIndex = 1;
            button_manager.Text = "manager";
            button_manager.TextAlign = ContentAlignment.MiddleRight;
            button_manager.UseVisualStyleBackColor = false;
            button_manager.Click += button_manager_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(859, 497);
            Controls.Add(button_manager);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button_manager;
    }
}
