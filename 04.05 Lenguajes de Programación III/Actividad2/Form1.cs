using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void saludoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saludoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Saludo f = new Saludo();
            f.ShowDialog();
        }

        private void datosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infop f = new infop();
            f.ShowDialog();
        }

        private void operacionesBásicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operaciones f = new Operaciones();
            f.ShowDialog();
        }
    }
}
