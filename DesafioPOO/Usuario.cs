using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    public abstract class Usuario
    {
        /*Atributos da classe Usuário*/
        public string Nome { get; set; }
        public string Telefone { get; set; }
        protected string Email { get; set; }
        protected string Senha { get; set; }

        /*Método para cadastrar usuário*/
        public void Cadastrar()
        {
            Console.WriteLine("\nUsuário cadastrado com sucesso!");
        }

        /*Método para o usuário fazer login passando como argumento o email e a senha*/
        public void Logar(string email, string senha)
        {
            Email = email;
            Senha = senha;
            Console.WriteLine("Login efetuado com sucesso!");
        }

        /*Método para o usuário cancelar uma corrida ou viagem*/
        public void CancelarViagem()
        {
            Console.WriteLine("Viagem cancelada!");
        }  
    }
}
