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

namespace SGV_CLP.GUI.Módulo_Producto
{
    public partial class Editar_Lote : Form
    {
        bool isValidCantidad, isValidFechaHora; // Para validar los campos de Lote
        string cod_Lote;

        public Editar_Lote(string cod_Lote)
        {
            InitializeComponent();
            this.cod_Lote = cod_Lote;

            isValidCantidad = false;
            isValidFechaHora = false;

            SBAceptar.Enabled = false;

            FechaHora_not_choose_in_Lote_label.Show();
        }

        private void ValidateLotFields()
        {
            if (isValidCantidad && isValidFechaHora)
            {
                SBAceptar.Enabled = true;
            }
            else
            {
                SBAceptar.Enabled = false;
            }
        }

        private void SBAceptar_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            MessageBox.Show("Lote editado con éxito", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }


        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (!txtCantidad.Text.Equals(string.Empty))
            {
                isValidCantidad = true;
            }
            else
            {
                isValidCantidad = false;
            }
            ValidateLotFields();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Cantidad inválida – solo se permiten caracteres numéricos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void SRBFechaActual_CheckedChanged(object sender, EventArgs e)
        {
            DTPFechaLote.Visible = false;
            DTPHoraLote.Visible = false;
            FechaHora_not_choose_in_Lote_label.Visible = false;
            isValidFechaHora = true;
            ValidateLotFields();
        }

        private void SRBElegirFecha_CheckedChanged(object sender, EventArgs e)
        {
            DTPFechaLote.Visible = true;
            DTPHoraLote.Visible = true;
            FechaHora_not_choose_in_Lote_label.Visible = false;
            isValidFechaHora = true;
            ValidateLotFields();
        }
    }
}
