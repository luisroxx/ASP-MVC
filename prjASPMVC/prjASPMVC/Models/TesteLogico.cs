using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace prjEscola.Models
{
    public class TesteLogico
    {
        [Required]
        [Display(Name = "Quantidade de repetições")]
        public int QuantidadeIteracoes { get; set; }
    }
}