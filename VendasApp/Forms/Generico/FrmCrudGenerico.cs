using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BindingSource = System.Windows.Forms.BindingSource;
using ToolTip = System.Windows.Forms.ToolTip;

namespace VendasApp.Forms.Generico
{
    public partial class FrmCrudGenerico : Form 
    {
        private ToolTip toolTip;
        //private BindingSource bindingSource;
        public MaskedTextBox Codigo;
        public FrmCrudGenerico()
        {
            InitializeComponent();
           // bindingSource = new BindingSource();
          //  this.Controls.Add(maskedTextBoxCodigo);
            
        }
        

        public virtual void AcaoSalvar(){}
        public virtual void AcaoIncluir() { }
        public virtual void AcaoExcluir() { }
        public virtual void AcaoPequisar() { }
        public virtual void AcaoLocalizar() { }
        public virtual void AcaoProximo() { }
        public virtual void AcaoAnterior() { }
        

        private void btLocalizar_Click(object sender, EventArgs e){ AcaoLocalizar(); }

        private void buttonPesquisar_Click(object sender, EventArgs e){ AcaoPequisar(); }

        private void btIncluir_Click(object sender, EventArgs e){ AcaoIncluir(); }

        public void btSalvar_Click(object sender, EventArgs e){AcaoSalvar();}

        private void brExcluir_Click(object sender, EventArgs e){ AcaoExcluir(); }

        private void btAnterior_Click(object sender, EventArgs e){ AcaoAnterior(); }

        private void btProximo_Click(object sender, EventArgs e){ AcaoProximo(); }

        private void FrmCrudGenerico_Shown(object sender, EventArgs e)
        {
            //btSalvar.Visible = false;
            CarregaTootip();
        }

        private void CarregaTootip()
        {
            toolTip = new ToolTip();
            toolTip.SetToolTip(btSalvar, "Salvar");
            toolTip.SetToolTip(btIncluir, "Incluir");
            toolTip.SetToolTip(btAnterior, "Registro Anterior");
            toolTip.SetToolTip(btProximo, "Proximo registro");
            toolTip.SetToolTip(btLocalizar, "Localizar");
            toolTip.SetToolTip(btExcluir, "Excluir");
            toolTip.SetToolTip(btPesquisar, "Pesquisar");
        }
    }
}
