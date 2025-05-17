namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_manager_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            this.Hide();
            manager.FormClosed += Manager_FormClosed;
            manager.Show();
        }

        private void Manager_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormOrder order = new FormOrder();
            this.Hide();
            order.FormClosed += Manager_FormClosed;
            order.Show();
        }

       
    }
}
