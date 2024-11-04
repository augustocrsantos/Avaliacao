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
using Vendas.Data.Controller;
using Vendas.Model;
using Vendas.Model.Entidade;
using VendasApp.Forms.Generico;

namespace VendasApp.Forms.Crud
{
    public partial class FrmCliente : FrmCrudGenerico
    {
        private ClienteController clienteController;
        public FrmCliente()
        {
            InitializeComponent();
            clienteController = new ClienteController();
            clienteBindingSource.DataSource = typeof(Cliente);
        }

        private void CarregaBinding() { 
            maskedTextCodigo.DataBindings.Add(new Binding("Text", clienteBindingSource, nameof(Cliente.Id), true));
            maskedTextNome.DataBindings.Add(new Binding("Text", clienteBindingSource, nameof(Cliente.Nome), true));
            maskedTextDocumento.DataBindings.Add(new Binding("Text", clienteBindingSource, nameof(Cliente.Documento), true));
            dateTimePickerData.DataBindings.Add(new Binding("Text", clienteBindingSource, nameof(Cliente.DataNascimento), true));
            maskedTextCodigoCidade.DataBindings.Add(new Binding("Text", clienteBindingSource, nameof(Cliente.Cidade.Id), true));        
        }

        #region metodos override
        public override void AcaoSalvar() {         
            try {             
                base.AcaoSalvar();
                Cliente cliente = clienteBindingSource.Current as Cliente;
                if (cliente.Id == 0) { 
                     clienteController.Cadastrar(cliente);
                }else {
                    clienteController.Atualizar(cliente);
                }
            }catch (Exception ex) { TratamentoExcecao(ex.Message); }
        }

        public override void AcaoExcluir() {
            try{
                base.AcaoExcluir();
                Cliente cliente = clienteBindingSource.Current as Cliente;
                clienteController.Excluir<Cliente>(cliente.Id);
            }catch (Exception ex) { TratamentoExcecao(ex.Message); }
        }

        public override void AcaoPequisar() {
            try{
                base.AcaoPequisar();
                ControlaCampoCodigo(false);
                 Cliente cliente = clienteBindingSource.Current as Cliente;
                if (cliente == null || cliente.Id == 0){
                    cliente = clienteController.Consultar<Cliente>(cliente.Id);
                }else{
                    cliente = clienteController.ConsultarTodos<Cliente>().First();
                }
                clienteBindingSource.ResetCurrentItem();
            } catch (Exception ex) { TratamentoExcecao(ex.Message); }
        }

        public override void AcaoAnterior(){
            try {
                base.AcaoAnterior();
                ControlaCampoCodigo(false);
                Cliente cliente = clienteBindingSource.Current as Cliente;
                cliente = clienteController.LocalizarRegistroAnterior<Cliente>(cliente.Id, c => c.Id);
                clienteBindingSource.ResetCurrentItem();
            }catch (Exception ex) { TratamentoExcecao(ex.Message); }
        }

        public override void AcaoProximo(){
            try {
                base.AcaoProximo();
                ControlaCampoCodigo(false);
                Cliente cliente = clienteBindingSource.Current as Cliente;
                cliente = clienteController.LocalizarProximoRegistro<Cliente>(cliente.Id, c => c.Id);
                clienteBindingSource.ResetCurrentItem();
            } catch (Exception ex) { TratamentoExcecao(ex.Message); }
        }

        public override void AcaoIncluir(){
            try            {
                base.AcaoIncluir();
                ControlaCampoCodigo(false);
                clienteBindingSource.AddNew();
            }catch (Exception ex) { TratamentoExcecao(ex.Message); }
        }

        public override void AcaoLocalizar() {
            try {
                base.AcaoLocalizar();
                ControlaCampoCodigo(true);
                clienteBindingSource.ResetCurrentItem();
            } catch (Exception ex) { TratamentoExcecao(ex.Message); }
        }
        //Tratamento dos evntos de catch
        private void TratamentoExcecao(string erro){
            MessageBox.Show("Ocorreu o seguite erro:" + erro);
        }

        #endregion
        private void FrmCadastroCliente_Load(object sender, EventArgs e) {
            CarregaBinding();
        }

        /// <summary>
        /// Controla se o campo de codigo será habilitado ou não
        /// </summary>
        /// <param name="habilitado"></param>
        private void ControlaCampoCodigo(bool habilitado) {
            maskedTextCodigo.Enabled = habilitado;            
        }

    }
}
