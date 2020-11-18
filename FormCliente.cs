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
    public partial class FormCliente : Form
    {
        Conexao conect = new Conexao();

        public FormCliente()
        {
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == null || txtTelefone.Text == null || txtEmail.Text == null || txtSenha.Text == null || txtConfirmsenha.Text == null)
            {
                MessageBox.Show("preencha os campos");
                txtSenha.Focus();
                return;
            }
            else
            {//tela principal
                Home principal = new Home();
                principal.Show();
            }
            conect.AbrirCon();
        }
    }
}
