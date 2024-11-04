using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vendas.Data.Configuracoes;
using VendasApp.Forms.Crud;

namespace VendasApp.Forms.Processamento
{
    public partial class FrmPrincipal : Form
    {
        private Contexto contexto;
        public FrmPrincipal()
        {
            InitializeComponent();
            contexto = new Contexto();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente form = new FrmCliente();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Normal;
            form.MaximizeBox = false;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCidade form = new FrmCidade();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Normal;
            form.MaximizeBox = false;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }
    }
}
