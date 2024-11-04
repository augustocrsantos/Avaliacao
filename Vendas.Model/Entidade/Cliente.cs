using System;
using System.ComponentModel.DataAnnotations;
using Vendas.Model.Entidade;
using static Vendas.Model.Enum.TipoDocumentoEnum;

namespace Vendas.Model
{
    public class Cliente
    {
        [Required]
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }    

        [Range(0, 1)]
        public TipoDocumento TipoDocumento { get; set; }

        public string Documento { get; set; }

        [MaxLength(50)]
        public Cidade Cidade { get; set; }

       
        public bool Situacao { get; set; }
  
    }
}
