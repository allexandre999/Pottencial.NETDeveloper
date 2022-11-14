using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploPOO.models;

namespace ExemploPOO.models
{
    public class ContaCorrente : Conta
    {

        public ContaCorrente(int numeroConta, decimal saldoInicial){
            NumeroConta = numeroConta;
            _saldo = saldoInicial;
        }

        public ContaCorrente(){}
        
        public int NumeroConta { get; set; }

        private decimal _saldo;

        public void Sacar(decimal valor) {
            
            if (_saldo >= valor){
                    _saldo -= valor;
                    System.Console.WriteLine("Saque realizado com sucesso!");
                    System.Console.WriteLine("Seu saldo disponível é: {0}",GetSaldo());
            }else{
                System.Console.WriteLine("Valor desejado é maior que o saldo disponível");
            }
             
        }

        public decimal GetSaldo(){
            return _saldo;
        }

        public override void Creditar(decimal valor){
            saldo += valor;
        }

    }
}