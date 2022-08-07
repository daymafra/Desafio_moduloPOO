using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    public class Veiculo
    {
        /*Atributos do veículo já definidos*/
        public string Placa = "JLK56";
        public string Cor = "Prata";
        public string Modelo = "Uno";        

        /*Método que retorna informações sobre o veículo*/
        public void InformarVeiculo()
        {
            Console.WriteLine("\nVeja atentamente os dados do veículo!");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Cor: {Cor}");
            Console.WriteLine($"Placa: {Placa}");
        }
    }
}
