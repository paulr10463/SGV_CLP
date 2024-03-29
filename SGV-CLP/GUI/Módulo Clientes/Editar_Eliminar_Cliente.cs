﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGV_CLP.GUI.Módulo_Clientes
{
    public partial class Editar_Eliminar_Cliente : Form
    {
        String cedulaCliente;
        int limit_telef_length = 10, limit_direc_length = 100;
        bool control_direc = true;
        bool control_telef = true;

        int count_correct_fields = 0;

        int num_atributos = 2;
        public Editar_Eliminar_Cliente(String cedula)
        {
            InitializeComponent();
            cedulaCliente = cedula;

            txtEditarEliminarDirecCliente.MaxLength = limit_direc_length;
            txtEditarEliminarClienteTelef.MaxLength = limit_telef_length;

            button_AceptarEditarEliminarCliente.Enabled = false;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            MessageBox.Show("Cliente editado con éxito", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Cliente eliminado con éxito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Cliente no eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtEditarEliminarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras o números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtEditarEliminarDirecCliente.Text.Length + 1 > 0 && control_direc && e.KeyChar != '\b')
            {
                control_direc = false;
                count_correct_fields++;
            }
            else if (txtEditarEliminarDirecCliente.Text.Length - 1 == 0 && !control_direc && e.KeyChar == '\b')
            {
                control_direc = true;
                count_correct_fields--;
            }

            validateFieldsCounter();
        }

        private void txtEditarEliminarTelef_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtEditarEliminarClienteTelef.Text.Length + 1 == limit_telef_length && control_telef && e.KeyChar != '\b')
            {
                control_telef = false;
                count_correct_fields++;
            }
            else if (txtEditarEliminarClienteTelef.Text.Length - 1 != limit_telef_length && !control_telef && e.KeyChar == '\b')
            {
                control_telef = true;
                count_correct_fields--;
            }

            validateFieldsCounter();
        }

        private void validateFieldsCounter()
        {
            button_AceptarEditarEliminarCliente.Enabled = count_correct_fields >= num_atributos;
        }
    }
}
