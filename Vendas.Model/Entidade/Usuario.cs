using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Vendas.Model.Enum.PermissaoEnum;

namespace Vendas.Model
{
    public class Usuario
    {
        [Required]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

       // public Funcionario Funcionario { get; set; }    

        [Range(0, 1)]
        public Permissao Permissao { get; set; }
    }
}
