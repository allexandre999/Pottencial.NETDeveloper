using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.models
{
    public class Aluno : Pessoa
    {

        public Aluno(){}
        public Aluno(string nome, int idade){
            Nome = nome;
            Idade = idade;
        }

        public double Nota { get; set; }
    }
}