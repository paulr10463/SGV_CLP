using SGV_CLP.Classes;
using SGV_CLP.Classes.Módulo_Administración;
using System.Media;

namespace SGV_CLP
{
    public partial class Login : Form
    {
        public static Usuario user;
        public Login()
        {
            InitializeComponent();
        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            if (UsuarioMapper.checkUser(siticoneTextBox1.Text, siticoneTextBox2.Text))
            {
                this.Hide();
                user = new Usuario();
                user.userName = siticoneTextBox1.Text;
                MainMenu ventana = new MainMenu();
                
                ventana.Owner = this;
                ventana.ShowDialog();
                //ventana.user = user;
                this.Dispose();
                
            }
            else
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Credenciales erróneas. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }

        private void siticoneGradientButton2_Click(object sender, EventArgs e)
        {
            this.Close();
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
