namespace SGV_CLP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu ventana = new MainMenu();
            ventana.Owner = this;
            ventana.ShowDialog();
            this.Dispose();

        }

        private void siticoneGradientButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
