using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploPOO.models;

Conta c = new ContaCorrente();

c.Creditar(500);
c.ExibirSaldo();








//Heraça e Polimorfismo

/*
Aluno a1 = new Aluno("João", 20);
a1.Apresentar();
a1.Nota = 9;
*/

//Encapsulamento
/*
ContaCorrente c1 = new ContaCorrente(12345, 25000M);
c1.Sacar(1000M);
//System.Console.WriteLine("Saldo: {0}",c1.GetSaldo());
/*


//Abstração

/*Pessoa pessoa = new Pessoa();
pessoa.Nome = "João";
pessoa.Idade = 19;
pessoa.Apresentar();*/