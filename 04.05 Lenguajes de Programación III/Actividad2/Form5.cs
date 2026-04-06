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
    public partial class flogin : Form
    {
        public flogin()
        {
            InitializeComponent();
        }

        private void botingresar_Click(object sender, EventArgs e)
        {
            if (contra.Text == "1234")
            { 
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
            }
        }
    }
}
