
using System;
using ExemploExplorando.models;


//Abstração

Pessoa pessoa = new Pessoa();
























//Par ou Impar

/*
int numero  = 5;
bool par = false;

//IF Ternário
par = numero.Ehpar();

string mensagem = "O número " + numero +" " + "é " + (par? "par" : "ímpar");
System.Console.WriteLine(mensagem);*/




//lista generica

/*
MeuArray<int> arrayInteiro = new MeuArray<int>();

arrayInteiro.AdicionarElementoArray(30);
arrayInteiro.AdicionarElementoArray(15);
arrayInteiro.AdicionarElementoArray(10);
arrayInteiro.AdicionarElementoArray(5);

System.Console.WriteLine(arrayInteiro[0]);
System.Console.WriteLine(arrayInteiro[1]);
System.Console.WriteLine(arrayInteiro[2]);
System.Console.WriteLine(arrayInteiro[3]);


MeuArray<string> arrayString = new MeuArray<string>();

arrayString.AdicionarElementoArray("string");
arrayString.AdicionarElementoArray("int");
arrayString.AdicionarElementoArray("bool");


System.Console.WriteLine(arrayString[0]);
System.Console.WriteLine(arrayString[1]);
System.Console.WriteLine(arrayString[2]);
/*




//Json

/*
DateTime dataAtual = DateTime.Now;

List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "Material de Escritório", 25.00M, dataAtual);
Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);

System.Console.WriteLine(serializado);*/



//new ExemploExcecao().Metodo1();

//TRABALHANDO COM EXCEÇÕES
/* try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt"); //Caminho correto do arquivo
    //string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");  // Nome errado do arquivo
    //string[] linhas = File.ReadAllLines("Arquivos/erro/arquivoLeitura.txt");  // Caminho errado do arquivo

    foreach(string linha in linhas)
    {
        System.Console.WriteLine(linha);
    }

}
catch(FileNotFoundException e)
{
    System.Console.WriteLine($"Erro. Arquivo não encontrado: {e.Message}");
}
catch(UnauthorizedAccessException e)
{
    System.Console.WriteLine($"Erro. Sem autorização para acessar arquivo: {e.Message}");
}
catch(DirectoryNotFoundException e)
{
    System.Console.WriteLine($"Erro. Caminho não encontrado: {e.Message}");
}
catch(Exception e)
{
    System.Console.WriteLine($"Erro não mapeado: {e.Message}");
}
finally
{
    System.Console.WriteLine("Ex: Utilizado para fechar conexão com banco independente de dar erro ou não!");
}


System.Console.WriteLine("Cheguei até aqui");
 */





/* 

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

decimal valorMonetario = 1582.40M;

System.Console.WriteLine($"{valorMonetario:C}");

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

System.Console.WriteLine($"{valorMonetario:C}"); */