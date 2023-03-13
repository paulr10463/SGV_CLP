using SGV_CLP.Classes;
using SGV_CLP.Classes.Customers_Module;
using SGV_CLP.GUI.Módulo_Clientes;
using System.Media;
using System.Text.RegularExpressions;


namespace SGV_CLP.GUI
{
    public partial class UC_Customer : UserControl
    {
        List<Customer> registeredCustomers = CustomerMapper.GetAllCustomers();

        int countCorrectFields = 0, fieldsNumber = 6;

        bool customerIDIsValid, firstLastNameIsValid, firstNameIsValid, homeAddressIsValid, phoneNumberIsValid, eMailIsValid;

        public UC_Customer()
        {
            InitializeComponent();
            // Llenamos la tabla Clientes
            FillCustomerDataGridView();

            cbSearchCustomerBy.SelectedIndex = 0;

            customerIDIsValid = false;
            firstLastNameIsValid = false;
            firstNameIsValid = false;
            homeAddressIsValid = false;
            phoneNumberIsValid = false;
            eMailIsValid = false;

            // Limitamos la longitud segun los requisitos
            tbCustomerID.MaxLength = Constants.LIMIT_CC_LENGTH;
            tbFirstName.MaxLength = Constants.LIMIT_NOMBRE_LENGTH;
            tbMiddleName.MaxLength = Constants.LIMIT_NOMBRE_LENGTH;
            tbFirstLastName.MaxLength = Constants.LIMIT_APELLIDO_LENGTH;
            tbSecondLastName.MaxLength = Constants.LIMIT_APELLIDO_LENGTH;
            tbHomeAddress.MaxLength = Constants.LIMIT_DIRECCION_LENGTH;
            tbPhoneNumber.MaxLength = Constants.LIMIT_TELEF_LENGTH;
            tbEMail.MaxLength = Constants.LIMIT_CORREO_LENGTH;

            //Hide Labels
            labelCorrectCustomerIDLength.Hide();
            labelValidCustomerID.Hide();
            labelCorrectPhoneNumberLength.Hide();
            labelValidPhoneNumber.Hide();
            labelCorrectEMail.Hide();

            buttonAddCustomer.Enabled = false;
        }

        private void ClearCustomerFields()
        {
            tbCustomerID.Text = string.Empty;
            tbFirstName.Text = string.Empty;
            tbMiddleName.Text = string.Empty;
            tbFirstLastName.Text = string.Empty;
            tbSecondLastName.Text = string.Empty;
            tbHomeAddress.Text = string.Empty;
            tbPhoneNumber.Text = string.Empty;
            tbEMail.Text = string.Empty;
        }

        public void FillCustomerDataGridView()
        {
            if (registeredCustomers != null)
            {
                CustomerDataGridView.Rows.Clear();
                registeredCustomers = CustomerMapper.GetAllCustomers();
                foreach (Customer customer in registeredCustomers)
                {
                    CustomerDataGridView.Rows.Add(customer.customerID, customer.firstName + customer.MiddleName, customer.firstLastName + customer.secondLastName, customer.homeAddress, customer.phoneNumber, customer.eMail);
                }
            }
        }

        private void ButtonAddCustomer_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                customerID = tbCustomerID.Text,
                firstName = tbFirstName.Text,
                MiddleName = tbMiddleName.Text,
                firstLastName = tbFirstLastName.Text,
                secondLastName = tbSecondLastName.Text,
                homeAddress = tbHomeAddress.Text,
                phoneNumber = tbPhoneNumber.Text,
                eMail = tbEMail.Text
            };

            CustomerMapper.AddCustomer(customer);

            FillCustomerDataGridView();
            ClearCustomerFields();

