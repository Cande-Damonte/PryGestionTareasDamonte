using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryGestionTareasDamonte
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrearUsuario frmCrearUsuario = new FrmCrearUsuario();
            frmCrearUsuario.Show();
            this.Hide();
        }

        private void crearTareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrearTarea frmCrearTarea = new FrmCrearTarea();
            frmCrearTarea.Show();
            this.Hide();
        }

        private void completarTareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompletarTarea frmCompletarTarea = new FrmCompletarTarea();
            frmCompletarTarea.Show();
            this.Hide();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporte frmReporte = new FrmReporte();
            frmReporte.Show();
            this.Hide();
        }
    }
}
