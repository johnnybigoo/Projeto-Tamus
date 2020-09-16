using System;
namespace Tamus.Entities
{
    public class Dependente : Pessoa
    {
        
            private bool estudante;
            private Enum beneficio;

        public bool Estudante { get => estudante; set => estudante = value; }
    }
}