            SystemSounds.Beep.Play();
            MessageBox.Show("Cliente añadido con éxito", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CustomerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // CLICK EN CELDA ELIMINAR CLIENTE
            if (CustomerDataGridView.Columns[e.ColumnIndex].Name == "ColumnaEliminar")
            {
                if (e.RowIndex >= 0)
                {
                    if (MessageBox.Show("¿Está seguro de eliminar este cliente?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string customerID = CustomerDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

                        CustomerMapper.DeleteCustomer(customerID);
                        MessageBox.Show("Producto eliminado con éxito");
                    }
                }
            }

            // CLICK EN CELDA EDITAR CLIENTE
            if (CustomerDataGridView.Columns[e.ColumnIndex].Name == "ColumnaEditar")
            {
                if (e.RowIndex >= 0)
                {
                    string customerID = CustomerDataGridView.Rows[e.RowIndex].Cells["ColumnaCedula"].Value.ToString();
                    Editar_Cliente ventana = new Editar_Cliente(customerID);
                    ventana.ShowDialog();
                }
            }
            FillCustomerDataGridView();
        }

        private void TbCustomerID_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void TbCustomerID_KeyUp(object sender, KeyEventArgs e)
        {
            IDControl();
        }

        public void IDControl()
        {
            if (ValidationUtils.ValidarCedula(tbCustomerID.Text))
            {
                siticoneHtmlLabel_cc_invalida.Hide();
                labelValidCustomerID.Show();
            }
            validateFieldsCounter();
        }

        private void TbSearchCustomerBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (cbSearchCustomerBy.SelectedIndex)
            {
                case 1:
                    if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Ingrese únicamente números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (e.KeyChar != '\b' && !char.IsLetter(e.KeyChar))
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Ingrese únicamente letras!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
                case 4:
                    if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Ingrese únicamente números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
                default:
                    if (cbSearchCustomerBy.SelectedIndex == -1) e.Handled = true;
                    break;
            }
        }

