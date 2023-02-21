using SGV_CLP.GUI;
using System.Media;

namespace SGV_CLP
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void siticoneButton1_CheckedChanged(object sender, EventArgs e)
        {
            uC_Administracion1.BringToFront();
        }

        private void siticoneButton2_CheckedChanged(object sender, EventArgs e)
        {
            uC_Compras1.BringToFront();
        }

        private void siticoneButton3_CheckedChanged(object sender, EventArgs e)
        {
            uC_Ventas1.BringToFront();
        }

        private void siticoneButton4_CheckedChanged(object sender, EventArgs e)
        {
            uC_Clientes1.BringToFront();
        }

        private void siticoneButton5_CheckedChanged(object sender, EventArgs e)
        {
            uC_Proveedores1.BringToFront();
        }

        private void siticoneButton6_CheckedChanged(object sender, EventArgs e)
        {
            uC_Productos1.BringToFront();
        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton7_Click_1(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            if (MessageBox.Show("¿Desea cerrar sesión?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                this.Hide();
                Login ventana = new Login();
                ventana.Owner = this;
                ventana.ShowDialog();
                this.Dispose();
            }

        }

    }
}
