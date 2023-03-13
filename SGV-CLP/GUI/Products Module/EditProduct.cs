﻿using SGV_CLP.Classes;
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
    public partial class EditProduct : Form
    {
        string productCode;

        bool categoryIsValid, productionPriceIsValid, salesPriceToThePubicIsValid, imagePathIsValid; // Para validar los campos de los productos

        public EditProduct(string productCode)
        {
            InitializeComponent();

            this.productCode = productCode;

            categoryIsValid = true;
            productionPriceIsValid = true;
            salesPriceToThePubicIsValid = true;
            imagePathIsValid = true;

            tbProductionPrice.Text = ProductMapper.GetProductField(productCode, "precio_Elaboracion").Replace(",", ".");
            tbSalesPriceToThePublic.Text = ProductMapper.GetProductField(productCode, "precio_Unitario").Replace(",", ".");
            tbImagePath.Text = ProductMapper.GetProductField(productCode, "ruta_Imagen");

            foreach (var item in cbCategory.Items)
            {
                if (item.ToString() == ProductMapper.GetProductField(productCode, "categoria"))
                {
                    cbCategory.SelectedIndex = cbCategory.Items.IndexOf(item.ToString());
                }
            };

            tbImagePath.MaxLength = Constants.LIMIT_RUTAIMAGEN_LENGTH;

            buttonEditProduct.Enabled = false;
        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = dlg.FileName;
                tbImagePath.Text = fileName;
            }
        }

        private void ButtonEditProduct_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            ProductMapper.EditProduct(productCode, cbCategory.Text, Convert.ToDouble(tbProductionPrice.Text, CultureInfo.InvariantCulture), Convert.ToDouble(tbSalesPriceToThePublic.Text, CultureInfo.InvariantCulture), tbImagePath.Text);
            MessageBox.Show("Producto editado con éxito", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        // Validaciones de atributos
        private void ValidateProductFields()
        {
            if (productionPriceIsValid && salesPriceToThePubicIsValid && categoryIsValid && imagePathIsValid)
            {
                buttonEditProduct.Enabled = ValidationUtils.ValidarPvpMayorIgualPe(tbSalesPriceToThePublic.Text, tbProductionPrice.Text);
            }
            else
            {
                buttonEditProduct.Enabled = false;
            }
        }

        private void CbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategory.SelectedIndex > 0)
            {
                labelCategoryNotChosen.Hide();
                categoryIsValid = true;
            }
            else
            {
                labelCategoryNotChosen.Show();
                categoryIsValid = false;
            }
            ValidateProductFields();
        }

        private void TbProductionPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Precio de elaboración inválido – solo se permiten caracteres numéricos y el \".\"", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void TbProductionPrice_TextChanged(object sender, EventArgs e)
        {
            // Valida si hay un double en el campo
            if (ValidationUtils.IsValidDouble(tbProductionPrice.Text))
            {
                labelInvalidProductionPrice.Hide();

                // Valida si el valor del campo de PVP es ">=" al valor del campo PE
                if (ValidationUtils.ValidarPvpMayorIgualPe(tbSalesPriceToThePublic.Text, tbProductionPrice.Text))
                {
                    LabelSPPNotGreaterThanPP.Hide();
                }
                else
                {
                    LabelSPPNotGreaterThanPP.Show();
                }
                productionPriceIsValid = true;
            }
            else
            {
                labelInvalidProductionPrice.Show();
                productionPriceIsValid = false;
            }
            ValidateProductFields();
        }

        private void TbSalesPriceToThePublic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("P.V.P. inválido – solo se permiten caracteres numéricos y la \".\"", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void TbSalesPriceToThePublic_TextChanged(object sender, EventArgs e)
        {
            // Valida si hay un double en el campo
            if (ValidationUtils.IsValidDouble(tbSalesPriceToThePublic.Text))
            {
                labelInvalidSalesPriceToThePublic.Hide();

                // Valida si el valor del campo de PVP es ">=" al valor del campo PE
                if (ValidationUtils.ValidarPvpMayorIgualPe(tbSalesPriceToThePublic.Text, tbProductionPrice.Text))
                {
                    LabelSPPNotGreaterThanPP.Hide();
                }
                else
                {
                    LabelSPPNotGreaterThanPP.Show();
                }
                salesPriceToThePubicIsValid = true;
            }
            else
            {
                labelInvalidSalesPriceToThePublic.Show();
                salesPriceToThePubicIsValid = false;
            }
            ValidateProductFields();
        }

        private void TbImagePath_TextChanged(object sender, EventArgs e)
        {
            // Valida si el valor del campo es una ruta válida 
            if (ValidationUtils.IsValidPath(tbImagePath.Text))
            {
                labelInvalidImagePath.Hide();
                imagePathIsValid = true;
            }
            else
            {
                labelInvalidImagePath.Show();
                imagePathIsValid = false;
            }
            ValidateProductFields();
        }
    }
}