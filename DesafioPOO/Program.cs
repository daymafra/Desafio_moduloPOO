using System;
using System.Threading;

namespace DesafioPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fazendo a instância e cadastro do passageiro*/
            Passageiro passageiro = new Passageiro(nome: "Roberval", telefone: "555-62398", email: "roberval@email.com", senha: "senha123");
            /*Fazendo a instância e cadastro do passageiro_01*/
            Passageiro passageiro_01 = new Passageiro(nome: "Lukinha", telefone: "6654-564", email: "lukinha@email.com", senha: "123456789");
            /*Instanciando a classe motorista*/
            Motorista motorista = new Motorista("Robertildo");
            /*Instância do veículo*/
            Veiculo veiculo = new Veiculo();
            
            /*Boas vindas, início e utilização dos métodos*/
            Console.WriteLine("Bem vindo(a)!");
            passageiro.Cadastrar();
            passageiro.Logar("roberval@email.com", "senha123");
            Console.WriteLine("\nInforme seu local de partida");
            passageiro.InformarEnderecoDeEmabarque();
            Console.WriteLine("\nPara onde deseja ir?");                      
            passageiro.EscolherDestino();
            passageiro.LocalizarMotorista();            

            motorista.AceitarCorrida();
            motorista.InformarStatusMotorista(Motorista.EStatusMotorista.Disponível);          
            Console.WriteLine($"Nome do motorista: {motorista.Nome}");
            veiculo.InformarVeiculo();
            passageiro.ConfirmarViagem();
            motorista.IniciarCorrida();            
            for(int i=0; i<=10; i++)
            {
               Console.Write(":");                              
            }
            motorista.FinalizarCorrida();

            bool opcaoValida = false;//Variável tipo booleana para validar a opção de entrada
            int opcao = 0;
            do
            {
                Console.WriteLine("\nInforme um meio de pagamento");
                Console.WriteLine("Digite o nº '1' para pagar no débito");
                Console.WriteLine("Digite o nº '2' para pagar no crédito");
                Console.WriteLine("Digite o nº '3' para pagar em dinheiro");
                var opcaoInformada = Console.ReadLine();//Faz a leitura do valor de entrada
                opcaoValida = int.TryParse(opcaoInformada, out opcao);//Valida a opção informada pelo passageiro verificando se o número que ele digitou é um valor válido referente as opções dadas acima
                if(!opcaoValida || opcao < 1 || opcao > 3)
                    Console.WriteLine("\nValor inválido! Por favor, informe uma opção de pagamento");
            } while (!opcaoValida || opcao < 1 || opcao > 3);//O laço fica se repetindo enquanto o passageiro não digitar uma opção de 1 a 3

            /*Umas dessas opções irão aparecer no console de acordo com a escolha do passageiro*/
            if(opcao == 1)
                passageiro.EscolherPagamento(Passageiro.EFormaDePagamneto.Debito);
            else if(opcao == 2)
                passageiro.EscolherPagamento(Passageiro.EFormaDePagamneto.Credito);
            else if(opcao == 3)
                passageiro.EscolherPagamento(Passageiro.EFormaDePagamneto.Dinheiro);

            passageiro.PagarMotorista();
            Thread.Sleep(5000);//Função usada para parar a execução do programa por um tempo especificado
            Console.Clear();//Limpa o console
            
            Console.WriteLine("Bem vindo(a)!");
            passageiro_01.Logar("lukinha@email.com", "123456789");
            Console.WriteLine("\nInforme seu local de partida");
            passageiro.InformarEnderecoDeEmabarque();
            Console.WriteLine("\nPara onde deseja ir?");
            passageiro_01.EscolherDestino();
            passageiro_01.LocalizarMotorista();
            motorista.InformarStatusMotorista(Motorista.EStatusMotorista.Ocupado);
            passageiro_01.CancelarViagem();

        }
    }
}
