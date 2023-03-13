using SGV_CLP.Classes;
using SGV_CLP.Classes.Products_module;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SGV_CLP.GUI
{
    public partial class Editar_Producto : Form
    {
        string cod_Producto;
        bool isValidCategoria, isValidPE, isValidPVP, isValidRutaImg; // Para validar los campos de los productos
        public Editar_Producto(string cod_Producto)
        {
            InitializeComponent();

            this.cod_Producto = cod_Producto;

            txtPE.Text = ProductMapper.GetProductField(cod_Producto, "precio_Elaboracion").Replace(",", ".");
            txtPVP.Text = ProductMapper.GetProductField(cod_Producto, "precio_Unitario").Replace(",", ".");
            txtImagen.Text = ProductMapper.GetProductField(cod_Producto, "ruta_Imagen");
            
            foreach (var item in cBoxCategoria.Items)
            {
                if ( item.ToString() == ProductMapper.GetProductField(cod_Producto, "categoria"))
                {
                    cBoxCategoria.SelectedIndex = cBoxCategoria.Items.IndexOf(item.ToString());
                }
            };

            isValidCategoria = true;
            isValidPE = true;
            isValidPVP = true;
            isValidRutaImg = true;

            txtImagen.MaxLength = Constants.LIMIT_RUTAIMAGEN_LENGTH;

            SBEditarProd.Enabled = false;
        }

        private void SBExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = dlg.FileName;
                txtImagen.Text = fileName;
            }
        }

        private void SBEditarProd_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            ProductMapper.EditProduct(cod_Producto, cBoxCategoria.Text, Convert.ToDouble(txtPE.Text, CultureInfo.InvariantCulture), Convert.ToDouble(txtPVP.Text, CultureInfo.InvariantCulture), txtImagen.Text);
            MessageBox.Show("Producto editado con éxito", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MainMenu.uc_ventas.loadProducts();
            this.Dispose();
        }

        private void SBCancelarEditarProd_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // Validaciones de atributos
        private void ValidateProductFields()
        {
            if (isValidPE && isValidPVP && isValidCategoria && isValidRutaImg)
            {
                SBEditarProd.Enabled = ValidationUtils.ValidarPvpMayorIgualPe(txtPVP.Text, txtPE.Text);
            }
            else
            {
                SBEditarProd.Enabled = false;
            }
        }

        private void cBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxCategoria.SelectedIndex > 0)
            {
                categoria_not_choose_label.Hide();
                isValidCategoria = true;
            }
            else
            {
                categoria_not_choose_label.Show();
                isValidCategoria = false;
            }
            ValidateProductFields();
        }

        private void TxtPE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Precio de elaboración inválido – solo se permiten caracteres numéricos y la \".\"", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void TxtPE_TextChanged(object sender, EventArgs e)
        {
            // Valida si hay un double en el campo
            if (ValidationUtils.IsValidDouble(txtPE.Text))
            {
                PE_not_valid_label.Hide();

                // Valida si el valor del campo de PVP es ">=" al valor del campo PE
                if (ValidationUtils.ValidarPvpMayorIgualPe(txtPVP.Text, txtPE.Text))
                {
                    PVP_not_greater_than_PE_label.Hide();
                }
                else
                {
                    PVP_not_greater_than_PE_label.Show();
                }
                isValidPE = true;
            }
            else
            {
                PE_not_valid_label.Show();
                isValidPE = false;
            }
            ValidateProductFields();
        }

        private void TxtPVP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("P.V.P. inválido – solo se permiten caracteres numéricos y la \".\"", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void TxtPVP_TextChanged(object sender, EventArgs e)
        {
            // Valida si hay un double en el campo
            if (ValidationUtils.IsValidDouble(txtPVP.Text))
            {
                PVP_not_valid_label.Hide();

                // Valida si el valor del campo de PVP es ">=" al valor del campo PE
                if (ValidationUtils.ValidarPvpMayorIgualPe(txtPVP.Text, txtPE.Text))
                {
                    PVP_not_greater_than_PE_label.Hide();
                }
                else
                {
                    PVP_not_greater_than_PE_label.Show();
                }
                isValidPVP = true;
            }
            else
            {
                PVP_not_valid_label.Show();
                isValidPVP = false;
            }
            ValidateProductFields();
        }

        private void TxtImagen_TextChanged(object sender, EventArgs e)
        {
            // Valida si el valor del campo es una ruta válida 
            if (ValidationUtils.IsValidPath(txtImagen.Text))
            {
                rutaImagen_not_valid_label.Hide();
                isValidRutaImg = true;
            }
            else
            {
                rutaImagen_not_valid_label.Show();
                isValidRutaImg = false;
            }
            ValidateProductFields();
        }
    }
}
