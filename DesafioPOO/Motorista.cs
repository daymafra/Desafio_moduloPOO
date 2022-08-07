using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    /*Herança usada na classe motorista para herdar atributos e métodos da classe usuário*/
    public class Motorista : Usuario
    {
        /*Atributo da classe Motorista*/
        public Veiculo InformacoesVeiculo { get; set; }

        /*Enum para informar o estado em que se encontra o motorista*/
        public enum EStatusMotorista
        {
            Disponível,
            Ocupado            
        }

        /*Método construtor passando como argumento o nome do motorista*/
        public Motorista(string nome)
        {
            Nome = nome;
        }
        /*Utilizando o Enum*/
        public EStatusMotorista EstatdoMotorista { get; set; }
        /*Método criado para informar se o motorista se encontra disponível ou não*/
        public void InformarStatusMotorista(EStatusMotorista estadoMotorista)
        {
            EstatdoMotorista = estadoMotorista;
            if(EstatdoMotorista == EStatusMotorista.Disponível)//Caso o motorista esteja no estado disponível a mensagem abaixo aparecerá
                Console.WriteLine("Motorista está disponível e logo chegará em seu local de partida");
            if(EstatdoMotorista == EStatusMotorista.Ocupado)//Case o motorista esteja ocupado, então a mensagem que aparecerá será esta abaixo
            {
                Console.WriteLine("Motorista se encontra ocupado no momento. Viagem rejeitada");
                Console.WriteLine("Procurando uma nova corrida..");
            }                
        }

        /*Método para que a corrida seja aceita*/
        public void AceitarCorrida()
        {
            Console.WriteLine("Corrida aceita pelo motorista");
        }
        /*Método para iniciar a corrida*/
        public void IniciarCorrida()
        {
            Console.WriteLine("Corrida iniciada");
        }
        /*Método para finalizar a corrida*/
        public void FinalizarCorrida()
        {
            Console.WriteLine("\nCorrida finalizada. Você chegou ao seu destino!");
        }
    }
}
