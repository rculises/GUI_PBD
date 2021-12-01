using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_PBD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Conectar a la base de datos por medio del procedimiento almacenado

            // Validar si los campos están llenos
            if (this.validate())
            {
                // Mandar a llamar el procedimiento de Usuario para validar si existe
                this.usuarioTableAdapter.Fill(this.pbdDataSet.Usuario, this.txtCorreo.Text.Trim(), this.txtClave.Text.Trim());
                
                // Validar si existe el usuario
                if (this.pbdDataSet.Usuario.Rows.Count > 0)
                {
                    // Si existe el usuario se ingresará a la pantalla principal
                    MenuPrincipal menuPrincipal = new MenuPrincipal();
                    this.Hide();
                    menuPrincipal.ShowDialog();
                    this.Close();
                } else
                {
                    // Usuario o contraseña incorrectos
                    MessageBox.Show("El usuario o contraseña son incorrectos",
                        "Valida el usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private bool validate()
        {
            this.errorProvider.Clear();
            bool result = true;

            // Validar el campo Correo
            if (this.txtCorreo.Text.Trim() == "")
            {
                result = false;
                this.errorProvider.SetError(this.txtCorreo, "Este campo es requerido");
            }

            // Validar el campo Clave
            if (this.txtClave.Text.Trim() == "")
            {
                result = false;
                this.errorProvider.SetError(this.txtClave, "Este campo es requerido");
            }

            return result;
        }
    }
}
