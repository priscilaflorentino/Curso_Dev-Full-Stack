// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// importar classe
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

// pacote para definicao de localização
using System.Globalization;

using Projetos.Common.Models;
using System.Collections;

//pacote para serializar objetos no formato JSON
using Newtonsoft.Json;
using Projetos.Common.Models;

//Definição da localização
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

Console.WriteLine("");

// instanciar uma classe
// Pessoa p1 = new Pessoa("Priscila", "Florentino");
// p1.Idade = 49;
// p1.Apresentar();

// //desconstrutor
// (string nome, string sobrenome) = p1;
// Console.WriteLine($"{nome} {sobrenome}");

// Pessoa p2 = new Pessoa(nome: "André", sobrenome: "Florentino");
// p2.Idade = 48;
// p2.Apresentar();
// Console.WriteLine("");

// Curso curso = new Curso();
// curso.Nome = "Inglês";
// curso.Alunos = new List<Pessoa>();
// curso.AdicionarAluno(p1);
// curso.AdicionarAluno(p2);
// curso.ListarAlunos();

// //---------------------------------------------------------------------
// // tipos de dados:
// // string
// // char (unicode)
// // object
// // bool

// // decimal 
// // float
// // double

// // byte (variação do int de 0 a 255)
// // short
// // int
// // uint (u == sem sinal, não representa números negativos. 
// //       Dobra a capacidade de valores positivos)
// // long
// // ulong

// float NumeroFloat = 1.90F;
// decimal NumeroDecimal = 1.90M;
// double NumeroDouble = 1.90;

// Console.WriteLine(NumeroFloat);
// Console.WriteLine(NumeroFloat.ToString("0.000"));
// Console.WriteLine(NumeroDecimal);

//Formatação
// Console.WriteLine($"{NumeroDecimal:c}"); //currency
//mesmo com a formatação definida no inicio do programa, posso alterar linhas específicas
// Console.WriteLine(NumeroDecimal.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); //currency
// Console.WriteLine(NumeroDecimal.ToString("c3")); //currency
// Console.WriteLine(NumeroDecimal.ToString("n3")); //número

// double porcentagem = 0.3421;
// Console.WriteLine(porcentagem.ToString("P0")); //porcentagem

// int numero = 123456;
// Console.WriteLine(numero.ToString("0000-##-##")); //currency

// Console.WriteLine(NumeroDouble);
// Console.WriteLine("");


//  DateTime data = DateTime.Now;

// Console.WriteLine(data);
// Console.WriteLine(data.AddDays(5));
// Console.WriteLine(data.ToString("dd/MM/yyyy"));
// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data.ToString("HH:mm"));
// Console.WriteLine(data.ToShortTimeString());

// string dataString = "28/07/1975 17:30";
// bool retorno = DateTime.TryParseExact(dataString, 
//                       "dd/MM/yyyy HH:mm", 
//                       CultureInfo.InvariantCulture, 
//                       DateTimeStyles.None, 
//                       out DateTime data3);

// Console.WriteLine(dataString);
// Console.WriteLine(data3);
// if (retorno)
// {
//     Console.WriteLine("Data convertida com sucesso.");
// }

// //---------------------------------------------------------------------

// //cast (conversão de tipos)

// int a = Convert.ToInt32("5");
// string b = Convert.ToString(a);
// string d = a.ToString();

// // Parse - conversão de tipos
// int c = int.Parse("5");

// int e = int.MaxValue;
// double f = e; //cast implícito desde que o tamanho em bytes seja maior ou igual

// //Se não conseguir converter b, mostra o valor de a e não dá erro no sistema
// int.TryParse(b, out a);  
// //---------------------------------------------------------------------

// if (d == b || c == e)
// {
//     Console.WriteLine("PIPE = or");
// }    
// else if (d == "r" && a == 1)
// {
//     Console.WriteLine("&& = and");
// }
// else if (!(d == "r") && !(a == 1))
// {
//     Console.WriteLine("! = not");
// }
// else
// {
//     Console.WriteLine("Diferente");
// }

// Console.WriteLine("Digite uma letra: ");
// string letra = "a"; // Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "b":
//     case "c":
//         Console.WriteLine("É vogal");
//         break;
//     default:
//         Console.WriteLine("Não é vogal");
//         break;

// }
// //---------------------------------------------------------------------

// Calculadora calculadora = new Calculadora();

