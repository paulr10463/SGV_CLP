using SGV_CLP.Classes;
using SGV_CLP.Classes.Customers_Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGV_CLP.GUI.Módulo_Clientes
{
    public partial class Editar_Cliente : Form
    {
        string cc_Cliente;

        int count_correct_fields = 0, num_atributos = 3;

        bool addressIsValid, telefIsValid, correoIsValid;

        public Editar_Cliente(String cc_Cliente)
        {
            InitializeComponent();
            this.cc_Cliente = cc_Cliente;

            addressIsValid = false;
            telefIsValid = false;
            correoIsValid = false;

            txtCorreoCliente.Text = CustomerMapper.GetCustomerField(cc_Cliente, "correo_Electronico");
            txtDireccionCliente.Text = CustomerMapper.GetCustomerField(cc_Cliente, "direccion_Domicilio");
            txtTelefonoCliente.Text = CustomerMapper.GetCustomerField(cc_Cliente, "telefono");

            txtDireccionCliente.MaxLength = Constants.LIMIT_DIRECCION_LENGTH;
            txtTelefonoCliente.MaxLength = Constants.LIMIT_TELEF_LENGTH;
            txtCorreoCliente.MaxLength = Constants.LIMIT_CORREO_LENGTH;

            siticoneHtmlLabel_correct_length_telef.Hide();
            siticoneHtmlLabel_valid_telef.Hide();
            siticoneHtmlLabel_correct_email.Hide();

            button_EditarCliente.Enabled = false;
        }

        private void button_EditarCliente_Click(object sender, EventArgs e)
        {
            CustomerMapper.EditCustomer(cc_Cliente, txtDireccionCliente.Text, txtCorreoCliente.Text, txtTelefonoCliente.Text);
            SystemSounds.Beep.Play();
            MessageBox.Show("Cliente editado con éxito", "Editar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void validateFieldsCounter()
        {
            button_EditarCliente.Enabled = count_correct_fields >= num_atributos;
        }

        private void txtDireccionCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && e.KeyChar != '.' && e.KeyChar != ';' && e.KeyChar != ' ' && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras, números, \";\" o \".\"!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void txtDireccionCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtDireccionCliente.Text.Length > 0 && !addressIsValid)
            {
                addressIsValid = true;
                count_correct_fields++;
            }
            else if (txtDireccionCliente.Text.Length == 0 && addressIsValid)
            {
                addressIsValid = false;
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
        }

        private void txtCorreoCliente_TextChanged(object sender, EventArgs e)
        {
            if (ValidationUtils.IsValidEmail(txtCorreoCliente.Text) && !correoIsValid)
            {
                //El correo es válido
                siticoneHtmlLabel_wrong_email.Hide();
                siticoneHtmlLabel_correct_email.Show();
                count_correct_fields++;
                correoIsValid = true;

            }
            else if (!ValidationUtils.IsValidEmail(txtCorreoCliente.Text) && correoIsValid)
            {
                // El correo es invalido pero fue valido anteriormente
                siticoneHtmlLabel_wrong_email.Show();
                siticoneHtmlLabel_correct_email.Hide();
                count_correct_fields--;
                correoIsValid = false;
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
        }

        private void txtTelefonoCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefonoCliente.Text.Length == Constants.LIMIT_TELEF_LENGTH && !telefIsValid)
            {
                siticoneHtmlLabel_wrong_length_telef.Hide();
                siticoneHtmlLabel_correct_length_telef.Show();
                if (ValidationUtils.IsValidPhoneNumber(txtTelefonoCliente.Text))
                {
                    siticoneHtmlLabel_valid_telef.Show();
                    siticoneHtmlLabel_invalid_telef.Hide();
                    telefIsValid = true;
                    count_correct_fields++;
                }
                else
                {
                    siticoneHtmlLabel_valid_telef.Hide();
                    siticoneHtmlLabel_invalid_telef.Show();
                    telefIsValid = false;
                    count_correct_fields--;
                }
            }
            else if (txtTelefonoCliente.Text.Length < Constants.LIMIT_TELEF_LENGTH && telefIsValid)
            {
                siticoneHtmlLabel_valid_telef.Hide();
                siticoneHtmlLabel_invalid_telef.Show();
                siticoneHtmlLabel_wrong_length_telef.Show();
                siticoneHtmlLabel_correct_length_telef.Hide();
                telefIsValid = false;
                count_correct_fields--;
            }
            validateFieldsCounter();
        }
    }
}
