using SGV_CLP.Classes;
using SGV_CLP.GUI.Módulo_Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace SGV_CLP.GUI
{
    public partial class UC_Clientes : UserControl
    {
        
        List<Cliente> clientes = new List<Cliente>();
        
        int limit_cc_length = 10, limit_nombre_length = 50, limit_apellido_length = 50,
            limit_direccion_length = 100, limit_telef_length = 10, limit_fechanac_length = 10;

        int count_correct_fields = 0;

        int num_atributos = 8;

        bool control_cc = true;
        bool control_apell1 = true, control_apell2 = true;
        bool control_nombre1 = true, control_nombre2 = true, control_direc = true;
        bool control_telef = true;
        bool control_correo = true;

        public UC_Clientes()
        {
            InitializeComponent();

            // Limitamos la longitud segun los requisitos
            txtCedulaCliente.MaxLength = limit_cc_length;
            txtPrimerNombreCliente.MaxLength = limit_nombre_length;
            txtSegundoNombreCliente.MaxLength = limit_nombre_length;
            txtPrimerApellidoCliente.MaxLength = limit_apellido_length;
            txtSegundoApellidoCliente.MaxLength = limit_apellido_length;
            txtDireccionCliente.MaxLength = limit_direccion_length;
            txtTelefonoCliente.MaxLength = limit_telef_length;

            siticoneHtmlLabel_cc_correct_length.Hide();
            siticoneHtmlLabel_cc_valida.Hide();

            siticoneHtmlLabel_correct_length_telef.Hide();
            siticoneHtmlLabel_correct_email.Hide();

            Button_aniadirCliente.Enabled = false;
        }

        private void vaciarCampos()
        {
            txtCedulaCliente.Text = string.Empty;
            txtPrimerNombreCliente.Text = string.Empty;
            txtSegundoNombreCliente.Text = string.Empty;
            txtPrimerApellidoCliente.Text = string.Empty;
            txtSegundoApellidoCliente.Text = string.Empty;
            txtDireccionCliente.Text = string.Empty;
            txtTelefonoCliente.Text = string.Empty;
        }

        private void registrarCliente(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(
                txtCedulaCliente.Text,
                txtPrimerNombreCliente.Text + " " + txtSegundoNombreCliente.Text,
                txtPrimerApellidoCliente.Text + " " + txtSegundoApellidoCliente.Text,
                txtDireccionCliente.Text,
                txtTelefonoCliente.Text);

            clientes.Add(cliente);
            siticoneDataGridView1.Rows.Clear();
            foreach (Cliente c in clientes)
            {
                siticoneDataGridView1.Rows.Add(c.cedula, c.nombres, c.apellidos, c.direccion, c.telefono);
            }

            SystemSounds.Beep.Play();
            MessageBox.Show("Cliente añadido con éxito", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);

            vaciarCampos();
        }

        private void siticoneDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (siticoneDataGridView1.Columns[e.ColumnIndex].Name == "ColumnaEliminar")
            {
                if (MessageBox.Show("¿Está seguro de eliminar este cliente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clientes.RemoveAt(e.RowIndex);
                    siticoneDataGridView1.Rows.Clear();
                    foreach (Cliente c in clientes)
                    {
                        siticoneDataGridView1.Rows.Add(c.cedula, c.nombres, c.apellidos, c.direccion, c.telefono);
                    }
                }
            }

            if (siticoneDataGridView1.Columns[e.ColumnIndex].Name == "ColumnaEditar")
            {
                String cedula = siticoneDataGridView1.Rows[e.RowIndex].Cells["ColumnaCedula"].Value.ToString();
                Editar_Eliminar_Cliente ventana = new Editar_Eliminar_Cliente(cedula);
                ventana.ShowDialog();
            }
        }

        private void txtCedulaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // comprueba que la cc == 10 y muesta mensaje de correcto
            if (txtCedulaCliente.Text.Length + 1 == limit_cc_length && control_cc && e.KeyChar != '\b')
            {
                control_cc = false;
                count_correct_fields++;
                siticoneHtmlLabel_cc_wrong_length.Hide();

                siticoneHtmlLabel_cc_correct_length.Show();
            }
            else if(txtCedulaCliente.Text.Length - 1 < limit_cc_length && !control_cc && e.KeyChar == '\b')
            {
                // Borro 1 char de la cc teniendo ya completos los 10 previamente
                control_cc = true;
                count_correct_fields--;
                siticoneHtmlLabel_cc_invalida.Show();
                siticoneHtmlLabel_cc_wrong_length.Show();

                siticoneHtmlLabel_cc_correct_length.Hide();
                siticoneHtmlLabel_cc_valida.Hide();
            }

            validateFieldsCounter();
        }

        private void txtCedulaCliente_KeyUp(object sender, KeyEventArgs e)
        {
            controlCedula();
        }

        public void controlCedula()
        {
            if (ValidarCedula(txtCedulaCliente.Text))
            {
                siticoneHtmlLabel_cc_invalida.Hide();
                siticoneHtmlLabel_cc_valida.Show();
            }
            validateFieldsCounter();
        }

        private void txtBuscarClientePor_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (siticoneComboBox_EliminarEditarCliente.SelectedIndex)
            {
                case 0:
                    if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Ingrese únicamente números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
                case 1:
                    if (e.KeyChar != '\b' && !char.IsLetter(e.KeyChar))
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Ingrese únicamente letras!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
                case 2:
                    if (e.KeyChar != '\b' && !char.IsLetter(e.KeyChar))
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Ingrese únicamente letras!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
                case 3:
                    if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Ingrese únicamente números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
                default:
                    if (siticoneComboBox_EliminarEditarCliente.SelectedIndex == -1) e.Handled = true;
                    break;
            }
        }

        private void siticoneComboBox_EliminarEditarCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBuscarClientePor.Text = String.Empty;
            if (siticoneComboBox_EliminarEditarCliente.SelectedIndex != -1)
            {
                siticoneHtmlLabel_buscarCliente_sin_campo.Hide();
            }
        }

        private void txtSegundoNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSegundoApellidoCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneHtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void siticoneHtmlLabel13_Click(object sender, EventArgs e)
        {

        }

        private void siticoneHtmlLabel_cc_correct_length_Click(object sender, EventArgs e)
        {

        }

        private void siticoneHtmlLabel_cc_valida_Click(object sender, EventArgs e)
        {

        }

        private void TabRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void siticoneHtmlLabel_cc_wrong_length_Click(object sender, EventArgs e)
        {

        }

        private void siticoneHtmlLabel_correct_length_telef_Click(object sender, EventArgs e)
        {

        }

        private void siticoneHtmlLabel_wrong_length_telef_Click(object sender, EventArgs e)
        {

        }

        private void txtCorreoCliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (IsValidEmail(txtCorreoCliente.Text) && control_correo)
            {
                // El correo es valido por primera vez
                siticoneHtmlLabel_wrong_email.Hide();
                siticoneHtmlLabel_correct_email.Show();

                count_correct_fields++;
                control_correo = false;

            }
            else if(IsValidEmail(txtCorreoCliente.Text) && !control_correo)
            {
                // El correo es valido por mas de una vez
                siticoneHtmlLabel_wrong_email.Hide();
                siticoneHtmlLabel_correct_email.Show();
            }else if (!IsValidEmail(txtCorreoCliente.Text) && !control_correo)
            {
                // El correo es invalido un vez fue valido anteriormente
                siticoneHtmlLabel_wrong_email.Show();
                siticoneHtmlLabel_correct_email.Hide();

                count_correct_fields--;
                control_correo = true;
            }
            else
            {
                // El correo es invalido sin ser valido anteriormente
            }

            validateFieldsCounter();
        }

        private void txtSegundoApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtSegundoApellidoCliente.Text.Length + 1 > 0 && control_apell2 && e.KeyChar != '\b')
            {
                control_apell2 = false;
                count_correct_fields++;
            }
            else if (txtSegundoApellidoCliente.Text.Length - 1 == 0 && !control_apell2 && e.KeyChar == '\b')
            {
                control_apell2 = true;
                count_correct_fields--;
            }

            validateFieldsCounter();
        }

        private void txtCorreoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '_' && e.KeyChar != '@' && e.KeyChar != '.')
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras o números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            validateFieldsCounter();
        }

        private void txtPrimerApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtPrimerApellidoCliente.Text.Length + 1 > 0 && control_apell1 && e.KeyChar != '\b')
            {
                control_apell1 = false;
                count_correct_fields++;
            }
            else if (txtPrimerApellidoCliente.Text.Length - 1 == 0 && !control_apell1 && e.KeyChar == '\b')
            {
                control_apell1 = true;
                count_correct_fields--;
            }

            validateFieldsCounter();
        }

        private void txtSegundoNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtSegundoNombreCliente.Text.Length + 1> 0 && control_nombre2 && e.KeyChar != '\b') 
            {
                control_nombre2 = false;
                count_correct_fields++;
            }
            else if (txtSegundoNombreCliente.Text.Length - 1== 0 && !control_nombre2 && e.KeyChar == '\b')
            {
                control_nombre2 = true;
                count_correct_fields--;
            }

            validateFieldsCounter();
        }

        private void txtPrimerNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtPrimerNombreCliente.Text.Length + 1 > 0 && control_nombre1 && e.KeyChar != '\b')
            {
                control_nombre1 = false;
                count_correct_fields++;
            }
            else if (txtPrimerNombreCliente.Text.Length - 1 == 0 && !control_nombre1 && e.KeyChar == '\b')
            {
                control_nombre1 = true;
                count_correct_fields--;
            }

            validateFieldsCounter();
        }
        private void txtDireccionCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras o números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtDireccionCliente.Text.Length +1 > 0 && control_direc && e.KeyChar != '\b')
            {
                control_direc = false;
                count_correct_fields++;
            }
            else if (txtDireccionCliente.Text.Length -1 == 0 && !control_direc && e.KeyChar == '\b')
            {
                control_direc = true;
                count_correct_fields--;
            }

            validateFieldsCounter();
        }

        private void txtTelefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtTelefonoCliente.Text.Length +1 == limit_telef_length && control_telef && e.KeyChar != '\b')
            {
                control_telef = false;
                count_correct_fields++;
                siticoneHtmlLabel_wrong_length_telef.Hide();
                siticoneHtmlLabel_correct_length_telef.Show();
            }
            else if (txtTelefonoCliente.Text.Length -1 != limit_telef_length && !control_telef && e.KeyChar == '\b')
            {
                control_telef = true;
                count_correct_fields--;
                siticoneHtmlLabel_wrong_length_telef.Show();
                siticoneHtmlLabel_correct_length_telef.Hide();
            }

            validateFieldsCounter();
        }
        private void validateFieldsCounter()
        {
            Button_aniadirCliente.Enabled = count_correct_fields >= num_atributos && ValidarCedula(txtCedulaCliente.Text);   
        }

        public static bool ValidarCedula(string cedula)
        {
            // Verificar que la cédula tenga 10 dígitos
            if (cedula.Length != 10)
            {
                return false;
            }

            int tercerDigito = int.Parse(cedula[2].ToString());

            // Verificar que el tercer dígito sea entre 0 y 5
            if (tercerDigito < 0 || tercerDigito > 5)
            {
                return false;
            }

            // Verificar el último dígito de la cédula
            int ultimoDigito = int.Parse(cedula[9].ToString());

            int suma = 0;

            for (int i = 0; i < 9; i++)
            {
                int digito = int.Parse(cedula[i].ToString());

                if (i % 2 == 0)
                {
                    digito *= 2;

                    if (digito > 9)
                    {
                        digito -= 9;
                    }
                }

                suma += digito;
            }

            int digitoVerificador = 10 - (suma % 10);

            if (digitoVerificador == 10)
            {
                digitoVerificador = 0;
            }

            return ultimoDigito == digitoVerificador;
        }
        public static bool IsValidEmail(string email)
        {
            // Define la expresión regular para validar un correo electrónico
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            // Crea un objeto Regex con la expresión regular
            Regex regex = new Regex(pattern);

            // Valida el correo electrónico
            return regex.IsMatch(email);
        }
    }
}
