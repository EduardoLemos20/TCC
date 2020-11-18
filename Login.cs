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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadastroC cdtcliente = new cadastroC();
            cdtcliente.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRestaurante cdtrestaurante = new FormRestaurante();
            cdtrestaurante.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormRestaurante loginR = new FormRestaurante();
            loginR.Show();

        }
    }
}
