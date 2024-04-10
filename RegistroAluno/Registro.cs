using System.Text.RegularExpressions;
using System.Linq;
namespace Dominio
{
    public class Registro
    {
        private string nome;
        private string numMatricula;
        private string email;
        private string telefone;

        public Registro(string nome, string numMatricula, string email, string telefone)
        {
            if (string.IsNullOrEmpty(numMatricula)) throw new ArgumentException("Matrícula Obrigatória");
            if (string.IsNullOrEmpty(nome)) throw new ArgumentException("Nome Obrigatório");
            if (string.IsNullOrEmpty(email)) throw new ArgumentException("Email Obrigatório");
            if (!EmailValido(email)) throw new ArgumentException("Email Inválido");

            this.Nome = nome;
            this.NumMatricula = numMatricula;
            this.Email = email;
            this.Telefone = telefone;
        }

        public string Nome { get => nome; set => nome = value; }
        public string NumMatricula { get => numMatricula; set => numMatricula = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }

        public bool EmailValido(string email)
        {
            return Regex("^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$");
        }
    }
}