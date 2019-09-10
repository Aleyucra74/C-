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
using AcessoBanco;

namespace Turma79
{
    public partial class frmAcesso : Form
    {
        public frmAcesso()
        {
            InitializeComponent();
        }

        private void btnAcesso_Click(object sender, EventArgs e)
        {
            //obter a conexao com o banco de dados
            SqlConnection conn = Conexao.obterConexao();

            // Verificar o status da conexão
            if (conn == null)
            {
                MessageBox.Show("Não foi possí­vel obter a conexão. Veja o log de erros.");
            }
            else
            {
                MessageBox.Show("A conexão foi obtida com sucesso.");
            }
        }
    }
}
