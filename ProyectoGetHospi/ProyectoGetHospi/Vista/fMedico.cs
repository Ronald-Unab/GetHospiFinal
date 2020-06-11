using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoGetHospi.Modelos;
using System.Windows.Forms;
using ProyectoGetHospi.Vista;

namespace ProyectoGetHospi
{
    public partial class fMedico : Form
    {
        MMedicos mMedicos = new MMedicos();

        public fMedico()
        {
            InitializeComponent();
        }
         

        private void Form1_Load(object sender, EventArgs e)
        {
            médicoBindingSource.DataSource = mMedicos.Listado();
        }

        private void médicoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            fMenu M = new fMenu();
            M.Show();
            Hide();
        }
    }
}
