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
    public partial class fAlumno : Form
    {
        string generalMode = "";

        public fAlumno()
        {
            InitializeComponent();
        }

        private void alumnoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alumnoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pBDDataSet);

        }

        private void fAlumno_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pBDDataSet.Alumno' Puede moverla o quitarla según sea necesario.
            this.setData();

        }

        public void setData()
        {
            try
            {
                this.alumnoTableAdapter.Fill(this.pBDDataSet.Alumno);
                this.editionMode("Lectura");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error en la carga de datos:\n" + ex.Message.ToString());
            }
        }

        private void editionMode(string mode)
        {
            this.generalMode = mode;
            switch (mode)
            {
                case "Lectura":
                    this.pnlBotones.Enabled = true;
                    this.pnlDetalle.Enabled = false;
                    this.alumnoDataGridView.Enabled = true;
                    this.alumnoBindingNavigator.Enabled = true;
                    break;

                case "Insertar":
                    this.pnlBotones.Enabled = false;
                    this.pnlDetalle.Enabled = true;
                    this.alumnoDataGridView.Enabled = false;
                    this.alumnoBindingNavigator.Enabled = false;
                    break;

                case "Actualizar":
                    this.pnlBotones.Enabled = false;
                    this.pnlDetalle.Enabled = true;
                    this.alumnoDataGridView.Enabled = false;
                    this.alumnoBindingNavigator.Enabled = false;
                    break;
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.editionMode("Insertar");
            this.idAlumnoTextBox.Text = "";
            this.nombreTextBox.Text = "";
            this.primerApellidoTextBox.Text = "";
            this.segundoApellidoTextBox.Text = "";
            this.numeroControlTextBox.Text = "";
            this.eMailTextBox.Text = "";
            this.telefonoTextBox.Text = "";

            this.nombreTextBox.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.setData();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.editionMode("Actualizar");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("¿Estás seguro que deseas eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    // Ejecutar la sentencia DELETE de la tabla empresa
                    int id = int.Parse(this.idAlumnoTextBox.Text);
                    this.alumnoTableAdapter.Delete(id);
                    this.setData();
                }
                else
                {
                    this.setData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al eliminar el registro\n" + ex.Message.ToString());
            }
        }

        private Boolean validate()
        {
            this.errorProvider1.Clear();
            Boolean validado = true;
            if (this.nombreTextBox.Text.Trim() == "")
            {
                validado = false;
                this.errorProvider1.SetError(this.nombreTextBox, "Campo requerido");
            }

            if (this.primerApellidoTextBox.Text.Trim() == "")
            {
                validado = false;
                this.errorProvider1.SetError(this.primerApellidoTextBox, "Campo requerido");
            }

            if (this.segundoApellidoTextBox.Text.Trim() == "")
            {
                validado = false;
                this.errorProvider1.SetError(this.segundoApellidoTextBox, "Campo requerido");
            }

            if (this.numeroControlTextBox.Text.Trim() == "")
            {
                validado = false;
                this.errorProvider1.SetError(this.numeroControlTextBox, "Campo requerido");
            }

            if (this.eMailTextBox.Text.Trim() == "")
            {
                validado = false;
                this.errorProvider1.SetError(this.eMailTextBox, "Campo requerido");
            }

            if (this.telefonoTextBox.Text.Trim() == "")
            {
                validado = false;
                this.errorProvider1.SetError(this.telefonoTextBox, "Campo requerido");
            }

            return validado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.validate())
                {
                    switch (this.generalMode)
                    {
                        case "Insertar":
                            // Ejecutar la sentencia INSERT de la tabla empresa
                            this.alumnoTableAdapter.Insert(this.nombreTextBox.Text, this.primerApellidoTextBox.Text,
                                this.segundoApellidoTextBox.Text, this.numeroControlTextBox.Text, this.eMailTextBox.Text,
                                this.telefonoTextBox.Text);
                            break;

                        case "Actualizar":
                            // Ejecutar la sentencia UPDATE de la tabla empresa
                            int id = int.Parse(this.idAlumnoTextBox.Text);
                            this.alumnoTableAdapter.Update(this.nombreTextBox.Text, this.primerApellidoTextBox.Text,
                                this.segundoApellidoTextBox.Text, this.numeroControlTextBox.Text, this.eMailTextBox.Text,
                                this.telefonoTextBox.Text, id);
                            break;
                    }
                    this.setData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió el siguiente error:\n" + ex.Message.ToString());
            }
        }
    }
}