// calculadora.Somar(10,5);
// calculadora.Subtrair(10,5);
// calculadora.Multiplicar(10,5);
// calculadora.Dividir(10,5);

// calculadora.Potenciar(2,3);
// calculadora.Raiz(9);

// calculadora.Seno(30);
// calculadora.Coseno(30);
// calculadora.Tangente(30);
// //---------------------------------------------------------------------

// int x = 0;
// while (x < 5)
// {
//     Console.WriteLine("While: "+ x);
//     x++;
// }

// for (int y=0; y<5; y++)
// {
//     Console.WriteLine("for: "+ y);
// }

// x=0;
// do 
// {
//     Console.WriteLine("Digite um número (0 para sair)");
//     x = Convert.ToInt32(Console.ReadLine());
// } while (x != 0);


// // Menu interativo

// int opcao = 0;
// while (opcao != 4)
// {
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Convert.ToInt32(Console.ReadLine());

//     switch(opcao)
//     {
//         case 1:
//             Console.WriteLine("Cadastrar cliente\n");
//             break;
//         case 2:
//             Console.WriteLine("Buscar cliente\n");
//             break;
//         case 3:
//             Console.WriteLine("Apagar cliente\n");
//             break;
//         case 4:
//             Console.WriteLine("Encerrar\n");
// //            Environment.Exit(0); // Sai do programa,não continua o código. É como um (Control-C)
//             break;
//         default:
//             Console.WriteLine("Opção inválida\n");
//             break;
//     }
    
// }
// //---------------------------------------------------------------------

// int[] a1 = new int[4];
// a1[0] = 1;
// a1[1] = 2;
// a1[2] = 3;
// a1[3] = 4;

// int[] a2 = new int[]{1,2,3,4};
// string[] a3 = {"a","b"};

// Array.Resize(ref a2, a2.Length*2);

// Array.Copy(a1,a2,a1.Length);
// a2[1] = 5;

// foreach (int i in a1)
// {
//     Console.WriteLine(i);
// }

// Console.WriteLine();

// foreach (int i in a2)
// {
//     Console.WriteLine(i);
// }

// List<int> l1 = new List<int>();
// l1.Add(1);
// l1.Add(2);

// foreach (int i in l1){
//     Console.WriteLine(i);
// }



//---------------------------------------------------------------------
// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/Arquivo.txt");
//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine("Arquivo não encontrado.");
//     Console.WriteLine(ex.FileName);    
// }
// catch (Exception ex)
// {
//     Console.WriteLine("Exceção não prevista.");
//     Console.WriteLine(ex.Message);
// }
// finally
// {
//     Console.WriteLine("Sistema finalizado.");
// }
//---------------------------------------------------------------------

//new ExemploExcecao().Metodo1();
//---------------------------------------------------------------------

//Coleção do tipo Fila - Regra FIFO (First in first out)

// Queue<int> fila = new Queue<int>();
// fila.Enqueue(1);
// fila.Enqueue(2);
// fila.Enqueue(3);
// fila.Enqueue(4);

// foreach (int i in fila)
// {
//     Console.WriteLine(i);
// }

// Console.WriteLine();

// fila.Dequeue();
// foreach (int i in fila)
// {
//     Console.WriteLine(i);
// }

//---------------------------------------------------------------------
//Coleção do tipo Pilhas - Regra LIFO (Last in first out)

// Stack<int> pilha = new Stack<int>();

// pilha.Push(1);
// pilha.Push(2);
// pilha.Push(3);
// pilha.Push(4);

// foreach (int i in pilha)
// {
//     Console.WriteLine(i);
// }

//  Console.WriteLine();

// pilha.Pop();
// foreach (int i in pilha)
// {
//     Console.WriteLine(i);
// }

//---------------------------------------------------------------------
//Dicionário - lista com chave e valor 

// Dictionary<string, int>  dic = new Dictionary<string, int>();

// dic.Add("chave1", 1);
// dic.Add("chave2", 2);
// dic.Add("chave3", 3);
// dic.Add("chave4", 4);
// dic.Add("chave5", 5);

// foreach (KeyValuePair<string, int> vlr in dic)
// {
//     Console.WriteLine(vlr);
// }
// //ou
// Console.WriteLine();
// dic["chave3"] = 10;

// foreach (var vlr in dic)
// {
//     Console.WriteLine($"{vlr.Key} - {vlr.Value}");
// }

