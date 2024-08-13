using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // inicialização de variáveis
            List<string> placaValida = ["1","2","3","4","5","6","7","8","9","0","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","W","X","Y","Z"];
            string placa    = "";
            bool   condicao = true;

            // enquanto a placa informada não contiver o número correto de caracteres, letras e números, o processo continua
            // caso queira sair do cadastro, informar 0
            while (condicao)
            {
                Console.WriteLine("Digite a placa do veículo para estacionar ou 0(zero) para sair:");
                placa = Console.ReadLine();
                placa = placa.ToUpper();

                if (placa == "0")
                {
                    condicao = false;
                }
                else if (placa.Length != 7)
                {
                    Console.Clear();
                    Console.WriteLine("Placa inválida. Favor informar a placa completa.\n");
                }
                else
                {
                    condicao = false;
                    string posicao = "";
                    for (int x =0; x <placa.Length; x++){
                        if (x == placa.Length-1)
                        {
                            posicao = placa.Substring(x);
                        }
                        else
                        {
                            posicao = placa.Substring(x,1);
                        }
                        if (!placaValida.Contains(posicao))
                        {
                            Console.Clear();
                            Console.WriteLine("Placa inválida. Informar somente as letras e os números da placa sem espaço.\n");
                            condicao = true;
                            placa="";
                        }
                    }
                }
            }
            if (placa != "0")
            {
                veiculos.Add(placa);
                Console.WriteLine();
            }
        }

        public void RemoverVeiculo()
        {
            // inicialização de variáveis
            string  placa      = "";
            bool    condicao   = true;
            int     horas      = 0;
            decimal valorTotal = 0; 

            // enquanto a placa informada estiver não existir no cadastro de veículos, o processo continua
            // caso queira sair do cadastro, informar 0 
            // se a placa existir, calcula o valor do estacionamento de acordo com a quantidade de horas informadas
            while (condicao)
            {
                Console.WriteLine("Digite a placa do veículo para remover ou 0(zero) para sair:");
                placa = Console.ReadLine();
                placa = placa.ToUpper();

                if (placa == "0")
                {
                    condicao = false;
                }
                else if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                    while (horas ==0)
                    {
                        Console.Clear();
                        Console.WriteLine(placa);
                        Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                        string horasEstacionadas = Console.ReadLine();
                        Int32.TryParse(horasEstacionadas, out horas);
                    }
                    valorTotal = this.precoInicial + this.precoPorHora * horas;
                    this.veiculos.Remove(placa);

                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal.ToString("C")}\n");
                    condicao = false;
                }
                else if (placa.Length >0)
                {
                    Console.Clear();
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.\n");
                }
                else 
                {
                    Console.Clear();

                }
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string v in veiculos)
                {
                    Console.WriteLine(v);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
