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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fEmpresa empresa = new fEmpresa();
            empresa.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fAlumno alumno = new fAlumno();
            alumno.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fAlumnoEmpresa alumnoEmpresa = new fAlumnoEmpresa();
            alumnoEmpresa.ShowDialog();
        }
    }
}
