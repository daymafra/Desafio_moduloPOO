using System;
using System.Threading;

namespace DesafioPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Passageiro passageiro = new Passageiro(nome: "Roberval", telefone: "555-62398", email: "roberval@email.com", senha: "senha123");
            Passageiro passageiro_01 = new Passageiro(nome: "Lukinha", telefone: "6654-564", email: "lukinha@email.com", senha: "123456789");
            Motorista motorista = new Motorista("Robertildo");
            Veiculo veiculo = new Veiculo();
            
            Console.WriteLine("Bem vindo(a)!");
            Console.WriteLine("Se já possui cadastro então faça login, se não, cadastre-se");
            passageiro.Cadastrar();
            passageiro.Logar("roberval@email.com", "senha123");
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
               Console.Write(".");                              
            }
            motorista.FinalizarCorrida();
            passageiro.EscolherPagamento(Passageiro.EFormaDePagamneto.Debito);
            passageiro.PagarMotorista();
            Thread.Sleep(20000);
            Console.Clear();
            
            Console.WriteLine("Bem vindo(a)!");
            Console.WriteLine("Se já possui cadastro então faça login, se não, cadastre-se");
            passageiro_01.Logar("lukinha@email.com", "123456789");
            Console.WriteLine("\nPara onde deseja ir?");
            passageiro_01.EscolherDestino();
            passageiro_01.LocalizarMotorista();
            motorista.InformarStatusMotorista(Motorista.EStatusMotorista.Ocupado);
            passageiro_01.CancelarViagem();

        }
    }
}
