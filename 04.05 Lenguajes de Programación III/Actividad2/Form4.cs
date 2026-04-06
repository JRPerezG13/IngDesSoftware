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
    public partial class Saludo : Form
    {
        public Saludo()
        {
            InitializeComponent();
        }

        private void BotSal1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hola {nom.Text}, ¿Qué tal va tu día?", "Saludo");
        }

        private void BotSal2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
