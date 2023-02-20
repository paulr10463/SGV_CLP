using SGV_CLP.GUI.Módulo_Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGV_CLP.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SGV_CLP.GUI
{
    public partial class UC_Clientes : UserControl
    {
        public UC_Clientes()
        {
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente { Cc_Cliente = STBCedula.Text, Primer_Nombre = STBPrimerNombre.Text, Segundo_Nombre = STBSegundoNombre.Text, Primer_Apellido = STBPrimerApellido.Text, Segundo_Apellido = STBSegundoApellido.Text, Direccion_Domicilio = STBDireccionDomicilio.Text, Telefono = STBTelefono.Text, Correo_Electronico = STBCorreoElectronico.Text};
            var idCliente = ClienteMapper.IngresarCliente(cliente);
            SystemSounds.Beep.Play();
            MessageBox.Show("Cliente añadido con éxito", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBoxes();
        }
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
                {
                    foreach (Control control in controls)
                        if (control is System.Windows.Forms.TextBox)
                            (control as System.Windows.Forms.TextBox).Clear();
                        else
                            func(control.Controls);
                };
            func(Controls);
        }

        private void siticoneDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar_Eliminar_Cliente ventana = new Editar_Eliminar_Cliente();
            ventana.ShowDialog();
        }

        private void siticoneComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string[] elementos = { "Cédula de identidad", "Nombres completos" };

            switch (SCBBuscar.SelectedItem.ToString())
            {
                case "Cédula de identidad":
                    //SCBBuscar.Items.Add("Elemento 1");
                    break;
                case "Nombres completos":
                    break;
                default:
                    SCBBuscar.Items.Clear();
                    break;
            }
        }

        private void siticoneTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticonePictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void siticoneDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
