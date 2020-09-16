using System;
namespace Tamus.Entities
{
    public class Medico : Funcionario
    {

        private string crm, especializacao;
        public string Crm { get => crm; set => crm = value; }
        public string Especializacao { get => especializacao; set => especializacao = value; }

        /*
         + calculaSalario(int horasTrabalhadas, double valorDaHora): void
         
         */

    }
}
