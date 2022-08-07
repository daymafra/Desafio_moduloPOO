using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    /*Classe Passageiro herdando propriedades da classe Usuário*/
    public class Passageiro : Usuario
    {
        /*Atributos do Passageiro*/
        public string EnderecoEmbarque { get; set; }
        public string LocalDeDestino { get; set; }
        /*Enum criado para a forma que o passageiro deseja pagar a viagem*/
        public enum EFormaDePagamneto
        {
            Debito,
            Credito,
            Dinheiro
        }
        /*Utilizando o Enum*/
        public EFormaDePagamneto FormaDePagamento { get; set; }

        /*Método construtor da classe Passageiro passando como argumento o nome, telefone, email e senha*/
        public Passageiro(string nome, string telefone, string email, string senha)
        {                      
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Senha = senha;
        }
        /*Método para que o passageiro informe o endereço do local de partida*/
        public void InformarEnderecoDeEmabarque()
        {
            do
            {
                Console.Write("\nEndereço de Embarque: ");
                EnderecoEmbarque = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(EnderecoEmbarque));//Forma de validar a entrada de informações do passageiro para que ele digite algo em vez de simplesmente deixar tudo em branco e teclar [Enter]
        }
        /*Método para o passageiro informar seu local de destino*/
        public void EscolherDestino()
        {          
            do
            {
                Console.Write("\nLocal para onde deseja ir: ");
                LocalDeDestino = Console.ReadLine(); 
            } while (string.IsNullOrWhiteSpace(LocalDeDestino));//Forma de validar a entrada de informações do passageiro para que ele digite algo em vez de simplesmente deixar tudo em branco e teclar [Enter]
        }
        /*Método para procurar um motorista*/
        public void LocalizarMotorista()
        {
            Console.WriteLine("\nLocalizando motorista..");
        }
        /*Método para que a viagem seja confirmada*/
        public void ConfirmarViagem()
        {
            Console.WriteLine("\nSua corrida foi confirmada com sucesso!");
        }
        /*Utilização do Enum que retorna a forma de pagamento*/
        public EFormaDePagamneto formaDePagamento()
        {
            return FormaDePagamento;
        } 
        /*Método para o passageiro escolher como deseja pagar*/
        public void EscolherPagamento(EFormaDePagamneto FormaDepagamento)
        {
            /*Condições implementadas para cada caso de escolha*/
            FormaDePagamento = FormaDepagamento;
            if(FormaDePagamento == EFormaDePagamneto.Credito)
            {
                Console.WriteLine("Você escolheu pagar no crédito");
            }
            if (FormaDePagamento == EFormaDePagamneto.Debito)
            {
                Console.WriteLine("Você escolheu pagar no débito");
            }
            if (FormaDePagamento == EFormaDePagamneto.Dinheiro)
            {
                Console.WriteLine("Você escolheu pagar com dinheiro");
            }
        }
        /*Método usado para pagar o motorista*/
        public void PagarMotorista()
        {
            Console.WriteLine("Você pagou o motorista!");
        }
    }
}