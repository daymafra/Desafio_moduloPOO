using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    public abstract class Usuario
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        protected string Email { get; set; }
        protected string Senha { get; set; }

        public void Cadastrar()
        {
            Console.WriteLine("\nUsuário cadastrado com sucesso!");
        }
        public void Logar(string email, string senha)
        {
            Email = email;
            Senha = senha;
            Console.WriteLine("Login efetuado com sucesso!");
        }
        public void CancelarViagem()
        {
            Console.WriteLine("Viagem cancelada!");
        }  
    }
}
