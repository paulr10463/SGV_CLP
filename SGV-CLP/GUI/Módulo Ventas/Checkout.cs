﻿using Siticone.Desktop.UI.WinForms;
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
        public Checkout()
        {
            InitializeComponent();
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
            siticoneButton3.Visible= true;
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
            siticoneTextBox5.Enabled = false;
        }
    }
}
