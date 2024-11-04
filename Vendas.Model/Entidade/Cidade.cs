using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.Model.Enum;

namespace Vendas.Model.Entidade
{
    public class Cidade
    {
        [Required]
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Nome { get; set; }

        [MaxLength(2)]
        [Required]
        public SiglaEstadoEnum.SiglaEstado SiglaEstado { get; set; }
        
        
    }
}
