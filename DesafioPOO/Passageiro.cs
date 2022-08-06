using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    public class Passageiro : Usuario
    {
        public string EnderecoEmbarque { get; set; }
        public string LocalDeDestino { get; set; }
        public enum EFormaDePagamneto
        {
            Debito,
            Credito,
            Dinheiro
        }
        public EFormaDePagamneto FormaDePagamento { get; set; }

        public Passageiro(string nome, string telefone, string email, string senha)
        {                      
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Senha = senha;
        }
        public void EscolherDestino()
        {          
            do
            {
                Console.Write("\nLocal para onde deseja ir: ");
                LocalDeDestino = Console.ReadLine(); 
            } while (string.IsNullOrWhiteSpace(LocalDeDestino));                       
        }
        public void LocalizarMotorista()
        {
            Console.WriteLine("\nLocalizando motorista..");
        }
        public void ConfirmarViagem()
        {
            Console.WriteLine("\nSua corrida foi confirmada com sucesso!");
        }
        public EFormaDePagamneto formaDePagamento()
        {
            return FormaDePagamento;
        } 
        public void EscolherPagamento(EFormaDePagamneto FormaDepagamento)
        {
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
        public void PagarMotorista()
        {
            Console.WriteLine("Você pagou o motorista!");
        }
    }
}