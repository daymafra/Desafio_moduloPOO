using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    public class Motorista : Usuario
    {
        public Veiculo InformacoesVeiculo { get; set; }
        public enum EStatusMotorista
        {
            Disponível,
            Ocupado            
        }
        public Motorista(string nome)
        {
            Nome = nome;
        }
        public EStatusMotorista EstatdoMotorista { get; set; }
        public void InformarStatusMotorista(EStatusMotorista estadoMotorista)
        {
            EstatdoMotorista = estadoMotorista;
            if(EstatdoMotorista == EStatusMotorista.Disponível)
                Console.WriteLine("Motorista está disponível e logo chegará em seu local de partida");
            if(EstatdoMotorista == EStatusMotorista.Ocupado)
            {
                Console.WriteLine("Motorista se encontra ocupado no momento. Viagem rejeitada");
                Console.WriteLine("Procurando uma nova corrida..");
            }                
        }

        public void AceitarCorrida()
        {
            Console.WriteLine("Corrida aceita pelo motorista");
        }
        public void IniciarCorrida()
        {
            Console.WriteLine("Corrida iniciada");
        }
        public void FinalizarCorrida()
        {
            Console.WriteLine("\nCorrida finalizada. Você chegou ao seu destino!");
        }
    }
}
