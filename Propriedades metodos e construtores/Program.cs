using Propriedades_metodos_e_construtores.Models;
using System.Globalization;
using Newtonsoft.Json;
using Models;

string conteudoArquivo = File.ReadAllText("Arquivo/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach( Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}" +
     $"Preco: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}


































// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1,"Material de escritorio", 25.00M, dataAtual);
// Venda v2 = new Venda(1,"Licença de software", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);

























// int numero = 15;
// bool ehpar = false;

// if ternario
// ehpar = numero % 2 == 0;

// Console.WriteLine($"O numero {numero} é " + (ehpar ? "par" : "impar"));



// if(numero % 2 == 0)
// {
//     Console.WriteLine($"O numero {numero} é par");
// }
// else
// {
//     Console,WriteLine($"O numero {numero} é impar")
// }



























// Pessoa p1 = new Pessoa("Pedro", "Arthur");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");

















// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasdoArquivo, quantidadedeLinhas) = arquivo.Lerarquivo("Arquivos/arquivoLeitura.txt");

// if(sucesso)
// {   
//    // Console.WriteLine("Quantidade linhas do arquivo" + quantidadedeLinhas);
//     foreach(string linha in linhasdoArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("não foi possivel ler o arquivo");
// }























// (int, string, string, decimal) tupla = (1, "Pedro", "Aethur", 1.80M);
//ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Pedro","Arthur", 1.80M);
//var outroExemploTuplaCreate = Tuple.Create(1, "Pedro","Arthur", 1.80M);

// Console.WriteLine($"id: {tupla.Item1}");
// Console.WriteLine($"id: {tupla.Item2}");
// Console.WriteLine($"id: {tupla.Item3}");
// Console.WriteLine($"id: {tupla.Item4}");













//  Dictionary<string, string> estados = new Dictionary<string, string>();

//  estados.Add("PE", "Pernambuco");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");

// foreach(var item in estados)
// {
//     Console.WriteLine($"chave:{item.Key}, valor: {item.Value}");

// }


// Console.WriteLine("------------//-----");

// estados.Remove("BA");
// estados["PE"] = "Pernambuco - valor alterado";

// foreach(var item in estados)
// {
//     Console.WriteLine($"chave: {item.Key}, valor: {item.Value}");
// }

// string chave = "BA";
// Console.WriteLine($"verificando o elemento: {chave}");

// if(estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }






















// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }




























// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo elemento:{fila.Dequeue()}");

// fila.Enqueue(10);
// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }















//  new ExemploExecao().Metodo1();









































// try
// {
// string[] linhas = File.ReadAllLines("Arquivos/darquivoLeitura.txt");

// foreach(string linha in linhas)
// {
//     Console.WriteLine(linha);
// }
// }
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não entrado. {ex.Message}");
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
// }
//  catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exeção genérica. {ex.Message}");
// }
// finally
// {
// Console.WriteLine("Chegou até aqui");
//}






























// string datastring = "2025-11-18 23:35";


// bool sucesso = DateTime.TryParseExact(datastring, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture,DateTimeStyles.None, out DateTime data);


// Console.WriteLine(data);


// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{datastring} não é uma data valida");
// }













































//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo ("pt-BR");

//decimal ValorMonetario = 82.40M;

//Console.WriteLine(ValorMonetario.ToString("N2"));

//double porcentagem = .3421;

//Console.WriteLine(porcentagem.ToString("P"));

//int numero = 123456;
//Console.WriteLine(numero.ToString("##-##-##"));



































//string numero1 = "10";
//string numero2 = "20";

//string resultado = numero1 + numero2;

//Console.WriteLine(resultado);

































































//Pessoa p1 = new Pessoa();
//p1.Nome = "Pedro";
//p1.Sobrenome = "Arthur";
//p1.Idade = 22;
//p1.Apresentar();