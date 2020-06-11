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
    public partial class fUsuarios : Form
    {
        MUsuarios mUsuarios = new MUsuarios();

        public fUsuarios()
        {
            InitializeComponent();
        }

        private void fUsuarios_Load(object sender, EventArgs e)
        {
            usuariosBindingSource.DataSource = mUsuarios.Listado();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            fMenu M = new fMenu();
            M.Show();
            Hide();
        }
    }
}
