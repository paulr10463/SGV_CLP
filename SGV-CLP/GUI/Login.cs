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

        private void siticoneHtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void siticoneCustomCheckBox1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneSeparator2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneHtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneHtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneHtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void siticonePanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticonePictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
