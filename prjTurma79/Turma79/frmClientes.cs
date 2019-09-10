using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using TransferenciaDados;

namespace Turma79
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //veririficar se os campos foram preenchidos
            if (txtCodigoCliente.Text == string.Empty)
            //|| txtCodigoCliente.Text == string.Empty
            {
                MessageBox.Show("Favor preencher campo.", "Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                if(txtNomeCliente.Text == string.Empty)
                {
                    MessageBox.Show("Favor preencher campo.", "Aviso");
                    txtNomeCliente.Focus();
                }
            }
            //instanciar a classe SalvarCliente
            SalvarCliente salvarcliente = new SalvarCliente();

            //referencia ao dto
            ClienteDTO dados = new ClienteDTO();

            //popular os campos
            dados.Nome = txtNomeCliente.Text;
            dados.Endereco = txtEndereco.Text;
            dados.Telefone = txtTelefone.Text;
            dados.Bairro = txtBairro.Text;

            //chamar o metodo para incluir cliente
            salvarcliente.IncluirCliente(dados);



        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //limpar os campos
            txtCodigoCliente.Clear();
            txtNomeCliente.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //verificar se realmente quer sair

          if  (MessageBox.Show("Desejar reaalmente sair do sistema?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
