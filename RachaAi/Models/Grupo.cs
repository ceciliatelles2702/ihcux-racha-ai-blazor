using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RachaAi.Models
{
    public class Grupo
    {
         public string Nome { get; set; }
        public string Categoria { get; set; }
        public decimal Valor { get; set; }
        public bool UsuarioDeve { get; set; }
    }
}