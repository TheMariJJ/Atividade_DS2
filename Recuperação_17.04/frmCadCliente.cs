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
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void frmCadCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "ETECZL", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                e.Cancel = true;
            }
        }

        private void LimparCampos()
        {
            txbNomeCliente.Text = "";
            txbCpfCliente.Text = "";
            txbDtNascCliente.Text = "";
            txbTelCliente.Text = "";
            txbEndCliente.Text = "";
            txbVeicCliente.Text = "";
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            MessageBox.Show("Campos foram limpos ", "ETECZL");
        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            if (txbNomeCliente.Text == "" || txbCpfCliente.Text == "" || txbDtNascCliente.Text == "" || txbTelCliente.Text == "" || txbEndCliente.Text == "" || txbVeicCliente.Text == "")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos", "ETECZL");
            }
             else
            {          
                string conexao = "Persist Security Info=False;User ID=sa;Initial Catalog=Recuperacao;Data Source=LAB-08-16;password=info211";

                SqlConnection conexaoBanco = new SqlConnection(conexao);

                conexaoBanco.Open();

                string comandoSQL = "insert into tbCliente values ('" + txbNomeCliente.Text + "', '" + txbCpfCliente.Text + "', '" + txbDtNascCliente.Text + "', '" + txbTelCliente.Text + "', '" + txbEndCliente.Text + "','" + txbVeicCliente.Text + "')";

                SqlCommand execucaoSQL = new SqlCommand(comandoSQL, conexaoBanco);
                execucaoSQL.ExecuteNonQuery();

                conexaoBanco.Close();

                MessageBox.Show("Cadastro realizado", "ETECZL");
                LimparCampos();
            }
        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {

        }


    }
}
