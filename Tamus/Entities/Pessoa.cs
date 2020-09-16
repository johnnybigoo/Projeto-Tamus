using System;
namespace Tamus.Entities
{
    public class Pessoa
    {
       
            protected string nome, email, cpf;
            protected DateTime nascimento;

            public string Nome { get => nome; set => nome = value; }
            public string Email { get => email; set => email = value; }
            public string Cpf { get => cpf; set => cpf = value; }
            public DateTime Nascimento { get => nascimento; set => nascimento = value; }
        
    }
}
