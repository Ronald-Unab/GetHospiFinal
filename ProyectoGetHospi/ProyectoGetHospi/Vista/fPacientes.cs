using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoGetHospi.Modelos;

namespace ProyectoGetHospi.Vista
{
    public partial class fPacientes : Form
    {
        public fPacientes()
        {
            
            InitializeComponent();
        }
        MPaciente mPaciente = new MPaciente(); 
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            fMenu M = new fMenu();
            M.Show();
            Hide();
        }

        private void fPacientes_Load(object sender, EventArgs e)
        {
            pacientesBindingSource.DataSource = mPaciente.Listado();
        }
    }
}
