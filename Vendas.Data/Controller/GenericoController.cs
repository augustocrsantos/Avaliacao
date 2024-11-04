using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.Data.Configuracoes;

namespace Vendas.Data.Controller
{
    public class GenericoController
    {

        private Contexto Contexto { get; set; }

        public GenericoController()
        {
            Contexto = new Contexto();
        }

        public bool Cadastrar<TEntity>(TEntity entidade) where TEntity : class
        {
            try
            {

                int linhas = Contexto.SaveChanges();
                return linhas > 0;
            }
            catch (Exception ex)
            {
                // Tratar a exceção adequadamente (pode usar logging ou rethrow com mais informações)
                throw new Exception("Erro ao cadastrar a entidade: " + ex.Message);
            }
        }

        /// <summary>
        /// Realiza atualização no banco de dados na tabela recebida como parametro
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entidade"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>

        public bool Atualizar<TEntity>(TEntity entidade) where TEntity : class
        {
            try
            {
                Contexto.Set<TEntity>().Update(entidade);
                int linhas = Contexto.SaveChanges();
                return linhas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Realiza exclusão do registro recebido como parametro na tabela especificada
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool Excluir<TEntity>(int id) where TEntity : class
        {
            try
            {                
                TEntity entidade = Contexto.Set<TEntity>().Find(id);                
                if (entidade == null)
                {
                    return false;
                }              
                Contexto.Set<TEntity>().Remove(entidade);
                int linhas = Contexto.SaveChanges();
                return linhas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Consultar por Id
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public TEntity Consultar<TEntity>(int id) where TEntity : class
        {
            try
            {
                return Contexto.Set<TEntity>().FindAsync(id).Result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//EX: var cliente = Consultar<Cliente>(1); // Consulta o cliente com ID 1

        /// <summary>
        /// Cosulta todos os registros da tabela herdada 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<TEntity> ConsultarTodos<TEntity>() where TEntity : class
        {
            try
            {
                return Contexto.Set<TEntity>().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }// EX: var clientes = ConsultarTodos<Cliente>(); // Retorna todos os clientes

        /// <summary>
        /// Retorna o proximo id disponivel da tabela informada
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="selector"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public int? ProximoId<T>(Func<T, int> selector) where T : class
        {
            try
            {              
                var primeiroRegistro = Contexto.Set<T>().FirstOrDefault();
                if (primeiroRegistro == null)
                {
                    return 1;
                }

                return Contexto.Set<T>().Max(selector) + 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        } // EX: var proximoIdCliente = ProximoId<Cliente>(c => c.Id);

        /// <summary>
        /// Localiza o proximo registro da tabela no banco de dados
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <param name="idSelector"></param>
        /// <returns></returns>
        public T LocalizarProximoRegistro<T>(int id, Func<T, int> idSelector) where T : class
        {
           
            var proximoRegistro = Contexto.Set<T>()
                .Where(e => idSelector(e) > id)
                .OrderBy(idSelector)
                .FirstOrDefault();

            return proximoRegistro;
        }//EX: var proximoCliente = LocalizarProximoRegistro<Cliente>(5, c => c.Id);

        /// <summary>
        /// Localiza o registro anterior ao atual na tabela do banco de dados
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <param name="idSelector"></param>
        /// <returns></returns>
        public T LocalizarRegistroAnterior<T>(int id, Func<T, int> idSelector) where T : class
        {
            // Obtém o registro anterior com o maior Id que seja menor do que o Id atual
            var registroAnterior = Contexto.Set<T>()
                .Where(e => idSelector(e) < id)
                .OrderByDescending(idSelector)
                .FirstOrDefault();

            return registroAnterior;
        }//EX: var clienteAnterior = LocalizarRegistroAnterior<Cliente>(5, c => c.Id);


    }
}
