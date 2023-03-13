using SGV_CLP.Classes;
using SGV_CLP.Classes.Customers_Module;
using SGV_CLP.GUI.Customers_Module;
using System.Media;


namespace SGV_CLP.GUI
{
    public partial class UC_Customers : UserControl
    {
        List<Customer> registeredCustomers;

        int countCorrectFields, fieldsNumber;

        bool customerIDIsValid, firstLastNameIsValid, firstNameIsValid, phoneNumberIsValid, homeAddressIsValid, eMailIsValid;

        public UC_Customers()
        {
            InitializeComponent();

            registeredCustomers = CustomerMapper.GetAllCustomers();

            countCorrectFields = 0;
            fieldsNumber = 6;

            customerIDIsValid = false;
            firstLastNameIsValid = false;
            firstNameIsValid = false;
            homeAddressIsValid = false;
            phoneNumberIsValid = false;
            eMailIsValid = false;

            FillCustomerDataGridView();

            cbSearchCustomerBy.SelectedIndex = 0;

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
                    EditCustomer editCustomerWinForm = new EditCustomer(customerID);
                    editCustomerWinForm.ShowDialog();
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
            CustomerIDControl();
        }

        public void CustomerIDControl()
        {
            if (ValidationUtils.ValidarCedula(tbCustomerID.Text))
            {
                labelInvalidCustomerID.Hide();
                labelValidCustomerID.Show();
            }
            ValidateFieldsCounter();
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
            tbSearchCustomerBy.Text = string.Empty;
            if (cbSearchCustomerBy.SelectedIndex > 0)
            {
                labelSearchCustomerWithoutField.Hide();
                tbSearchCustomerBy.Enabled = true;
            }
            else
            {
                labelSearchCustomerWithoutField.Show();
                tbSearchCustomerBy.Enabled = false;
            }
        }

        private void TbSecondLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void TbEMail_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TbFirstLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void TbMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void TbFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }
        private void TbHomeAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && e.KeyChar != '.' && e.KeyChar != ';' && e.KeyChar != ' ' && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras, números, \" \", \";\" o \".\"!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void TbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void ValidateFieldsCounter()
        {
            buttonAddCustomer.Enabled = countCorrectFields >= fieldsNumber && ValidationUtils.ValidarCedula(tbCustomerID.Text);
        }

        private void TbEMail_TextChanged(object sender, EventArgs e)
        {
            if (ValidationUtils.IsValidEmail(tbEMail.Text) && !eMailIsValid)
            {
                //El correo es válido
                labelWrongEMail.Hide();
                labelCorrectEMail.Show();
                countCorrectFields++;
                eMailIsValid = true;

            }
            else if (!ValidationUtils.IsValidEmail(tbEMail.Text) && eMailIsValid)
            {
                // El correo es invalido pero fue valido anteriormente
                labelWrongEMail.Show();
                labelCorrectEMail.Hide();
                countCorrectFields--;
                eMailIsValid = false;
            }
            ValidateFieldsCounter();
        }

        private void TbPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (tbPhoneNumber.Text.Length == Constants.LIMIT_TELEF_LENGTH && !phoneNumberIsValid)
            {
                labelWrongPhoneNumberLength.Hide();
                labelCorrectPhoneNumberLength.Show();
                if (ValidationUtils.IsValidPhoneNumber(tbPhoneNumber.Text))
                {
                    labelValidPhoneNumber.Show();
                    labelInvalidPhoneNumber.Hide();
                    phoneNumberIsValid = true;
                    countCorrectFields++;
                }
                else
                {
                    labelValidPhoneNumber.Hide();
                    labelInvalidPhoneNumber.Show();
                    phoneNumberIsValid = false;
                    countCorrectFields--;
                }
            }
            else if (tbPhoneNumber.Text.Length < Constants.LIMIT_TELEF_LENGTH && phoneNumberIsValid)
            {
                labelValidPhoneNumber.Hide();
                labelInvalidPhoneNumber.Show();
                labelWrongPhoneNumberLength.Show();
                labelCorrectPhoneNumberLength.Hide();
                phoneNumberIsValid = false;
                countCorrectFields--;
            }
            ValidateFieldsCounter();
        }

        private void TbHomeAddress_TextChanged(object sender, EventArgs e)
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
            ValidateFieldsCounter();
        }

        private void TbFirstName_TextChanged(object sender, EventArgs e)
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

            ValidateFieldsCounter();
        }

        private void TbFirstLastName_TextChanged(object sender, EventArgs e)
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

            ValidateFieldsCounter();
        }

        private void TbCustomerID_TextChanged(object sender, EventArgs e)
        {
            // comprueba que la cc == 10 y muesta mensaje de correcto
            if (tbCustomerID.Text.Length == Constants.LIMIT_CC_LENGTH && !customerIDIsValid)
            {
                customerIDIsValid = true;
                countCorrectFields++;
                labelWrongCustomerIDLength.Hide();
                labelCorrectCustomerIDLength.Show();
            }
            else if (tbCustomerID.Text.Length < Constants.LIMIT_CC_LENGTH && customerIDIsValid)
            {
                // Borro 1 char de la cc teniendo ya completos los 10 previamente
                customerIDIsValid = false;
                countCorrectFields--;
                labelInvalidCustomerID.Show();
                labelWrongCustomerIDLength.Show();

                labelCorrectCustomerIDLength.Hide();
                labelValidCustomerID.Hide();
            }

            ValidateFieldsCounter();
        }

        private void TbSearchCustomerBy_TextChanged(object sender, EventArgs e)
        {
            // Obtener el valor del ComboBox
            string selectedItem = cbSearchCustomerBy.SelectedItem.ToString();

            // Obtener el valor del TextBox
            string filterValue = tbSearchCustomerBy.Text;
            // Filtrar los datos del DataGridView en función del valor del ComboBox y del TextBox
            if (selectedItem == "CI")
            {
                tbSearchCustomerBy.MaxLength = Constants.LIMIT_CC_LENGTH;

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
                tbSearchCustomerBy.MaxLength = Constants.LIMIT_NOMBRE_LENGTH;

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
                tbSearchCustomerBy.MaxLength = Constants.LIMIT_APELLIDO_LENGTH;

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
                tbSearchCustomerBy.MaxLength = Constants.LIMIT_TELEF_LENGTH;
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
