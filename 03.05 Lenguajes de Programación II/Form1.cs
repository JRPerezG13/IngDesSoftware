using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COPPEL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cOPPELDataSet.Puesto' Puede moverla o quitarla según sea necesario.
            this.puestoTableAdapter.Fill(this.cOPPELDataSet.Puesto);
            // TODO: esta línea de código carga datos en la tabla 'cOPPELDataSet.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.cOPPELDataSet.Empleado);
            // TODO: esta línea de código carga datos en la tabla 'cOPPELDataSet.Directivos' Puede moverla o quitarla según sea necesario.
            this.directivosTableAdapter.Fill(this.cOPPELDataSet.Directivos);
            // TODO: esta línea de código carga datos en la tabla 'cOPPELDataSet.centrotrabajo' Puede moverla o quitarla según sea necesario.
            this.centrotrabajoTableAdapter.Fill(this.cOPPELDataSet.centrotrabajo);

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}