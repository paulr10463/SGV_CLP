using SGV_CLP.Classes;
using SGV_CLP.GUI.Módulo_Clientes;
using System.Media;
using System.Text.RegularExpressions;


namespace SGV_CLP.GUI

{
    public partial class UC_Clientes : UserControl
    {
        List<Cliente> clientesRegistrados = ClienteMapper.ConsultarClientes();

        int count_correct_fields = 0;
        int num_atributos = 6;

        bool ccIsValid = false;
        bool firsLastNameIsValid = false;
        bool firstNameIsValid = false;
        bool addressIsValid = false;
        bool telefIsValid = false;
        bool correoIsValid = false;

        public UC_Clientes()
        {
            InitializeComponent();
            // Llenamos la tabla Clientes
            llenarTablaCliente();

            // Limitamos la longitud segun los requisitos
            txtCedulaCliente.MaxLength = Constants.LIMIT_CC_LENGTH;
            txtPrimerNombreCliente.MaxLength = Constants.LIMIT_NOMBRE_LENGTH;
            txtSegundoNombreCliente.MaxLength = Constants.LIMIT_NOMBRE_LENGTH;
            txtPrimerApellidoCliente.MaxLength = Constants.LIMIT_APELLIDO_LENGTH;
            txtSegundoApellidoCliente.MaxLength = Constants.LIMIT_APELLIDO_LENGTH;
            txtDireccionCliente.MaxLength = Constants.LIMIT_DIRECCION_LENGTH;
            txtTelefonoCliente.MaxLength = Constants.LIMIT_TELEF_LENGTH;
            txtCorreoCliente.MaxLength = Constants.LIMIT_CORREO_LENGTH;

            //Hide Labels
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
            txtCorreoCliente.Text = string.Empty;
        }

        public void llenarTablaCliente()
        {
            if (clientesRegistrados != null)
            {
                siticoneDataGridView1.Rows.Clear();
                clientesRegistrados = ClienteMapper.ConsultarClientes();
                foreach (Cliente cliente in clientesRegistrados)
                {
                    // dgvClientes
                    siticoneDataGridView1.Rows.Add(cliente.Cc_Cliente, cliente.Primer_Nombre + cliente.Segundo_Nombre, cliente.Primer_Apellido + cliente.Segundo_Apellido, cliente.Direccion_Domicilio, cliente.Telefono, cliente.Correo_Electronico);
                }
            }
        }

        private void registrarCliente(object sender, EventArgs e)
        {
            var cliente = new Cliente
            {
                Cc_Cliente = txtCedulaCliente.Text,
                Primer_Nombre = txtPrimerNombreCliente.Text,
                Segundo_Nombre = txtSegundoNombreCliente.Text,
                Primer_Apellido = txtPrimerApellidoCliente.Text,
                Segundo_Apellido = txtSegundoApellidoCliente.Text,
                Direccion_Domicilio = txtDireccionCliente.Text,
                Telefono = txtTelefonoCliente.Text,
                Correo_Electronico = txtCorreoCliente.Text
            };

            ClienteMapper.IngresarCliente(cliente);
            llenarTablaCliente();

            SystemSounds.Beep.Play();
            MessageBox.Show("Cliente añadido con éxito", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);

            vaciarCampos();
        }

        private void siticoneDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (siticoneDataGridView1.Columns[e.ColumnIndex].Name == "ColumnaEliminar")
            {
                if (e.RowIndex >= 0)
                {
                    if (MessageBox.Show("¿Está seguro de eliminar este cliente?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        /*clientes.RemoveAt(e.RowIndex);
                        siticoneDataGridView1.Rows.Clear();
                        foreach (Cliente c in clientes)
                        {
                            //siticoneDataGridView1.Rows.Add(c.cedula, c.nombres, c.apellidos, c.direccion, c.telefono);
                        }
                        */
                    }
                }
            }

            if (siticoneDataGridView1.Columns[e.ColumnIndex].Name == "ColumnaEditar")
            {
                if (e.RowIndex >= 0)
                {
                    String cedula = siticoneDataGridView1.Rows[e.RowIndex].Cells["ColumnaCedula"].Value.ToString();
                    Editar_Cliente ventana = new Editar_Cliente(cedula);
                    ventana.ShowDialog();
                }
            }
        }

        private void txtCedulaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void txtCedulaCliente_KeyUp(object sender, KeyEventArgs e)
        {
            controlCedula();
        }

        public void controlCedula()
        {
            if (ValidationUtils.ValidarCedula(txtCedulaCliente.Text))
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

        private void txtSegundoApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
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

        private void txtPrimerApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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
        private void validateFieldsCounter()
        {
            Button_aniadirCliente.Enabled = count_correct_fields >= num_atributos && ValidationUtils.ValidarCedula(txtCedulaCliente.Text);
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

        private void txtTelefonoCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefonoCliente.Text.Length == Constants.LIMIT_TELEF_LENGTH && !telefIsValid)
            {
                siticoneHtmlLabel_wrong_length_telef.Hide();
                siticoneHtmlLabel_correct_length_telef.Show();
                telefIsValid = true;
                count_correct_fields++;
            }
            else if (txtTelefonoCliente.Text.Length != Constants.LIMIT_TELEF_LENGTH && telefIsValid)
            {
                siticoneHtmlLabel_wrong_length_telef.Show();
                siticoneHtmlLabel_correct_length_telef.Hide();
                telefIsValid = false;
                count_correct_fields--;
            }

            validateFieldsCounter();
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



        private void txtPrimerNombreCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtPrimerNombreCliente.Text.Length > 0 && !firstNameIsValid)
            {
                firstNameIsValid = true;
                count_correct_fields++;
            }
            else if (txtPrimerNombreCliente.Text.Length == 0 && firstNameIsValid)
            {
                firstNameIsValid = false;
                count_correct_fields--;
            }

            validateFieldsCounter();
        }




        private void txtPrimerApellidoCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtPrimerApellidoCliente.Text.Length > 0 && !firsLastNameIsValid)
            {
                firsLastNameIsValid = true;
                count_correct_fields++;
            }
            else if (txtPrimerApellidoCliente.Text.Length == 0 && firsLastNameIsValid)
            {
                firsLastNameIsValid = false;
                count_correct_fields--;
            }

            validateFieldsCounter();
        }

        private void txtCedulaCliente_TextChanged(object sender, EventArgs e)
        {
            // comprueba que la cc == 10 y muesta mensaje de correcto
            if (txtCedulaCliente.Text.Length == Constants.LIMIT_CC_LENGTH && !ccIsValid)
            {
                ccIsValid = true;
                count_correct_fields++;
                siticoneHtmlLabel_cc_wrong_length.Hide();
                siticoneHtmlLabel_cc_correct_length.Show();
            }
            else if (txtCedulaCliente.Text.Length < Constants.LIMIT_CC_LENGTH && ccIsValid)
            {
                // Borro 1 char de la cc teniendo ya completos los 10 previamente
                ccIsValid = false;
                count_correct_fields--;
                siticoneHtmlLabel_cc_invalida.Show();
                siticoneHtmlLabel_cc_wrong_length.Show();

                siticoneHtmlLabel_cc_correct_length.Hide();
                siticoneHtmlLabel_cc_valida.Hide();
            }

            validateFieldsCounter();
        }
    }
}
