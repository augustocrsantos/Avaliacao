using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.Data.Configuracoes;

namespace Vendas.Data.Controller
{
    public class CidadeController :GenericoController
    {
        private Contexto Contexto { get; set; }

        public CidadeController()
        {
            Contexto = new Contexto();
        }
    }
}
