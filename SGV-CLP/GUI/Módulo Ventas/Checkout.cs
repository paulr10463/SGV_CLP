using SGV_CLP.Classes;
using Siticone.Desktop.UI.AnimatorNS;
using Siticone.Desktop.UI.WinForms;
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

namespace SGV_CLP.GUI.Módulo_Ventas
{
    public partial class Checkout : Form
    {

        Cliente cliente = new Cliente("1725651518", "Paul", "Alexander", "Román", "Quimbiulco", "La kennedy", "0983472881", "paulroman3d@gmail.com");
        Cliente cliente1 = new Cliente("1825651521", "Ernesto", "Alexander", "Perez", "Quimbiulco", "La Rumiñahui", "0983421213", "ernestoperez@gmail.com");
        Cliente cliente2 = new Cliente("1715651521", "Maria", "Alexander", "Uribe", "Quimbiulco", "La Rumiñahui", "0983421213", "ernestoperez@gmail.com");
        Cliente clienteVacio = new Cliente("0", "", "", "", "", "", "", "");
        int limit_cc_length = 10;
        int max_nombre_length = 50, max_apell_length = 50;
        int limit_nombre_length = 50, limit_apellido_length = 50,
            limit_direccion_length = 100, limit_telef_length = 10, limit_fechanac_length = 10, limit_correo_length = 100;
        bool control_cc = true;
        bool control_apell1 = true, control_apell2 = true;
        bool control_nombre1 = true, control_nombre2 = true, control_direc = true;
        bool control_telef = true;
        bool control_correo = true;

        int num_atributos = 8;
        int count_correct_fields = 0;

