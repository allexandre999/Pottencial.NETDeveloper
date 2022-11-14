using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.models
{
    public abstract class Conta
    {

        public Conta(){}
        protected decimal saldo;

        public abstract void Creditar(decimal valor);

        public void ExibirSaldo(){
            System.Console.WriteLine("O seu saldo é : " + saldo);
        }


    }
}