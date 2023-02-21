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
            siticoneTextBox10.Enabled = true;
            siticoneTextBox11.Enabled = true;
            siticoneTextBox12.Enabled = true;
            siticoneTextBox9.Enabled = true;
            siticoneTextBox6.Enabled = true;
            siticoneTextBox5.Enabled = true;
            siticoneTextBox7.Enabled = true;
            siticoneButton3.Visible = true;
        }

        private void siticoneButton3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Cliente Registrado con éxito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            siticoneButton3.Visible = false;
            siticoneTextBox10.Enabled = false;
            siticoneTextBox11.Enabled = false;
            siticoneTextBox12.Enabled = false;
            siticoneTextBox9.Enabled = false;
            siticoneTextBox6.Enabled = false;
            siticoneTextBox7.Enabled = false;
            siticoneTextBox5.Enabled = false;
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