        public Checkout(SiticoneDataGridView siticoneDataGridView)
        {
            InitializeComponent();
            foreach (DataGridViewRow rowItem in siticoneDataGridView.Rows)
            {
                DataGridViewRow row = (DataGridViewRow)rowItem.Clone();
                row.Cells[0].Value = rowItem.Cells[0].Value;
                row.Cells[1].Value = rowItem.Cells[1].Value;
                row.Cells[2].Value = rowItem.Cells[2].Value;
                siticoneDataGridView1.Rows.Add(row);
            }
            setTotal(siticoneDataGridView1);
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();


            lista.Add(cliente.Cc_Cliente);
            lista.Add(cliente1.Cc_Cliente);
            lista.Add(cliente2.Cc_Cliente);
            siticoneTextBox1.AutoCompleteCustomSource = lista;

            txtCC_ClienteVenta.MaxLength = limit_cc_length;
            txtNombre1Venta.MaxLength = max_nombre_length;
            txtNombre2Venta.MaxLength= max_nombre_length;
            txtApellido1Venta.MaxLength = max_apell_length;
            txtApellido2Venta.MaxLength = max_apell_length;
            txtDireccionVenta.MaxLength = limit_direccion_length;
            txtTelefVenta.MaxLength = limit_telef_length;
            txtCorreoVenta.MaxLength = limit_correo_length;

            siticoneHtmlLabel_correct_email.Hide();
            siticoneHtmlLabel_cc_valida.Hide();
            siticoneHtmlLabel_cc_correct_length.Hide();
            siticoneHtmlLabel_correct_length_telef.Hide();
            siticoneHtmlLabel_wrong_email.Hide();
            siticoneHtmlLabel_wrong_length_telef.Hide();

            ButtonAniadirClienteVenta.Enabled = false;
            ButtonConfirmarVenta.Enabled= false;

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            MessageBox.Show("Compra finalizada con éxito", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            if (MessageBox.Show("¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                MessageBox.Show("Proveedor eliminado con éxito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Proveedor no eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            txtNombre2Venta.Enabled = true;
            txtApellido1Venta.Enabled = true;   
            txtNombre1Venta.Enabled = true;
            txtApellido2Venta.Enabled = true;
            txtDireccionVenta.Enabled = true;
            txtTelefVenta.Enabled = true;
            txtCorreoVenta.Enabled = true;

            siticoneHtmlLabel_wrong_email.Show();
            siticoneHtmlLabel_wrong_length_telef.Show();

            ButtonConfirmarVenta.Visible= true;

            if (IsValidEmail(txtCorreoVenta.Text))
            {
                siticoneHtmlLabel_wrong_email.Hide();
                siticoneHtmlLabel_correct_email.Show();
            }
            else
            {
                siticoneHtmlLabel_wrong_email.Show();
                siticoneHtmlLabel_correct_email.Hide();
            }

        }

        private void siticoneButton3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Cliente Registrado con éxito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ButtonConfirmarVenta.Visible = false;
            txtNombre2Venta.Enabled = false;
            txtApellido1Venta.Enabled = false;
            txtNombre1Venta.Enabled = false;
            txtApellido2Venta.Enabled = false;
            txtDireccionVenta.Enabled = false;
            txtTelefVenta.Enabled = false;
        }

        private void txtCC_ClienteVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // comprueba que la cc == 10 y muesta mensaje de correcto
            if (txtCC_ClienteVenta.Text.Length + 1 == limit_cc_length && control_cc && e.KeyChar != '\b')
            {
                control_cc = false;
                count_correct_fields++;
                siticoneHtmlLabel_cc_wrong_length.Hide();

                siticoneHtmlLabel_cc_correct_length.Show();
            }
            else if (txtCC_ClienteVenta.Text.Length - 1 < limit_cc_length && !control_cc && e.KeyChar == '\b')
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

        private void txtCC_ClienteVenta_KeyUp(object sender, KeyEventArgs e)
        {
            controlCedula();

            if(ValidarCedula(txtCC_ClienteVenta.Text) && txtCC_ClienteVenta.Text.Length == limit_cc_length)
            {
                ButtonAniadirClienteVenta.Enabled = true;
            }
            else
            {
                ButtonAniadirClienteVenta.Enabled = false;
            }
        }

        public void controlCedula()
        {
            if (ValidarCedula(txtCC_ClienteVenta.Text))
            {
                siticoneHtmlLabel_cc_invalida.Hide();
                siticoneHtmlLabel_cc_valida.Show();
            }
            validateFieldsCounter();
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

        private void txtNombre1Venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtNombre1Venta.Text.Length + 1 > 0 && control_nombre1 && e.KeyChar != '\b')
            {
                control_nombre1 = false;
                count_correct_fields++;
            }
            else if (txtNombre1Venta.Text.Length - 1 == 0 && !control_nombre1 && e.KeyChar == '\b')
            {
                control_nombre1 = true;
                count_correct_fields--;
            }

            validateFieldsCounter();
        }

        private void txtNombre2Venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtNombre2Venta.Text.Length + 1 > 0 && control_nombre2 && e.KeyChar != '\b')
            {
                control_nombre2 = false;
                count_correct_fields++;
            }
            else if (txtNombre2Venta.Text.Length - 1 == 0 && !control_nombre2 && e.KeyChar == '\b')
            {
                control_nombre2 = true;
                count_correct_fields--;
            }

            validateFieldsCounter();
        }

