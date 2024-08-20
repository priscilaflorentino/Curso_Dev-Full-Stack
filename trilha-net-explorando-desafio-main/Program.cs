using System.Diagnostics.Contracts;
using System.Linq.Expressions;
using System.Security.AccessControl;
using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cadastramento das suites existentes
Suite suiteP = new Suite(tipoSuite: "Premium Casal", capacidade: 2, valorDiaria: 200);
Suite suiteM = new Suite(tipoSuite: "Master",  capacidade: 3, valorDiaria: 150);
Suite suiteJ = new Suite(tipoSuite: "Junior",  capacidade: 2, valorDiaria: 100);
Suite suiteF = new Suite(tipoSuite: "Família", capacidade: 4, valorDiaria: 300);

Dictionary<int, Suite> lstSuite = new Dictionary<int, Suite>();
lstSuite.Add(1,suiteP);
lstSuite.Add(2,suiteM);
lstSuite.Add(3,suiteJ);
lstSuite.Add(4,suiteF);


// // Cria uma nova reserva, passando a suíte e os hóspedes
// Reserva reserva = new Reserva(diasReservados: 5);
// reserva.CadastrarSuite(suite);
// reserva.CadastrarHospedes(hospedes);

// // Exibe a quantidade de hóspedes e o valor da diária
// Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
// Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");

int qtdHospede      = 0;
int numSuite        = 0;
int diasHospedagem  = 0;
bool condicao       = true;
string nomeCompleto = "";
string[] nome;

List<Pessoa> lstHospedes;
Pessoa       pessoa;
Suite        suite;
Reserva      reserva;

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Reservar suíte");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            // informar a quantidade de dias de hospedagem
            condicao = true;
            while (condicao){
                try {
                    Console.WriteLine("Favor informar a quantidade de dias de hospedagem ou 0(zero) para sair:");
                    diasHospedagem = Convert.ToInt32(Console.ReadLine());
                    if ( diasHospedagem == 0 || diasHospedagem > 0 ) {
                        condicao = false;
                    }
                } catch (Exception ex) {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                }
            }
            if (diasHospedagem == 0){ 
                break;
            }

            // informar a quantidade de hóspedes
            condicao = true;
            while (condicao){
                try {
                    Console.WriteLine("Favor informar a quantidade de hóspedes ou 0(zero) para sair:");
                    qtdHospede = Convert.ToInt32(Console.ReadLine());
                    if (qtdHospede > 4){
                        Console.WriteLine("Não temos quartos para mais de 4 pessoas.");
                    }
                    else if ( qtdHospede == 0 || qtdHospede > 0) {
                        condicao = false;
                    }
                } catch (Exception ex) {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                }
            }
            if (qtdHospede == 0) {
                break;            
            }

            //Informar o nome dos hospedes
            bool sair = false;
            lstHospedes = new List<Pessoa>();
            for (int i=1; i<=qtdHospede; i++){
                condicao = true;
                while (condicao){
                    Console.WriteLine($"Favor informar nome completo do {i}o. hóspede ou 0(zero) para sair:");
                    nomeCompleto = Console.ReadLine();
                    if (nomeCompleto == "0" || nomeCompleto.Length > 0){
                        condicao = false;
                    }
                }
            
                if (nomeCompleto == "0") {
                    sair = true;
                    break;
                } else {
                    nome = nomeCompleto.Split(" ");
                    string sobrenome = "";
                    for (int n=1; n < nome.Count(); n++){
                        if (n==1){
                            sobrenome = nome[n];
                        }else{
                            sobrenome = sobrenome + " " +nome[n];
                        }
                    }
                    pessoa = new Pessoa(nome[0], sobrenome);
                    lstHospedes.Add(pessoa);
                }
            }
            if ((sair)) {
                break;
            }

            // escolher suite
            condicao = true;
            while (condicao){
                try {
                    Console.Clear();
                    Console.WriteLine("Suítes disponíveis:");
                    foreach (var vlr in lstSuite) {
                        if (qtdHospede <= vlr.Value.Capacidade){
                            Console.WriteLine($"Suítes {vlr.Key} - Tipo: {vlr.Value.TipoSuite} - Capacidade: {vlr.Value.Capacidade} - Diária: {vlr.Value.ValorDiaria}");
                        }
                    }                
                    Console.WriteLine("");
                    Console.WriteLine("Favor escolher o número da suíte desejada:");
                    numSuite = Convert.ToInt32(Console.ReadLine());
                    condicao = false;
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }
             if (lstSuite.ContainsKey(numSuite)) {
                suite = lstSuite[numSuite];

                reserva = new Reserva(diasHospedagem);
                reserva.CadastrarSuite(suite);
                reserva.CadastrarHospedes(lstHospedes);
                Console.Clear();
                Console.WriteLine("Dados da reserva:");
                Console.WriteLine($"Dias de hospedagem: {reserva.DiasReservados}");
                Console.WriteLine();
                Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()} pessoa(s)");
                foreach (Pessoa p in lstHospedes){
                    Console.WriteLine(p.NomeCompleto);
                }
                Console.WriteLine();
                Console.WriteLine($"Suíte {reserva.Suite.TipoSuite} - Capacidade: {reserva.Suite.Capacidade} - Diária: {reserva.Suite.ValorDiaria}");
                Console.WriteLine($"Valor total: {reserva.CalcularValorDiaria()}");
            } else {
                Console.WriteLine("Suíte informada não existe. Favor realizar a reserva novamente.");
            }
            
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");