using SGV_CLP.Classes;
using SGV_CLP.Classes.Modulo_Ventas;
using SGV_CLP.GUI.Módulo_Ventas;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SGV_CLP.GUI
{
    public partial class UC_Ventas : UserControl
    {
        public static int numeroFactura = 2;
        
        
        List<Producto> especialidades;
        List<Producto> bebidasCalientes;
        public static List<Cliente> clientes = new List<Cliente>
        {
            new Cliente("1725656431", "Paul", "Alexander", "Román", "Quimbiulco", "La kennedy", "0983472881", "paulroman3d@gmail.com"),
            new Cliente("1714818299", "Ernesto", "Alexander", "Perez", "Quimbiulco", "La Rumiñahui", "0983421213", "ernestoperez@gmail.com"),
            new Cliente("1713627071", "Maria", "Alexander", "Uribe", "Quimbiulco", "La Rumiñahui", "0983421213", "ernestoperez@gmail.com"),
        };
        public static List<TotalVenta> notasVenta = new List<TotalVenta>()
        {
             new TotalVenta(clientes[0], "NV1", "Efectivo", 20.25, "12/02/2022")
        };   
       
        public UC_Ventas()
        {
            InitializeComponent();
            especialidades = new List<Producto>
            {
                new Producto("TAM", "Tamal", 0.5, 1.25, "Especialidades", 0, null),
                new Producto("HUM", "Humita", 0.5, 1.5, "Especialidades", 0, null),
                new Producto("QUIM", "Quimbolito", 0.5, 1, "Especialidades", 0, null)

            };

            /*
            especialidades.Add(new Producto("Tamal", "Tamal"));
            especialidades.Add(new Producto("Humita", "Humita"));
            especialidades.Add(new Producto("Empanadas Viento", "Empanadas Viento"));
            especialidades.Add(new Producto("Humita Frita", "HumitaFrita"));
            */

            bebidasCalientes = new List<Producto>()
            {
                new Producto("CAFE", "Café", 0.5, 0.75, "Bebidas", 0, null),
                new Producto("CHOC", "Chocolate", 0.5, 1.25, "Bebidas", 0, null),
                new Producto("MORO", "Morocho", 0.5, 1, "Bebidas", 0, null)

            };
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            Checkout ventana = new Checkout(siticoneDataGridView2);
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

        public void resetValues()
        {
            siticoneNumericUpDown1.Value= 0;
            siticoneNumericUpDown2.Value = 0;
            siticoneNumericUpDown3.Value = 0;
            siticoneNumericUpDown4.Value = 0;
            siticoneNumericUpDown5.Value = 0;
            siticoneNumericUpDown6.Value = 0;
            siticoneDataGridView2.Rows.Clear();
            siticoneHtmlLabel11.Visible = false;
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
            siticoneHtmlLabel11.Visible = true;
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

            siticoneHtmlLabel11.Text = "Total:      $"+ total.ToString();

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
            if (ComboBox_ConsultarVentaPor.SelectedIndex != -1)
            {
                siticoneHtmlLabel_buscarCliente_sin_campo.Hide();
            }
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

        private void txtConsultarVenta_TextChanged(object sender, EventArgs e)
        {


        }
        private void siticoneTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool flag = false;
            List<string> codFacturaList =new List<string>();
            foreach (DataGridViewRow rowItem in siticoneDataGridView1.Rows)
            {
                if (rowItem.Cells[0].Value != null)
                {
                    codFacturaList.Add((string)rowItem.Cells[0].Value);
                }

            }


            foreach (TotalVenta totalVenta in notasVenta)
            {
                if (!codFacturaList.Contains(totalVenta.codFactura))
                {
                    DataGridViewRow row = (DataGridViewRow)siticoneDataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = totalVenta.codFactura;
                    row.Cells[1].Value = totalVenta.cliente.Cc_Cliente;
                    row.Cells[2].Value = totalVenta.cliente.Primer_Nombre;
                    row.Cells[3].Value = totalVenta.cliente.Primer_Apellido;
                    row.Cells[4].Value = totalVenta.cliente.Telefono;
                    row.Cells[5].Value = totalVenta.formaPago;
                    row.Cells[6].Value = totalVenta.precioFinal;
                    row.Cells[7].Value = totalVenta.fechaVenta;
                    siticoneDataGridView1.Rows.Add(row);
                }
                
            }
        }

        private void siticoneTabControl1_TabIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
