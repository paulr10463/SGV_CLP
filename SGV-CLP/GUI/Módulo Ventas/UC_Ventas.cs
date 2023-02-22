using SGV_CLP.Classes;
using SGV_CLP.GUI.Módulo_Ventas;
using Siticone.Desktop.UI.AnimatorNS;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SGV_CLP.GUI
{
    public partial class UC_Ventas : UserControl
    {
        List<Producto> especialidades;
        List<Producto> bebidasCalientes;
        List<NotaVenta> notasDeVenta;
        NotaVenta notaDeVenta;

        int limit_cc_length = 10;
        bool control_cc = true;

        int num_atributos = 8;
        int count_correct_fields = 0;

        public UC_Ventas()
        {
            InitializeComponent();
            SBRealizarPago.Enabled = false;

            txtCC_ClienteVenta.MaxLength = limit_cc_length;

            siticoneHtmlLabel_cc_valida.Hide();
            siticoneHtmlLabel_cc_correct_length.Hide();

            especialidades = new List<Producto>();
            especialidades.Add(new Producto("TAM", "Tamal", 0.5, 1.25, "Especialidades", 0, null));
            especialidades.Add(new Producto("HUM", "Humita", 0.5, 1.5, "Especialidades", 0, null));
            especialidades.Add(new Producto("QUIM", "Quimbolito", 0.5, 1, "Especialidades", 0, null));
            /*
            especialidades.Add(new Producto("Tamal", "Tamal"));
            especialidades.Add(new Producto("Humita", "Humita"));
            especialidades.Add(new Producto("Empanadas Viento", "Empanadas Viento"));
            especialidades.Add(new Producto("Humita Frita", "HumitaFrita"));
            */

            bebidasCalientes = new List<Producto>();
            bebidasCalientes.Add(new Producto("CAFE", "Café", 0.5, 0.75, "Bebidas", 0, null));
            bebidasCalientes.Add(new Producto("CHOC", "Chocolate", 0.5, 1.25, "Bebidas", 0, null));
            bebidasCalientes.Add(new Producto("MORO", "Morocho", 0.5, 1, "Bebidas", 0, null));



            Cliente cliente = new Cliente("1725651518", "Paul", "Alexander", "Román", "Quimbiulco", "La kennedy", "0983472881", "paulroman3d@gmail.com");
            Cliente cliente1 = new Cliente("1825651521", "Ernesto", "Alexander", "Perez", "Quimbiulco", "La Rumiñahui", "0983421213", "ernestoperez@gmail.com");
            Cliente cliente2 = new Cliente("1715651521", "Maria", "Alexander", "Uribe", "Quimbiulco", "La Rumiñahui", "0983421213", "ernestoperez@gmail.com");
            Cliente clienteVacio = new Cliente("0", "", "", "", "", "", "", "");

            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            lista.Add(cliente.Cc_Cliente);
            lista.Add(cliente1.Cc_Cliente);
            lista.Add(cliente2.Cc_Cliente);
            txtCC_ClienteVenta.AutoCompleteCustomSource = lista;
            
            notasDeVenta = new List<NotaVenta>();
        }

        public void llenarTablaVentas()
        {
            if (notasDeVenta != null)
            {
                siticoneDataGridView1.Rows.Clear();
                foreach (NotaVenta notaVenta in notasDeVenta)
                {
                    // dgvClientes
                    siticoneDataGridView1.Rows.Add(notaVenta.Cc_Cliente, notaVenta.Total_Venta, notaVenta.Fecha);
                }
            }
        }

        private void SBRealizarPago_Click(object sender, EventArgs e)
        {
            if (notaDeVenta != null)
            {
                notasDeVenta.Add(notaDeVenta);
            }

            Checkout ventana = new Checkout(siticoneDataGridView2, ref notaDeVenta);
            ventana.ShowDialog();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            addRowInTable(siticoneNumericUpDown1, especialidades[0]);
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            addRowInTable(siticoneNumericUpDown2, especialidades[1]);
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            addRowInTable(siticoneNumericUpDown3, especialidades[2]);
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            addRowInTable(siticoneNumericUpDown4, bebidasCalientes[0]);
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            addRowInTable(siticoneNumericUpDown5, bebidasCalientes[1]);
        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            addRowInTable(siticoneNumericUpDown6, bebidasCalientes[2]);
        }

        public void addRowInTable(SiticoneNumericUpDown cantidad, Producto producto)
        {
            bool flag = false;

            foreach (DataGridViewRow rowItem in siticoneDataGridView2.Rows)
            {
                if (rowItem.Cells[0].Value != null)
                {
                    if (rowItem.Cells[0].Value.Equals(producto.Nombre))
                    {
                        rowItem.Cells[1].Value = (int)cantidad.Value;
                        rowItem.Cells[2].Value = producto.PVP * (int)cantidad.Value;
                        flag = true;
                    }
                }
                else
                {
                    break;
                }
            }
            if (!flag)
            {
                DataGridViewRow row = (DataGridViewRow)siticoneDataGridView2.Rows[0].Clone();
                row.Cells[0].Value = producto.Nombre;
                row.Cells[1].Value = (int)cantidad.Value;
                row.Cells[2].Value = producto.PVP * (int)cantidad.Value;
                siticoneDataGridView2.Rows.Add(row);
            }
            setTotal(siticoneDataGridView2);

        }

        public void setTotal(SiticoneDataGridView tablaVenta)
        {
            double total = 0;
            foreach (DataGridViewRow rowItem in siticoneDataGridView2.Rows)
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

            siticoneHtmlLabel11.Text = "Total:      $" + total.ToString();

        }


        private void txtConsultarVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (ComboBox_ConsultarVentaPor.SelectedIndex)
            {
                case 0:
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Ingrese únicamente números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
                case 1:
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Ingrese únicamente números o \"-\" (siga el formato aaaa-mm-dd)!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
                case 2:
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Ingrese únicamente números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
                case 3:
                    if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Ingrese únicamente letras!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
                case 4:
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Ingrese únicamente números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
                default:
                    if (ComboBox_ConsultarVentaPor.SelectedIndex == -1) e.Handled = true;
                    break;
            }
        }


        private void ComboBox_ConsultarVentaPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtConsultarVenta.Text = System.String.Empty;
        }

        private void siticoneHtmlLabel9_Click(object sender, EventArgs e)
        {

        }

        private void siticoneHtmlLabel10_Click(object sender, EventArgs e)
        {

        }

        private void siticoneHtmlLabel8_Click(object sender, EventArgs e)
        {

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

        private void validateFieldsCounter()
        {
            SBRealizarPago.Enabled = count_correct_fields >= num_atributos && ValidarCedula(txtCC_ClienteVenta.Text);
        }

        private void txtCC_ClienteVenta_TextChanged(object sender, EventArgs e)
        {
            // comprueba que la cc == 10 y muesta mensaje de correcto
            if (txtCC_ClienteVenta.Text.Length == limit_cc_length && control_cc)
            {
                control_cc = false;
                count_correct_fields++;
                siticoneHtmlLabel_cc_wrong_length.Hide();
                
                siticoneHtmlLabel_cc_correct_length.Show();
            }
            else if (txtCC_ClienteVenta.Text.Length < limit_cc_length && !control_cc)
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

            /*if (txtCC_ClienteVenta.Text.Equals("1725651518"))
            {
                loadCustomerFields(cliente);
            }
            else
            if (txtCC_ClienteVenta.Text.Equals("1825651521"))
            {
                loadCustomerFields(cliente1);
            }
            else
            if (txtCC_ClienteVenta.Text.Equals("1715651521"))
            {
                loadCustomerFields(cliente2);
            }
            else
            {
                loadCustomerFields(clienteVacio);
            }*/
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

        private void txtCC_ClienteVenta_KeyUp(object sender, KeyEventArgs e)
        {
            controlCedula();

            if (ValidarCedula(txtCC_ClienteVenta.Text) && txtCC_ClienteVenta.Text.Length == limit_cc_length)
            {
                SBRealizarPago.Enabled = true;
            }
            else
            {
                SBRealizarPago.Enabled = false;
            }
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

        /*private void loadCustomerFields(Cliente cliente)
        {
            txtNombre1Venta.Text = cliente.Primer_Nombre;
            txtNombre2Venta.Text = cliente.Segundo_Nombre;
            txtApellido1Venta.Text = cliente.Primer_Apellido;
            txtApellido2Venta.Text = cliente.Segundo_Apellido;
            txtDireccionVenta.Text = cliente.Direccion_Domicilio;
            txtTelefVenta.Text = cliente.Telefono;
            txtCorreoVenta.Text = cliente.Correo_Electronico;

        }*/
    }
}
