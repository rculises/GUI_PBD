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
    public partial class fEmpresa : Form
    {
        public fEmpresa()
        {
            InitializeComponent();
        }

        private void empresaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empresaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pBDDataSet);

        }

        private void fEmpresa_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pBDDataSet.Empresa' Puede moverla o quitarla según sea necesario.
            this.setData();
        }

        public void setData() {
            try {
                this.empresaTableAdapter.Fill(this.pBDDataSet.Empresa);
                this.editionMode("Lectura");
            }
            catch (Exception ex){
                MessageBox.Show("Ha ocurrido un error en la carga de datos:\n" + ex.Message.ToString());
            }
        }

        private void editionMode(string mode) {
            switch (mode) {
                case "Lectura":
                    this.pnlBotones.Enabled = true;
                    this.pnlDetalle.Enabled = false;
                    this.empresaDataGridView.Enabled = true;
                    this.empresaBindingNavigator.Enabled = true;
                    break;

                case "Insertar":
                    this.pnlBotones.Enabled = false;
                    this.pnlDetalle.Enabled = true;
                    this.empresaDataGridView.Enabled = false;
                    this.empresaBindingNavigator.Enabled = false;
                    break;

                case "Actualizar":
                    this.pnlBotones.Enabled = false;
                    this.pnlDetalle.Enabled = true;
                    this.empresaDataGridView.Enabled = false;
                    this.empresaBindingNavigator.Enabled = false;
                    break;
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e) {
            this.editionMode("Insertar");
            this.idEmpresaTextBox.Text = "";
            this.razonSocialTextBox.Text = "";
            this.razonSocialTextBox.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.setData();
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            this.editionMode("Actualizar");
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            try {
                DialogResult dr = MessageBox.Show("¿Estás seguro que deseas eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes) {
                    // Ejecutar el DELETE
                } else {
                    this.setData();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Ha ocurrido un error al eliminar el registro\n" + ex.Message.ToString());
            }
        }
    }
}
