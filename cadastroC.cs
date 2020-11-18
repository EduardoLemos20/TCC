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
    public partial class cadastroC : Form
    {
        public cadastroC()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCliente formC = new FormCliente();
            formC.Show();
        }

        private void principal_Click(object sender, EventArgs e)
        {
            Home principal = new Home();
            principal.Show();
        }
    }
}
