using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Vendas.Data.Configuracoes;
using Vendas.Model;

namespace Vendas.Data.Controller
{
    public class ClienteController: GenericoController
    {
        private Contexto Contexto { get; set; }

        public ClienteController()
        {
            Contexto = new Contexto();
        }

        /*

        public bool Cadastrar(Cliente cliente)
        {
            try
            {
                Contexto.Cliente.Add(cliente);
                //QUANTAS LINHAS FORAM AFETADAS
                int linhas = Contexto.SaveChanges();
                return (linhas > 0) ? true : false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public bool Atualizar(Cliente cliente)
        {
            try
            {
                Contexto.Cliente.Update(cliente);
                int linhas = Contexto.SaveChanges();
                return (linhas > 0) ? true : false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Excluir(int id)
        {
            try
            {
                Cliente cliente = Consultar(id);
                Contexto.Cliente.Remove(cliente);
                int linhas = Contexto.SaveChanges();
                return (linhas > 0) ? true : false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Cliente Consultar(int id)
        {
            try
            {
                return Contexto.Cliente.FindAsync(id).Result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        

        //public Cliente ConsultarPorCnpj(string cnpj)
        //{
        //    try
        //    {
        //        return Contexto.Clientes.Where(c => c.CNPJ == cnpj).FirstOrDefault();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}


        public List<Cliente> ConsultarTodos()
        {
            try
            {
                return Contexto.Cliente.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int? ProximoId()
        {
            try
            {
                //do porque se deixar so o Max ele cai no exception
                var primeiroCliente = Contexto.Cliente.FirstOrDefault();
                if (primeiroCliente == null) {
                    return 1;
                }
                return Contexto.Cliente.Max<Cliente>(a => a.Id) + 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        */

    }
}
