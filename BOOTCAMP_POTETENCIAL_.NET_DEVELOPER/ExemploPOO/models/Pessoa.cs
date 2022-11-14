using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Abstração

namespace ExemploPOO.models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(){}

        public Pessoa(string nome, int idade){
            Nome = nome;
            Idade = idade;
        }

        public void Apresentar(){
            System.Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos\n");
        }
    }
}