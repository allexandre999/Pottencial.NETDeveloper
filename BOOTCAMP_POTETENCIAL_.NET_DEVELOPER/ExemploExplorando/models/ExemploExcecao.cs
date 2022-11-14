using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.models
{
    public class ExemploExcecao
    {

        
        public void Metodo1()
        {
            try
            {
                Metodo2();
            }
            catch(Exception e){
                System.Console.WriteLine($"Exceção tratada no Metodo1(). Erro: {e.Message} ");
            }
            
        }

        public void Metodo2()
        {
            Metodo3();
        }

        public void Metodo3()
        {
            Metodo4();
        }
        public void Metodo4()
        {
            throw new Exception("Ocorreu uma exceção de entrada ou saida");
        }
    }

}