// bool ret = dic.Remove("Chave2");
// Console.WriteLine(ret);
// Console.WriteLine();
// foreach (var vlr in dic)
// {
//     Console.WriteLine($"{vlr.Key} - {vlr.Value}");
// }

// ret= dic.ContainsKey("chave1");
// Console.WriteLine(ret);

// ret= dic.ContainsValue(10);
// Console.WriteLine(ret);

//---------------------------------------------------------------------
//Tupla

// (int, string, string) tupla =(1, "Priscila", "Florentino");

// Console.WriteLine(tupla.ToTuple());
// Console.WriteLine(tupla.Item1);
// Console.WriteLine(tupla.Item2);
// Console.WriteLine(tupla.Item3);
// //ou
// (int Id, string Nome, string Sobrenome) tupla4 =(4, "Priscila", "Florentino");

// Console.WriteLine(tupla4.ToTuple());
// Console.WriteLine(tupla4.Id);
// Console.WriteLine(tupla4.Nome);
// Console.WriteLine(tupla4.Sobrenome);

// //ou
// ValueTuple<int, string, string> tupla2 = (2, "Priscila", "Florentino");
// Console.WriteLine(tupla2.ToTuple());
// Console.WriteLine(tupla2.Item1);
// Console.WriteLine(tupla2.Item2);
// Console.WriteLine(tupla2.Item3);



// //ou
// var tupla3 = Tuple.Create(3, "Priscila", "Florentino");
// Console.WriteLine(tupla3.ToValueTuple());
// Console.WriteLine(tupla3.Item1);
// Console.WriteLine(tupla3.Item2);
// Console.WriteLine(tupla3.Item3);

// LeituraArquivo arquivo = new LeituraArquivo();
// var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/Arquivo.txt");

// Console.WriteLine(sucesso);
// foreach (string l in linhasArquivo) {
//     Console.WriteLine(l);
// }
// Console.WriteLine(quantidadeLinhas);

// //descarte de variável na tupla
// var (sucesso2, linhasArquivo2, _) = arquivo.LerArquivo("Arquivos/Arquivo.txt");

//---------------------------------------------------------------------
// if ternário no console

// int num = 20;
// bool ePar = false;
// ePar = num%2 == 0;
// Console.WriteLine("O número é " + (ePar ? "par":"impar"));

//---------------------------------------------------------------------
//Serializacao de objeto
DateTime dataAtual = DateTime.Now;

 Vendas venda1 = new Vendas(1, "Material de escritório", 25.00M, dataAtual);
// Vendas venda2 = new Vendas(2, "Licença de software", 25.00M, dataAtual);

 string serializado = JsonConvert.SerializeObject(venda1);
 Console.WriteLine(serializado);

// // o Formatting deixa a visualização melhor, mas criar um arquivo maior em bytes.
// string serializado2 = JsonConvert.SerializeObject(venda1, Formatting.Indented);
// Console.WriteLine(serializado2);
// File.WriteAllText("Arquivos/vendas.json", serializado2);

// List<Vendas> lstVendas = new List<Vendas>();
// lstVendas.Add(venda1);
// lstVendas.Add(venda2);
// string serializado3 = JsonConvert.SerializeObject(lstVendas);
// Console.WriteLine(serializado3);
// File.WriteAllText("Arquivos/vendas2.json", serializado3);

// A data representada no arquivo JSON usa a ISO 8601

//---------------------------------------------------------------------
//Deserializar um objeto

// string arquivo = File.ReadAllText("Arquivos/vendas.json");
// Console.WriteLine(arquivo);
// Vendas v = JsonConvert.DeserializeObject<Vendas>(arquivo);
// if (v != null){
//     Console.WriteLine($"Id: {v.Id} - Produto: {v.Produto} - Preço: {v.Preco} - Data: {v.DataVenda.ToString("dd/MM/yyyy")}");
// }

// Console.WriteLine("");

// arquivo = File.ReadAllText("Arquivos/vendas2.json");
// Console.WriteLine(arquivo);
// List<Vendas> lstVenda = JsonConvert.DeserializeObject<List<Vendas>>(arquivo);
// foreach (Vendas venda in lstVenda){
//     Console.WriteLine($"Id: {venda.Id} - Produto: {venda.Produto} - Preço: {venda.Preco} - Data: {venda.DataVenda.ToString("dd/MM/yyyy")}");
// }

//---------------------------------------------------------------------
