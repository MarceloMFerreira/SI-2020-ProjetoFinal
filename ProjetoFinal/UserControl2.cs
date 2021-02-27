using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.Nome = txtNome.Text;
            c.Cpf = txtCpf.Text;
            c.End = txtEnd.Text;
            c.Tel = txtTel.Text;

            ConectaBanco con = new ConectaBanco();
            bool r = con.insereCliente(c);
            if (r == true)
                MessageBox.Show("Inserido com sucesso :)");
            else
                MessageBox.Show("Erro: " + con.msg);
            limpaForm();

        }
        void limpaForm()
        {
            txtCpf.Clear();
            txtEnd.Clear();
            txtNome.Clear();
            txtTel.Clear();
            txtNome.Focus();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
