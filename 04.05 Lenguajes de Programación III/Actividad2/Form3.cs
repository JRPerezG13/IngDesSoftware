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
    public partial class Operaciones : Form
    {
        public Operaciones()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            no1.Clear();
            no2.Clear();
            no3.Clear();
            no4.Clear();
            no5.Clear();
            no6.Clear();
            rest.Clear();
        }

        private void suma_Click(object sender, EventArgs e)
        {
            double resultado = double.Parse(no1.Text) + double.Parse(no2.Text) +
                       double.Parse(no3.Text) + double.Parse(no4.Text) +
                       double.Parse(no5.Text) + double.Parse(no6.Text);
            rest.Text = resultado.ToString();
        }

        private void resta_Click(object sender, EventArgs e)
        {
            double resultado = double.Parse(no1.Text) - double.Parse(no2.Text) -
                       double.Parse(no3.Text) - double.Parse(no4.Text) -
                       double.Parse(no5.Text) - double.Parse(no6.Text);
            rest.Text = resultado.ToString();
        }
        private void multi_Click(object sender, EventArgs e)
        {
            double resultado = double.Parse(no1.Text) * double.Parse(no2.Text) *
                       double.Parse(no3.Text) * double.Parse(no4.Text) *
                       double.Parse(no5.Text) * double.Parse(no6.Text);
            rest.Text = resultado.ToString();
        }

        private void divi_Click(object sender, EventArgs e)
        {
            double resultado = double.Parse(no1.Text) / double.Parse(no2.Text) /
                       double.Parse(no3.Text) / double.Parse(no4.Text) /
                       double.Parse(no5.Text) / double.Parse(no6.Text);
            rest.Text = resultado.ToString();
        }

        private void multi_Click_1(object sender, EventArgs e)
        {
            double resultado = double.Parse(no1.Text) * double.Parse(no2.Text) *
                       double.Parse(no3.Text) * double.Parse(no4.Text) *
                       double.Parse(no5.Text) * double.Parse(no6.Text);
            rest.Text = resultado.ToString();
        }

        private void divi_Click_1(object sender, EventArgs e)
        {
            double resultado = double.Parse(no1.Text) / double.Parse(no2.Text) /
                       double.Parse(no3.Text) / double.Parse(no4.Text) /
                       double.Parse(no5.Text) / double.Parse(no6.Text);
            rest.Text = resultado.ToString();
        }

        private void botoper2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