        private void CbSearchCustomerBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCustomerDataGridView();
            txtBuscarClientePor.Text = string.Empty;
            if (cbSearchCustomerBy.SelectedIndex > 0)
            {
                siticoneHtmlLabel_buscarCliente_sin_campo.Hide();
                txtBuscarClientePor.Enabled = true;
            }
            else
            {
                siticoneHtmlLabel_buscarCliente_sin_campo.Show();
                txtBuscarClientePor.Enabled = false;
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
                MessageBox.Show("Ingrese únicamente letras, números, \" \", \";\" o \".\"!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            buttonAddCustomer.Enabled = countCorrectFields >= fieldsNumber && ValidationUtils.ValidarCedula(tbCustomerID.Text);
        }

        private void txtCorreoCliente_TextChanged(object sender, EventArgs e)
        {
            if (ValidationUtils.IsValidEmail(tbEMail.Text) && !eMailIsValid)
            {
                //El correo es válido
                siticoneHtmlLabel_wrong_email.Hide();
                labelCorrectEMail.Show();
                countCorrectFields++;
                eMailIsValid = true;

            }
            else if (!ValidationUtils.IsValidEmail(tbEMail.Text) && eMailIsValid)
            {
                // El correo es invalido pero fue valido anteriormente
                siticoneHtmlLabel_wrong_email.Show();
                labelCorrectEMail.Hide();
                countCorrectFields--;
                eMailIsValid = false;
            }
            validateFieldsCounter();
        }

        private void txtTelefonoCliente_TextChanged(object sender, EventArgs e)
        {
            if (tbPhoneNumber.Text.Length == Constants.LIMIT_TELEF_LENGTH && !phoneNumberIsValid)
            {
                siticoneHtmlLabel_wrong_length_telef.Hide();
                labelCorrectPhoneNumberLength.Show();
                if (ValidationUtils.IsValidPhoneNumber(tbPhoneNumber.Text))
                {
                    labelValidPhoneNumber.Show();
                    siticoneHtmlLabel_invalid_telef.Hide();
                    phoneNumberIsValid = true;
                    countCorrectFields++;
                }
                else
                {
                    labelValidPhoneNumber.Hide();
                    siticoneHtmlLabel_invalid_telef.Show();
                    phoneNumberIsValid = false;
                    countCorrectFields--;
                }
            }
            else if (tbPhoneNumber.Text.Length < Constants.LIMIT_TELEF_LENGTH && phoneNumberIsValid)
            {
                labelValidPhoneNumber.Hide();
                siticoneHtmlLabel_invalid_telef.Show();
                siticoneHtmlLabel_wrong_length_telef.Show();
                labelCorrectPhoneNumberLength.Hide();
                phoneNumberIsValid = false;
                countCorrectFields--;
            }
            validateFieldsCounter();
        }

        private void txtDireccionCliente_TextChanged(object sender, EventArgs e)
        {
            if (tbHomeAddress.Text.Length > 0 && !homeAddressIsValid)
            {
                homeAddressIsValid = true;
                countCorrectFields++;
            }
            else if (tbHomeAddress.Text.Length == 0 && homeAddressIsValid)
            {
                homeAddressIsValid = false;
                countCorrectFields--;
            }
            validateFieldsCounter();
        }

        private void txtPrimerNombreCliente_TextChanged(object sender, EventArgs e)
        {
            if (tbFirstName.Text.Length > 0 && !firstNameIsValid)
            {
                firstNameIsValid = true;
                countCorrectFields++;
            }
            else if (tbFirstName.Text.Length == 0 && firstNameIsValid)
            {
                firstNameIsValid = false;
                countCorrectFields--;
            }

            validateFieldsCounter();
        }

        private void txtPrimerApellidoCliente_TextChanged(object sender, EventArgs e)
        {
            if (tbFirstLastName.Text.Length > 0 && !firstLastNameIsValid)
            {
                firstLastNameIsValid = true;
                countCorrectFields++;
            }
            else if (tbFirstLastName.Text.Length == 0 && firstLastNameIsValid)
            {
                firstLastNameIsValid = false;
                countCorrectFields--;
            }

            validateFieldsCounter();
        }

        private void txtCedulaCliente_TextChanged(object sender, EventArgs e)
        {
            // comprueba que la cc == 10 y muesta mensaje de correcto
            if (tbCustomerID.Text.Length == Constants.LIMIT_CC_LENGTH && !customerIDIsValid)
            {
                customerIDIsValid = true;
                countCorrectFields++;
                siticoneHtmlLabel_cc_wrong_length.Hide();
                labelCorrectCustomerIDLength.Show();
            }
            else if (tbCustomerID.Text.Length < Constants.LIMIT_CC_LENGTH && customerIDIsValid)
            {
                // Borro 1 char de la cc teniendo ya completos los 10 previamente
                customerIDIsValid = false;
                countCorrectFields--;
                siticoneHtmlLabel_cc_invalida.Show();
                siticoneHtmlLabel_cc_wrong_length.Show();

                labelCorrectCustomerIDLength.Hide();
                labelValidCustomerID.Hide();
            }

            validateFieldsCounter();
        }

        private void txtBuscarClientePor_TextChanged(object sender, EventArgs e)
        {
            // Obtener el valor del ComboBox
            string selectedItem = cbSearchCustomerBy.SelectedItem.ToString();

            // Obtener el valor del TextBox
            string filterValue = txtBuscarClientePor.Text;
            // Filtrar los datos del DataGridView en función del valor del ComboBox y del TextBox
            if (selectedItem == "CI")
            {
                txtBuscarClientePor.MaxLength = Constants.LIMIT_CC_LENGTH;

                foreach (DataGridViewRow row in CustomerDataGridView.Rows)
                {
                    // Ocultar las filas que no cumplan con el filtro
                    if (row.Cells[0].Value != null)
                    {
                        row.Visible = row.Cells[0].Value.ToString().ToLower().Equals(filterValue.ToLower());
                    }
                }
            }
            else if (selectedItem == "Nombres")
            {
                txtBuscarClientePor.MaxLength = Constants.LIMIT_NOMBRE_LENGTH;

                foreach (DataGridViewRow row in CustomerDataGridView.Rows)
                {
                    // Ocultar las filas que no cumplan con el filtro
                    if (row.Cells[1].Value != null)
                    {
                        row.Visible = row.Cells[1].Value.ToString().ToLower().Contains(filterValue.ToLower());
                    }
                }
            }
            else if (selectedItem == "Apellidos")
            {
                txtBuscarClientePor.MaxLength = Constants.LIMIT_APELLIDO_LENGTH;

                foreach (DataGridViewRow row in CustomerDataGridView.Rows)
                {
                    // Ocultar las filas que no cumplan con el filtro
                    if (row.Cells[2].Value != null)
                    {
                        row.Visible = row.Cells[2].Value.ToString().ToLower().Contains(filterValue.ToLower());
                    }
                }
            }
            else if (selectedItem == "Teléfono")
            {
                txtBuscarClientePor.MaxLength = Constants.LIMIT_TELEF_LENGTH;
                foreach (DataGridViewRow row in CustomerDataGridView.Rows)
                {
                    // Ocultar las filas que no cumplan con el filtro
                    if (row.Cells[4].Value != null)
                    {
                        row.Visible = row.Cells[4].Value.ToString().ToLower().Contains(filterValue.ToLower());
                    }
                }
            }
        }
    }
}
