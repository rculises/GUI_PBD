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
    public partial class fAlumnoEmpresa : Form
    {
        string generalMode = "";

        public fAlumnoEmpresa()
        {
            InitializeComponent();
        }

        private void fAlumnoEmpresa_Load(object sender, EventArgs e)
        {
            this.setData();
        }

        public void setData()
        {
            try
            {
                this.empresaTableAdapter.Fill(this.pBDDataSet.Empresa);
                this.alumnoTableAdapter.Fill(this.pBDDataSet.Alumno);
                this.vAlumnoEmpresaTableAdapter.Fill(this.pBDDataSet.vAlumnoEmpresa);

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
                    this.vAlumnoEmpresaDataGridView.Enabled = true;
                    this.vAlumnoEmpresaBindingNavigator.Enabled = true;
                    break;

                case "Insertar":
                    this.pnlBotones.Enabled = false;
                    this.pnlDetalle.Enabled = true;
                    this.vAlumnoEmpresaDataGridView.Enabled = false;
                    this.vAlumnoEmpresaBindingNavigator.Enabled = false;
                    break;

                case "Actualizar":
                    this.pnlBotones.Enabled = false;
                    this.pnlDetalle.Enabled = true;
                    this.vAlumnoEmpresaDataGridView.Enabled = false;
                    this.vAlumnoEmpresaBindingNavigator.Enabled = false;
                    break;
            }
        }

        private void vAlumnoEmpresaDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.vAlumnoEmpresaDataGridView.Rows.Count == 0)
                {
                    return;
                }
                else
                {
                    // Sincronizar los ComboBox
                    this.cbAlumno.SelectedValue = this.vAlumnoEmpresaDataGridView.CurrentRow.Cells["idAlumno"].Value.ToString();
                    this.cbEmpresa.SelectedValue = this.vAlumnoEmpresaDataGridView.CurrentRow.Cells["idEmpresa"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al sincronizar la tabla: \n" + ex.Message.ToString());
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.editionMode("Insertar");
            this.idAlumnoEmpresaTextBox.Text = "";
            this.cbAlumno.SelectedIndex = 0;
            this.cbEmpresa.SelectedIndex = 0;
            this.anioInicioNumericUpDown.Value = 0;
            this.anioFinNumericUpDown.Value = 0;
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
                    int id = int.Parse(this.idAlumnoEmpresaTextBox.Text);
                    this.alumnoEmpresaTableAdapter.Delete(id);
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (this.generalMode)
                {
                    case "Insertar":
                        // Ejecutar la sentencia INSERT de la tabla empresa
                        this.alumnoEmpresaTableAdapter.Insert((int)this.cbAlumno.SelectedValue, (int)this.cbEmpresa.SelectedValue, (short)this.anioInicioNumericUpDown.Value, (short)this.anioFinNumericUpDown.Value);
                        break;

                    case "Actualizar":
                        // Ejecutar la sentencia UPDATE de la tabla empresa
                        int id = int.Parse(this.idAlumnoEmpresaTextBox.Text);
                        this.alumnoEmpresaTableAdapter.Update((int)this.cbAlumno.SelectedValue, (int)this.cbEmpresa.SelectedValue, (short)this.anioInicioNumericUpDown.Value, (short)this.anioFinNumericUpDown.Value, id);
                        break;
                }
                this.setData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió el siguiente error:\n" + ex.Message.ToString());
            }
        }
    }
}
