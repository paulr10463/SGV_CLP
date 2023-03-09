using SGV_CLP.Classes;
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
            isValidCategoria = false;
            isValidPE = false;
            isValidPVP = false;
            isValidRutaImg = false;

            categoria_not_choose_label.Show();
        }

        private void SBEditarProd_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            ProductoMapper.EditarProducto(cod_Producto, cBoxCategoria.Text, Convert.ToDouble(txtPE.Text, CultureInfo.InvariantCulture), Convert.ToDouble(txtPVP.Text, CultureInfo.InvariantCulture), txtImagen.Text);
            MessageBox.Show("Producto editado con éxito", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MainMenu.uc_ventas.loadProducts();
            this.Dispose();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
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
            if (cBoxCategoria.SelectedIndex >= 0)
            {
                categoria_not_choose_label.Hide();
                isValidCategoria = true;
            }
            else
            {
                categoria_not_choose_label.Show();
                isValidCategoria = false;
            }
           // ValidateProductFields();
        }
    }
}
