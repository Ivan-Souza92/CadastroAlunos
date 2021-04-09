using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class AlunoDto
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Curso { get; set; }
        public int Periodo { get; set; }
        public int anoIngresso { get; set; }
    }
}
