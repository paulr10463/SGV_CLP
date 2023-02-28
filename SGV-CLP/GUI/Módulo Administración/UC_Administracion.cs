using SGV_CLP.Classes;
using SGV_CLP.Classes.Módulo_Administración;
using SGV_CLP.GUI.Módulo_Administración;
using SGV_CLP.GUI.Módulo_Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGV_CLP.GUI
{
    public partial class UC_Administracion : UserControl
    {
        List<Usuario> UsuariosRegistrados = new List<Usuario>();
        List<ParametroPorUnidad> ParamsPURegistrados = new List<ParametroPorUnidad>();
        List<ParametroPorcentaje> ParamsPORegistrados = new List<ParametroPorcentaje>();
        int count_correct_fields = 0, num_atributos = 8;

        // Nombre de usuario
        int min_long_nombre_user = 5, max_long_nombre_user = 30;
        bool control_nombre_user = true;

        // CC de usuario
        int max_long_cc = 10;
        bool control_cc = true;

        // Contraseña
        int min_long_contra = 10, max_long_contra = 30;
        bool control_contra = true;

        // Nombres
        int max_long_nombres = 50;
        bool control_nombre1 = true, control_nombre2 = true;

        // Apellidos
        int max_long_apellidos = 50;
        bool control_apell1 = true, control_apell2 = true;

        // Cargo
        bool control_cargo = true;

        public UC_Administracion()
        {
            InitializeComponent();

            siticoneHtmlLabel_correct_length_nombreuser.Hide();
            siticoneHtmlLabel_ccUser_valida.Hide();
            siticoneHtmlLabel_ccUser_correct_length.Hide();
            siticoneHtmlLabel_correct_length_contra.Hide();

            txtAniadirNombreUsuario.MaxLength = max_long_nombre_user;
            txtAniadirCCUsuario.MaxLength = max_long_cc;
            txtAniadirContraseniaUsuario.MaxLength = max_long_contra;
            txtAniadirNombre1Usuario.MaxLength = max_long_nombres;
            txtAniadirNombre2Usuario.MaxLength = max_long_nombres;
            txtAniadirApellido1Usuario.MaxLength = max_long_apellidos;
            txtAniadirApellido2Usuario.MaxLength = max_long_apellidos;

            Button_aniadirUsuario.Enabled = false;

            Usuario us1 = new Usuario("admin01", "1234567890", "1234567890", "Luis", "Joel", "Guingla", "Verdezoto", "admin");
            Usuario us2 = new Usuario("cajero01", "0987654321", "0987654321", "Paul", "Alexander", "Roman", "Quimbiulco", "cajero");
            Usuario us3 = new Usuario("cajero02", "1234567890", "1234567890", "George", "Mattheus", "Quishpe", "Hidalgo", "cajero");

            UsuariosRegistrados.Add(us1);
            UsuariosRegistrados.Add(us2);
            UsuariosRegistrados.Add(us3);
      
            llenarTablaUsuario();

            ParametroPorUnidad paramPU1 = new ParametroPorUnidad("1", "10", "2", "Humita");
            ParametroPorUnidad paramPU2 = new ParametroPorUnidad("2", "5", "1", "Quimbolito");
            ParametroPorUnidad paramPU3 = new ParametroPorUnidad("3", "3", "1", "Tamal");

            ParamsPURegistrados.Add(paramPU1);
            ParamsPURegistrados.Add(paramPU2);
            ParamsPURegistrados.Add(paramPU3);

            llenarTablaParamUnidad();

            ParametroPorcentaje paramP1 = new ParametroPorcentaje("1", "Humita", 10);
            ParametroPorcentaje paramP2 = new ParametroPorcentaje("2", "Tamal", 20);

            ParamsPORegistrados.Add(paramP1);
            ParamsPORegistrados.Add(paramP2);

            llenarTablaParamPorcentaje();
        }

        public void vaciarCampos()
        {
            txtAniadirNombreUsuario.Text = string.Empty;
            txtAniadirCCUsuario.Text = string.Empty;
            txtAniadirContraseniaUsuario.Text = string.Empty;
            txtAniadirNombre1Usuario.Text = string.Empty;
            txtAniadirNombre2Usuario.Text = string.Empty;
            txtAniadirApellido1Usuario.Text = string.Empty;
            txtAniadirApellido2Usuario.Text = string.Empty;
            siticoneComboBox_aniadirCargoUsuario.SelectedIndex = -1;
            control_cargo = true;
            count_correct_fields = 0;

            validateFieldsCounter();
        }

        public void llenarTablaUsuario()
        {
            if (UsuariosRegistrados != null)
            {
                SDGVUsuario.Rows.Clear();
                // UsuariosRegistrados = ClienteMapper.ConsultarClientes();
                foreach (Usuario usuario in UsuariosRegistrados)
                {
                    // dgvClientes
                    SDGVUsuario.Rows.Add(usuario.userName, usuario.cc_Usuario, usuario.primer_Nombre + usuario.segundo_Nombre, usuario.primer_Apellido + usuario.segundo_Apellido, usuario.cargo);
                }
            }
        }
        
        public void llenarTablaParamUnidad()
        {
            if (ParamsPURegistrados != null)
            {
                SDGVParamUnidad.Rows.Clear();
                // UsuariosRegistrados = ClienteMapper.ConsultarClientes();
                foreach (ParametroPorUnidad param in ParamsPURegistrados)
                {
                    SDGVParamUnidad.Rows.Add(param.IdParametro, param.UnidadBase, param.UnidadExtra, param.Producto);
                }
            }
        }

        public void llenarTablaParamPorcentaje()
        {
            if (ParamsPORegistrados != null)
            {
                SDGVParamPorcen.Rows.Clear();
                // UsuariosRegistrados = ClienteMapper.ConsultarClientes();
                foreach (ParametroPorcentaje paraP in ParamsPORegistrados)
                {
                    SDGVParamPorcen.Rows.Add(paraP.IdParametro, paraP.Producto, paraP.Porcentaje);
                }
            }
        }

        private void Button_aniadirUsuario_Click(object sender, EventArgs e)
        {

            UsuarioMapper.IngresarUsuario(new Usuario(txtAniadirCCUsuario.Text,
                txtAniadirNombreUsuario.Text,
                txtAniadirContraseniaUsuario.Text,
                txtAniadirNombre1Usuario.Text,
                txtAniadirNombre2Usuario.Text,
                txtAniadirApellido1Usuario.Text,
                txtAniadirApellido2Usuario.Text,
                siticoneComboBox_aniadirCargoUsuario.Text));

            SystemSounds.Beep.Play();
            MessageBox.Show("Usuario añadido con éxito", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            vaciarCampos();
        }

        private void Button_ModificarUsuario_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            MessageBox.Show("Usuario modificado con éxito", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button_EliminarUsuario_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            if (MessageBox.Show("¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                MessageBox.Show("Usuario eliminado con éxito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Button_aniadirParamUnid_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            MessageBox.Show("Parámetro añadido con éxito", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button_aniadirParamPorc_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            MessageBox.Show("Parámetro añadido con éxito", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button_aniadirModificarParamUnid_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            MessageBox.Show("Parámetro modificado con éxito", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Burron_ModificarParamPorc_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            MessageBox.Show("Parámetro modificado con éxito", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button_EliminarParam_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            if (MessageBox.Show("¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                MessageBox.Show("Parámetro eliminado con éxito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtAniadirNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras o números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtAniadirNombreUsuario.Text.Length + 1 >= min_long_nombre_user && control_nombre_user && e.KeyChar != '\b')
            {
                control_nombre_user = false;
                count_correct_fields++;
                siticoneHtmlLabel_wrong_length_nombreuser.Hide();
                siticoneHtmlLabel_correct_length_nombreuser.Show();
            }else if (txtAniadirNombreUsuario.Text.Length - 1 < min_long_nombre_user && !control_nombre_user && e.KeyChar == '\b')
            {
                control_nombre_user = true;
                count_correct_fields--;
                siticoneHtmlLabel_wrong_length_nombreuser.Show();
                siticoneHtmlLabel_correct_length_nombreuser.Hide();
            }
            validateFieldsCounter();
        }

        private void txtAniadirCCUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // comprueba que la cc == 10 y muesta mensaje de correcto
            if (txtAniadirCCUsuario.Text.Length + 1 == max_long_cc && control_cc && e.KeyChar != '\b')
            {
                control_cc = false;
                count_correct_fields++;
                siticoneHtmlLabel_ccUser_wrong_length.Hide();

                siticoneHtmlLabel_ccUser_correct_length.Show();
            }
            else if (txtAniadirCCUsuario.Text.Length - 1 < max_long_cc && !control_cc && e.KeyChar == '\b')
            {
                // Borro 1 char de la cc teniendo ya completos los 10 previamente
                control_cc = true;
                count_correct_fields--;

                siticoneHtmlLabel_ccUser_correct_length.Hide();
                siticoneHtmlLabel_ccUser_wrong_length.Show();

                siticoneHtmlLabel_ccUser_valida.Hide();
                siticoneHtmlLabel_ccUser_invalida.Show();
            }
            validateFieldsCounter();
        }

        private void txtAniadirCCUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            controlCedula();
        }

        public void controlCedula()
        {
            if (ValidarCedula(txtAniadirCCUsuario.Text))
            {
                siticoneHtmlLabel_ccUser_invalida.Hide();
                siticoneHtmlLabel_ccUser_valida.Show();
            }
            validateFieldsCounter();
        }

        private void txtAniadirContraseniaUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras, números o caracteres especiales!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtAniadirContraseniaUsuario.Text.Length + 1 >= min_long_contra && control_contra && e.KeyChar != '\b')
            {
                control_contra = false;
                count_correct_fields++;
                siticoneHtmlLabel_wrong_length_contra.Hide();
                siticoneHtmlLabel_correct_length_contra.Show();
            }
            else if (txtAniadirContraseniaUsuario.Text.Length - 1 < min_long_contra && !control_contra && e.KeyChar == '\b')
            {
                control_contra = true;
                count_correct_fields--;
                siticoneHtmlLabel_wrong_length_contra.Show();
                siticoneHtmlLabel_correct_length_contra.Hide();
            }
            validateFieldsCounter();
        }

        private void txtAniadirNombre1Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtAniadirNombre1Usuario.Text.Length + 1 > 0 && control_nombre1 && e.KeyChar != '\b')
            {
                control_nombre1 = false;
                count_correct_fields++;
            }
            else if (txtAniadirNombre1Usuario.Text.Length - 1 == 0 && !control_nombre1 && e.KeyChar == '\b')
            {
                control_nombre1 = true;
                count_correct_fields--;
            }

            validateFieldsCounter();
        }

        private void siticoneComboBox_aniadirCargoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (siticoneComboBox_aniadirCargoUsuario.SelectedIndex != -1 && control_cargo)
            {
                siticoneHtmlLabel_sinCampoCargoUsuario.Hide();
                control_cargo = false;
                count_correct_fields++;
            }
            validateFieldsCounter();
        }

        private void SDGVUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SDGVUsuario.Columns[e.ColumnIndex].Name == "ColumnaEliminarUsuario")
            {
                if (e.RowIndex >= 0)
                {
                    if (MessageBox.Show("¿Está seguro de eliminar este usuario?", "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        /*clientes.RemoveAt(e.RowIndex);
                        siticoneDataGridView1.Rows.Clear();
                        foreach (Cliente c in clientes)
                        {
                            //siticoneDataGridView1.Rows.Add(c.cedula, c.nombres, c.apellidos, c.direccion, c.telefono);
                        }
                        */
                    }
                }
            }

            if (SDGVUsuario.Columns[e.ColumnIndex].Name == "ColumnaEditarUsuario")
            {
                if (e.RowIndex >= 0)
                {
                    //String cedula = siticoneDataGridView1.Rows[e.RowIndex].Cells["ColumnaCedula"].Value.ToString();
                    Editar_Usuario ventana = new Editar_Usuario();
                    ventana.ShowDialog();
                }
            }
        }

        private void SDGVParamUnidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SDGVParamUnidad.Columns[e.ColumnIndex].Name == "ColumnaEliminarParUn")
            {
                if (e.RowIndex >= 0)
                {
                    if (MessageBox.Show("¿Está seguro de eliminar este parámetro?", "Eliminar parámetro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        /*clientes.RemoveAt(e.RowIndex);
                        siticoneDataGridView1.Rows.Clear();
                        foreach (Cliente c in clientes)
                        {
                            //siticoneDataGridView1.Rows.Add(c.cedula, c.nombres, c.apellidos, c.direccion, c.telefono);
                        }
                        */
                    }
                }
            }

            if (SDGVParamUnidad.Columns[e.ColumnIndex].Name == "ColumnaEditarParUn")
            {
                if (e.RowIndex >= 0)
                {
                    //String cedula = siticoneDataGridView1.Rows[e.RowIndex].Cells["ColumnaCedula"].Value.ToString();
                    Editar_Parametro_Por_Unidad ventana = new Editar_Parametro_Por_Unidad();
                    ventana.ShowDialog();
                }
            }
        }

        private void SDGVParamPorcen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SDGVParamPorcen.Columns[e.ColumnIndex].Name == "ColumnaEliminarParPor")
            {
                if (e.RowIndex >= 0)
                {
                    if (MessageBox.Show("¿Está seguro de eliminar este parámetro?", "Eliminar parámetro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        /*clientes.RemoveAt(e.RowIndex);
                        siticoneDataGridView1.Rows.Clear();
                        foreach (Cliente c in clientes)
                        {
                            //siticoneDataGridView1.Rows.Add(c.cedula, c.nombres, c.apellidos, c.direccion, c.telefono);
                        }
                        */
                    }
                }
            }

            if (SDGVParamPorcen.Columns[e.ColumnIndex].Name == "ColumnaEditarParPor")
            {
                if (e.RowIndex >= 0)
                {
                    //String cedula = siticoneDataGridView1.Rows[e.RowIndex].Cells["ColumnaCedula"].Value.ToString();
                    Editar_Parametro_Por_Porcentaje ventana = new Editar_Parametro_Por_Porcentaje();
                    ventana.ShowDialog();
                }
            }
        }

        private void txtAniadirNombre2Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtAniadirNombre2Usuario.Text.Length + 1 > 0 && control_nombre2 && e.KeyChar != '\b')
            {
                control_nombre2 = false;
                count_correct_fields++;
            }
            else if (txtAniadirNombre2Usuario.Text.Length - 1 == 0 && !control_nombre2 && e.KeyChar == '\b')
            {
                control_nombre2 = true;
                count_correct_fields--;
            }
            validateFieldsCounter();
        }

        private void txtAniadirApellido1Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtAniadirApellido1Usuario.Text.Length + 1 > 0 && control_apell1 && e.KeyChar != '\b')
            {
                control_apell1 = false;
                count_correct_fields++;
            }
            else if (txtAniadirApellido1Usuario.Text.Length - 1 == 0 && !control_apell1 && e.KeyChar == '\b')
            {
                control_apell1 = true;
                count_correct_fields--;
            }
            validateFieldsCounter();
        }

        private void txtAniadirApellido2Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtAniadirApellido2Usuario.Text.Length + 1 > 0 && control_apell2 && e.KeyChar != '\b')
            {
                control_apell2 = false;
                count_correct_fields++;
            }
            else if (txtAniadirApellido2Usuario.Text.Length - 1 == 0 && !control_apell2 && e.KeyChar == '\b')
            {
                control_apell2 = true;
                count_correct_fields--;
            }
            validateFieldsCounter();
        }

        private void validateFieldsCounter()
        {
            Button_aniadirUsuario.Enabled = count_correct_fields >= num_atributos && ValidarCedula(txtAniadirCCUsuario.Text);
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
    }
}
