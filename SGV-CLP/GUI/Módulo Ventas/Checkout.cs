﻿using SGV_CLP.Classes;
using SGV_CLP.Classes.Customers_Module;
using SGV_CLP.Classes.Sales_Module;
using SGV_CLP.Classes.Sales_Module;
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
        //ListaClientes listaClientes1 = new ListaClientes();
        //listaClientes1.getClientes();
            //.ConsultarClientes();
        //listaClientes = ClienteMapper.ConsultarClientes();
        public static List<Customer> clientes = CustomerMapper.GetAllCustomers();
        AutoCompleteStringCollection listaDeSugerenciasdeAutompletacion;

        int num_atributos = 6;
        int count_correct_fields = 0;
        bool editClientIsEnabled = false;

        bool ccIsValid = false;
        bool firsLastNameIsValid = false;
        bool firstNameIsValid = false;
        bool addressIsValid = false;
        bool telefIsValid = false;
        bool correoIsValid = false;

        public Checkout(SiticoneDataGridView siticoneDataGridView)
        {
            InitializeComponent();
            foreach (DataGridViewRow rowItem in siticoneDataGridView.Rows)
            {
                DataGridViewRow row = (DataGridViewRow)rowItem.Clone();
                siticoneDataGridView1.Rows.Add(rowItem.Cells[0].Value, rowItem.Cells[1].Value, rowItem.Cells[2].Value);
            }
            setTotal(siticoneDataGridView1);
            listaDeSugerenciasdeAutompletacion = new AutoCompleteStringCollection();
            actulizarListadeSugerenciasdeAutocompletacion();

            txtCC_ClienteVenta.AutoCompleteCustomSource = listaDeSugerenciasdeAutompletacion;

            // Limitamos la longitud segun los requisitos
            txtCC_ClienteVenta.MaxLength = Constants.LIMIT_CC_LENGTH;
            txtNombre1Venta.MaxLength = Constants.LIMIT_NOMBRE_LENGTH;
            txtNombre2Venta.MaxLength = Constants.LIMIT_NOMBRE_LENGTH;
            txtApellido1Venta.MaxLength = Constants.LIMIT_APELLIDO_LENGTH;
            txtApellido2Venta.MaxLength = Constants.LIMIT_APELLIDO_LENGTH;
            txtDireccionVenta.MaxLength = Constants.LIMIT_DIRECCION_LENGTH;
            txtTelefVenta.MaxLength = Constants.LIMIT_TELEF_LENGTH;
            txtCorreoVenta.MaxLength = Constants.LIMIT_CORREO_LENGTH;

            //Hide Validations Labels
            siticoneHtmlLabel_correct_email.Hide();
            siticoneHtmlLabel_cc_valida.Hide();
            siticoneHtmlLabel_cc_correct_length.Hide();
            siticoneHtmlLabel_correct_length_telef.Hide();
            siticoneHtmlLabel_wrong_email.Hide();
            siticoneHtmlLabel_wrong_length_telef.Hide();

            ButtonAniadirClienteVenta.Enabled = false;
            ButtonConfirmarVenta.Enabled= false;

        }

        private void actulizarListadeSugerenciasdeAutocompletacion()
        {
            clientes.ForEach(a => listaDeSugerenciasdeAutompletacion.Add(a.customerID));
        }


        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            
            Customer clienteFinal = new Customer(txtCC_ClienteVenta.Text, txtNombre1Venta.Text, txtNombre2Venta.Text, txtApellido1Venta.Text, txtApellido2Venta.Text, txtDireccionVenta.Text, txtTelefVenta.Text, txtCorreoVenta.Text);
            UC_Ventas.invoice.customer = clienteFinal;
            UC_Ventas.invoice.user = MainMenu.UsuarioRegistrado;
            UC_Ventas.invoice.issuedDate = DateTime.Now;
            InvoiceMapper.AddInvoice(UC_Ventas.invoice);
            UC_Ventas.invoice.SetInvoiceDetail(InvoiceMapper.ConsultarUltimoID());
            UC_Ventas.invoice.invoiceDetailList.ForEach(item => InvoiceDetailMapper.AddInvoiceDetail(item));
            UC_Ventas.invoice = new Invoice();


            UC_Ventas.resetNumPickers();
            SystemSounds.Beep.Play();
            MessageBox.Show("Venta finalizada con éxito", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MainMenu.uc_ventas.resetValues();



            this.Dispose();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //Se presiona el boton de añadir cliente
        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            txtNombre2Venta.Enabled = true;
            txtApellido1Venta.Enabled = true;
            txtNombre1Venta.Enabled = true;
            txtApellido2Venta.Enabled = true;
            txtDireccionVenta.Enabled = true;
            txtTelefVenta.Enabled = true;
            txtCorreoVenta.Enabled = true;
            editClientIsEnabled = true;
            ButtonConfirmarVenta.Visible = true;

            txtApellido1Venta_TextChanged(null, null);
            txtNombre1Venta_TextChanged(null, null);
            txtDireccionVenta_TextChanged(null, null);
            txtTelefVenta_TextChanged(null, null);
            txtCorreoVenta_TextChanged(null, null);

            if (ValidationUtils.IsValidEmail(txtCorreoVenta.Text))
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
            txtCorreoVenta.Enabled = false;
            editClientIsEnabled = false;

            ccIsValid = false;
            firsLastNameIsValid = false;
            firstNameIsValid = false;
            addressIsValid = false;
            telefIsValid = false;
            correoIsValid = false;

            siticoneHtmlLabel_correct_length_telef.Visible= false;
            siticoneHtmlLabel_correct_email.Visible= false;
            Customer clienteNuevo = new Customer(txtCC_ClienteVenta.Text, 
                txtNombre1Venta.Text, 
                txtNombre2Venta.Text, 
                txtApellido1Venta.Text, 
                txtApellido2Venta.Text, 
                txtDireccionVenta.Text, 
                txtTelefVenta.Text, 
                txtCorreoVenta.Text);

            switch(CustomerList.FindExistentCustomer(clientes, clienteNuevo))
            {
                case 0:
                    break;
                case 1:
                    CustomerMapper.UpdateCustomer(clienteNuevo);
                    clientes = CustomerMapper.GetAllCustomers();
                    break;
                case -1:
                    CustomerMapper.AddCustomer(clienteNuevo);
                    clientes = CustomerMapper.GetAllCustomers();
                    break;
            }
            
            
            actulizarListadeSugerenciasdeAutocompletacion();
        }


        private void txtCC_ClienteVenta_KeyUp(object sender, KeyEventArgs e)
        {
            controlCedula();

            if(ValidationUtils.ValidarCedula(txtCC_ClienteVenta.Text) && txtCC_ClienteVenta.Text.Length == Constants.LIMIT_CC_LENGTH)
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
            if (ValidationUtils.ValidarCedula(txtCC_ClienteVenta.Text))
            {
                siticoneHtmlLabel_cc_invalida.Hide();
                siticoneHtmlLabel_cc_valida.Show();
            }
            validateFieldsCounter();
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

        }

        private void txtDireccionVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar!=Convert.ToChar(Keys.Space))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras o números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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

        private void txtCC_ClienteVenta_TextChanged(object sender, EventArgs e)
        {
            // comprueba que la cc == 10 y muesta mensaje de correcto
            if (txtCC_ClienteVenta.Text.Length == Constants.LIMIT_CC_LENGTH && !ccIsValid )
            {
                ccIsValid = true;
                count_correct_fields++;
                siticoneHtmlLabel_cc_wrong_length.Hide();
                siticoneHtmlLabel_cc_correct_length.Show();
            }
            else if (txtCC_ClienteVenta.Text.Length < Constants.LIMIT_CC_LENGTH && ccIsValid )
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
            bool clienteEncontrado=false;
            foreach (Customer cliente in clientes)
            {
                if(cliente != null )
                {
                    if (cliente.customerID.Equals(txtCC_ClienteVenta.Text))
                    {
                        loadCustomerFields(cliente);
                        clienteEncontrado= true;
                    }
                }
            }
            if ( !clienteEncontrado ) {
                loadCustomerFields(new Customer("0", "", "", "", "", "", "", ""));
            }
        }

        private void txtRecibidoVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) && txtRecibidoVenta.Text != null)
            {
                if (Convert.ToDouble(txtRecibidoVenta.Text) > Convert.ToDouble(txtTotalVenta.Text))
                {
                    txtVueltoVenta.Text = (Convert.ToDouble(txtRecibidoVenta.Text) - Convert.ToDouble(txtTotalVenta.Text)).ToString();
                }
                else
                {
                    txtRecibidoVenta.Text = "";
                    MessageBox.Show("El valor recibido debe ser mayor al total de la venta!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }else if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente números o \".\" !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void validateFieldsCounter()
        {
            ButtonConfirmarVenta.Enabled = count_correct_fields >= num_atributos && ValidationUtils.ValidarCedula(txtCC_ClienteVenta.Text);
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

            txtTotalVenta.Text = total.ToString();

        }


        private void loadCustomerFields(Customer cliente)
        {
            txtNombre1Venta.Text = cliente.firstName;
            txtNombre2Venta.Text = cliente.MiddleName;
            txtApellido1Venta.Text = cliente.firstLastName;
            txtApellido2Venta.Text = cliente.secondLastName;
            txtDireccionVenta.Text = cliente.homeAddress;
            txtTelefVenta.Text = cliente.phoneNumber;
            txtCorreoVenta.Text = cliente.eMail;

        }

        private void txtApellido1Venta_TextChanged(object sender, EventArgs e)
        {

            if (txtApellido1Venta.Text.Length  > 0 && !firsLastNameIsValid && editClientIsEnabled)
            {
                firsLastNameIsValid = true;
                count_correct_fields++;
            }
            else if (txtApellido1Venta.Text.Length == 0 && firsLastNameIsValid && editClientIsEnabled)
            {
                firsLastNameIsValid = false;
                count_correct_fields--;
            }

            validateFieldsCounter();
        }

        private void txtDireccionVenta_TextChanged(object sender, EventArgs e)
        {
            if (txtDireccionVenta.Text.Length > 0 && !addressIsValid && editClientIsEnabled)
            {
                addressIsValid = true;
                count_correct_fields++;
            }
            else if (txtDireccionVenta.Text.Length == 0 && addressIsValid && editClientIsEnabled)
            {
                addressIsValid = false;
                count_correct_fields--;
            }

            validateFieldsCounter();
        }

        private void txtTelefVenta_TextChanged(object sender, EventArgs e)
        {

            if (txtTelefVenta.Text.Length  == Constants.LIMIT_TELEF_LENGTH && !telefIsValid && editClientIsEnabled)
            {
                telefIsValid = true;
                count_correct_fields++;
                siticoneHtmlLabel_wrong_length_telef.Hide();
                siticoneHtmlLabel_correct_length_telef.Show();
            }
            else if (txtTelefVenta.Text.Length != Constants.LIMIT_TELEF_LENGTH && telefIsValid && editClientIsEnabled)
            {
                telefIsValid = false;
                count_correct_fields--;
                siticoneHtmlLabel_wrong_length_telef.Show();
                siticoneHtmlLabel_correct_length_telef.Hide();
            }

            validateFieldsCounter();
        }

        private void txtCorreoVenta_TextChanged(object sender, EventArgs e)
        {
            if (ValidationUtils.IsValidEmail(txtCorreoVenta.Text) && !correoIsValid && editClientIsEnabled)
            {
                //El correo es válido
                siticoneHtmlLabel_wrong_email.Hide();
                siticoneHtmlLabel_correct_email.Show();
                count_correct_fields++;
                correoIsValid = true;

            }
            else if (!ValidationUtils.IsValidEmail(txtCorreoVenta.Text) && correoIsValid && editClientIsEnabled)
            {
                // El correo es invalido pero fue valido anteriormente
                siticoneHtmlLabel_wrong_email.Show();
                siticoneHtmlLabel_correct_email.Hide();
                count_correct_fields--;
                correoIsValid = false;
            }
            validateFieldsCounter();
        }

        private void txtNombre1Venta_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre1Venta.Text.Length > 0 && !firstNameIsValid && editClientIsEnabled)
            {
                firstNameIsValid = true;
                count_correct_fields++;
            }
            else if (txtNombre1Venta.Text.Length == 0 && firstNameIsValid && editClientIsEnabled)
            {
                firstNameIsValid = false;
                count_correct_fields--;
            }

            validateFieldsCounter();
        }

        private void siticoneCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneCheckBox1.Checked)
            {
                txtCC_ClienteVenta.Enabled = false;
                txtCC_ClienteVenta.Text = "0000000000";
                siticoneHtmlLabel_cc_valida.Visible= false;
                siticoneHtmlLabel_cc_invalida.Visible = false;
                siticoneHtmlLabel_cc_wrong_length.Visible = false;
                siticoneHtmlLabel_cc_correct_length.Visible = false;
            }
            else
            {
                txtCC_ClienteVenta.Enabled = true;
                txtCC_ClienteVenta.Text = string.Empty;
                txtCC_ClienteVenta_TextChanged(null, null);
            }
        }
    }
}
