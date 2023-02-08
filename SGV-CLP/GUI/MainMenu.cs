using SGV_CLP.GUI;

namespace SGV_CLP
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

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
    }
}
