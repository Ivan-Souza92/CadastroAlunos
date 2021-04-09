using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Data.Collections
{
    public class Aluno
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Curso { get; set; }
        public int Periodo { get; set; }
        public int anoIngresso { get; set; }


        public Aluno(int matricula, string nome, string curso, int periodo, int ano_ingresso)
        {
            this.Matricula = matricula;
            this.Nome = nome;
            this.Curso = curso;
            this.Periodo = periodo;
            this.anoIngresso = ano_ingresso;
        }

        public Aluno(string nome, string curso, int periodo, int ano_ingresso)
        {
            this.Nome = nome;
            this.Curso = curso;
            this.Periodo = periodo;
            this.anoIngresso = ano_ingresso;
        }

    }
}