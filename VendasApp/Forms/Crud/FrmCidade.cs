using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vendas.Data.Controller;
using Vendas.Model;
using Vendas.Model.Entidade;
using Vendas.Model.Enum;
using VendasApp.Forms.Generico;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VendasApp.Forms.Crud
{
    public partial class FrmCidade : FrmCrudGenerico
    {
        private CidadeController cidadeController;
        public FrmCidade()
        {
            InitializeComponent();       
            cidadeController= new CidadeController();
            bindingSource.DataSource = typeof(Cidade);          
        }
        private void CarregaBinding()
        {           
            maskedTextNome.DataBindings.Add(new Binding("Text", bindingSource, nameof(Cidade.Nome), true));          
            maskedTextCodigo.DataBindings.Add(new Binding("Text", bindingSource, nameof(Cidade.Id), true));
            comboBoxEstado.DataBindings.Add(new Binding("Text", bindingSource, nameof(Cidade.SiglaEstado), true));
        }

        private void FrmCidade_Load(object sender, EventArgs e)
        {
            CarregaBinding();
            CarregarComboBox();
        }
        #region metodos override
        public override void AcaoSalvar()
        {
            try{
                base.AcaoSalvar();
                Cidade cidade = bindingSource.Current as Cidade;
                if (cidade.Id == 0) { 
                
                    cidadeController.Cadastrar(cidade);
                }else{
                    cidadeController.Atualizar(cidade);
                }
            } catch(Exception ex) { TratamentoExcecao(ex.Message); }           
        }

        public override void AcaoExcluir() {
            try { 
                base.AcaoExcluir();
                Cidade cidade = bindingSource.Current as Cidade;
                cidadeController.Excluir<Cidade>(cidade.Id);
            }catch(Exception ex) { TratamentoExcecao(ex.Message); }
            
        }

        public override void AcaoPequisar() {
            try {
                base.AcaoPequisar();
                ControlaCampoCodigo(false);
                Cidade cidade = bindingSource.Current as Cidade;
                if (cidade == null || cidade.Id == 0) {                 
                    cidade = cidadeController.Consultar<Cidade>(cidade.Id);
                }else{
                    cidade = cidadeController.ConsultarTodos<Cidade>().First();
                }
                bindingSource.ResetCurrentItem();
            }catch(Exception ex) { TratamentoExcecao(ex.Message);}                       
        }

        public override void AcaoAnterior() {         
            try {
                base.AcaoAnterior();
                ControlaCampoCodigo(false);
                Cidade cidade = bindingSource.Current as Cidade;
                cidade = cidadeController.LocalizarRegistroAnterior<Cidade>(cidade.Id, c => c.Id);
                bindingSource.ResetCurrentItem();
            }catch(Exception ex) { TratamentoExcecao(ex.Message); }
        }

        public override void AcaoProximo() {
            try {             
                base.AcaoProximo();
                ControlaCampoCodigo(false);
                Cidade cidade = bindingSource.Current as Cidade;
                cidade = cidadeController.LocalizarProximoRegistro<Cidade>(cidade.Id, c => c.Id);
                bindingSource.ResetCurrentItem();
            }catch(Exception ex) { TratamentoExcecao(ex.Message); }
            
        }

        public override void AcaoIncluir() { 
            try{
                base.AcaoIncluir();
                ControlaCampoCodigo(false);
                bindingSource.AddNew();                
            }catch(Exception ex) { TratamentoExcecao(ex.Message); }
        }

        public override void AcaoLocalizar() {         
            try{
                base.AcaoLocalizar();
                ControlaCampoCodigo(true);
                //permite pesquisa somente pelo codigo
                maskedTextNome.Enabled= false;
                comboBoxEstado.Enabled= false;
                bindingSource.ResetCurrentItem();
            }
            catch(Exception ex) { TratamentoExcecao(ex.Message); }
        }

        private void TratamentoExcecao(string erro) {        
            MessageBox.Show("Ocorreu o seguite erro:"+erro);
        }

        /// <summary>
        /// Controla se o campo de codigo será habilitado ou não
        /// </summary>
        /// <param name="habilitado"></param>
        private void ControlaCampoCodigo(bool habilitado){
            maskedTextCodigo.Enabled = habilitado;         
        }

        /// <summary>
        /// Carrega comboBox com a lista de estados
        /// </summary>
        public void CarregarComboBox()
        {
            comboBoxEstado.DataSource = Enum.GetValues(typeof(SiglaEstadoEnum.SiglaEstado));
        }
        #endregion


    }
}
