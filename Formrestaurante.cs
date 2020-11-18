using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Back
{
    public partial class FormRestaurante : Form
    {
        public FormRestaurante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadastroR cdtR = new cadastroR();
            cdtR.Show();
        }

        private void principal_Click(object sender, EventArgs e)
        {
            Home principal = new Home();
            principal.Show();
        }
    }
}
