using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Recuperação_17._04
{
    public partial class frmConsCliente : Form
    {
        public frmConsCliente()
        {
            InitializeComponent();
        }

        private void frmConsCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "ETECZL", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                e.Cancel = true;
            }
        }

        private void btnCadCli_Click(object sender, EventArgs e)
        {
            frmCadCliente telaCliente = new frmCadCliente();
            
            telaCliente.Show();
        }

        private void frmConsCliente_Load(object sender, EventArgs e)
        {
            string conexao = "Persist Security Info=False;User ID=sa;Initial Catalog=Recuperacao;Data Source=LAB-08-16;password=info211";

            SqlConnection conexaoBanco = new SqlConnection(conexao);

            conexaoBanco.Open();

            string comandoSQL = "select * from tbCliente";

            SqlCommand execucaoSQL = new SqlCommand(comandoSQL, conexaoBanco);
            SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQL, conexaoBanco);
            DataSet datasetCliente = new DataSet();
            adaptador.Fill(datasetCliente);

            dtCliente.DataSource = datasetCliente;
            dtCliente.DataMember = datasetCliente.Tables[0].TableName;

            conexaoBanco.Close();
        }
    }
}