        private void txtApellido1Venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtApellido1Venta.Text.Length + 1 > 0 && control_apell1 && e.KeyChar != '\b')
            {
                control_apell1 = false;
                count_correct_fields++;
            }
            else if (txtApellido1Venta.Text.Length - 1 == 0 && !control_apell1 && e.KeyChar == '\b')
            {
                control_apell1 = true;
                count_correct_fields--;
            }

            validateFieldsCounter();
        }

        private void txtApellido2Venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtApellido2Venta.Text.Length + 1 > 0 && control_apell2 && e.KeyChar != '\b')
            {
                control_apell2 = false;
                count_correct_fields++;
            }
            else if (txtApellido2Venta.Text.Length - 1 == 0 && !control_apell2 && e.KeyChar == '\b')
            {
                control_apell2 = true;
                count_correct_fields--;
            }

            validateFieldsCounter();
        }

        private void txtDireccionVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras o números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtDireccionVenta.Text.Length + 1 > 0 && control_direc && e.KeyChar != '\b')
            {
                control_direc = false;
                count_correct_fields++;
            }
            else if (txtDireccionVenta.Text.Length - 1 == 0 && !control_direc && e.KeyChar == '\b')
            {
                control_direc = true;
                count_correct_fields--;
            }

            validateFieldsCounter();
        }

        private void txtTelefVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtTelefVenta.Text.Length + 1 == limit_telef_length && control_telef && e.KeyChar != '\b')
            {
                control_telef = false;
                count_correct_fields++;
                siticoneHtmlLabel_wrong_length_telef.Hide();
                siticoneHtmlLabel_correct_length_telef.Show();
            }
            else if (txtTelefVenta.Text.Length - 1 != limit_telef_length && !control_telef && e.KeyChar == '\b')
            {
                control_telef = true;
                count_correct_fields--;
                siticoneHtmlLabel_wrong_length_telef.Show();
                siticoneHtmlLabel_correct_length_telef.Hide();
            }

            validateFieldsCounter();
        }

        private void txtCorreoVenta_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTotalVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente números o \".\" !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void txtRecibidoVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente números o \".\" !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void txtVueltoVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente números o \".\" !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void txtCorreoVenta_KeyUp(object sender, KeyEventArgs e)
        {
            if (IsValidEmail(txtCorreoVenta.Text) && control_correo)
            {
                // El correo es valido por primera vez
                siticoneHtmlLabel_wrong_email.Hide();
                siticoneHtmlLabel_correct_email.Show();

                count_correct_fields++;
                control_correo = false;

            }
            else if (IsValidEmail(txtCorreoVenta.Text) && !control_correo)
            {
                // El correo es valido por mas de una vez
                siticoneHtmlLabel_wrong_email.Hide();
                siticoneHtmlLabel_correct_email.Show();
            }
            else if (!IsValidEmail(txtCorreoVenta.Text) && !control_correo)
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

        public static bool IsValidEmail(string email)
        {
            // Define la expresión regular para validar un correo electrónico
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            // Crea un objeto Regex con la expresión regular
            Regex regex = new Regex(pattern);

            // Valida el correo electrónico
            return regex.IsMatch(email);
        }

        private void validateFieldsCounter()
        {
            ButtonConfirmarVenta.Enabled = count_correct_fields >= num_atributos && ValidarCedula(txtCC_ClienteVenta.Text);
        }
        public void setTotal(SiticoneDataGridView tablaVenta)
        {
            double total = 0;
            foreach (DataGridViewRow rowItem in siticoneDataGridView1.Rows)
            {
                if (rowItem.Cells[0].Value != null)
                {
                    total += (double)rowItem.Cells[2].Value;
                }
                else
                {
                    break;
                }
            }

            siticoneTextBox2.Text = total.ToString();

        }

        private void siticoneTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                siticoneTextBox4.Text = (Convert.ToDouble(siticoneTextBox3.Text) - Convert.ToDouble(siticoneTextBox2.Text)).ToString();
            }
        }

        private void loadCustomerFields(Cliente cliente)
        {
            siticoneTextBox12.Text = cliente.Primer_Nombre;
            siticoneTextBox10.Text = cliente.Segundo_Nombre;
            siticoneTextBox11.Text = cliente.Primer_Apellido;
            siticoneTextBox9.Text = cliente.Segundo_Apellido;
            siticoneTextBox6.Text = cliente.Direccion_Domicilio;
            siticoneTextBox5.Text = cliente.Telefono;
            siticoneTextBox7.Text = cliente.Correo_Electronico;

        }


        private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (siticoneTextBox1.Text.Equals("1725651518"))
            {
                loadCustomerFields(cliente);
            }else
            if (siticoneTextBox1.Text.Equals("1825651521"))
            {
                loadCustomerFields(cliente1);
            }else
            if (siticoneTextBox1.Text.Equals("1715651521"))
            {
                loadCustomerFields(cliente2);
            }
            else
            {
                loadCustomerFields(clienteVacio);
            }
        }
    }
}
