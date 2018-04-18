using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Recuperação_17._04
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lblData.Text = "Data: " + DateTime.Now.ToString("dd/mm/yyyy");
            lblHora.Text = "Hora: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void hora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora: " + DateTime.Now.ToString("HH:mm:ss"); 
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadFunc telaFunc = new frmCadFunc();
            telaFunc.MdiParent = this;
            telaFunc.Show();
        }

        private void veículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadVeiculo telaVeiculo = new frmCadVeiculo();
            telaVeiculo.MdiParent = this;
            telaVeiculo.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadCliente telaCliente = new frmCadCliente();
            telaCliente.MdiParent = this;
            telaCliente.Show();

        }

      /*  private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "ETECZL", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                e.Cancel = true;
            }
        }*/

        private void funcionarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsFunc consultaFun = new frmConsFunc();
            consultaFun.MdiParent = this;
            consultaFun.Show();
        }

        private void veiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsVeiculo consultaVeiculo = new frmConsVeiculo();
            consultaVeiculo.MdiParent = this;
            consultaVeiculo.Show();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsCliente consultaCliente = new frmConsCliente();
            consultaCliente.MdiParent = this;
            consultaCliente.Show();
        }

   
    }
}
