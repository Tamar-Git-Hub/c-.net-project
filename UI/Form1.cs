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

        private void button2_Click(object sender, EventArgs e)
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
    }
}
