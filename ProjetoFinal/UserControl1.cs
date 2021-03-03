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
    public partial class UserControl1 : UserControl
    {
      string idalt;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void listaClientes()
        {
            ConectaBanco con = new ConectaBanco();
            dgClientes.DataSource = con.lista();    
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            listaClientes();
        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            (dgClientes.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nome like '%{0}%'", txtBusca.Text);

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
           

        }

        private void txtAltNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                int linha = dgClientes.CurrentRow.Index;
                string cpf = dgClientes.Rows[linha].Cells["cpf"].Value.ToString();
                ConectaBanco con = new ConectaBanco();
                bool retorno = con.deletaCliente(cpf);
                if (retorno)
                    MessageBox.Show("Cadastro excluido com sucesso :)");
                else
                    MessageBox.Show("Erro: ", con.msg);

                listaClientes();


            }
            txtBusca.Clear();
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            int linha = dgClientes.CurrentRow.Index;
             idalt = dgClientes.Rows[linha].Cells["cpf"].Value.ToString();
           
            txtAltNome.Text = dgClientes.Rows[linha].Cells["nome"].Value.ToString();
            txtAltEnd.Text = dgClientes.Rows[linha].Cells["endereco"].Value.ToString();
            txtAltTel.Text = dgClientes.Rows[linha].Cells["telefone"].Value.ToString();
            tabControl1.SelectedTab = tabPage1;
            txtBusca.Clear();
        }
        void limpaForm()
        {
           
            txtAltEnd.Clear();
            txtAltNome.Clear();
            txtAltTel.Clear();
            
        }

        private void bntAltCon_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.Nome = txtAltNome.Text;  
            c.End = txtAltEnd.Text;
            c.Tel = txtAltTel.Text;
            ConectaBanco con = new ConectaBanco();
            bool ret = con.updateCliente(c, idalt);
            if (ret == true)
                MessageBox.Show("Alterado com sucesso :)");
            else
                MessageBox.Show("Erro: " + con.msg);
            limpaForm();
            listaClientes();
            tabControl1.SelectedTab = tabPage2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
