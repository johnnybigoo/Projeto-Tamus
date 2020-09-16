using System;
namespace Tamus.Entities
{
    public class Funcionario : Pessoa
    {
       
        protected double salario;
        protected Dependente dependente;

        public double Salario { get => salario; }
        public Dependente Dependente { get => dependente; set => dependente = value; }


        /* 
         public ContaCorrente(double anuidade, string agencia, string numero, double saldo, Titular titular)
            : base(agencia, numero, saldo, titular)
        {
            this.anuidade = anuidade;
        }

        - calculaDescontoDoBeneficio():Double
        + calculaSalario(double salarioFixo): void
        + calculaSalario(int horasTabalhadas, double valorDaHora): void


        Regras para os funcionários:
         O nome e CPF são campos obrigatórios em para todos os funcionários.

        Médico (a)
         Não é possível criar médicos sem CRM.
         Recebem o salário por hora.
         Recebem um adicional fixo de 8% referente ao risco de contágio por contato com 
        doenças infecciosas. Além de um adicional de 15% se trabalharem mais de 120 horas no mês e 20%
        se trabalharem mais de 170 horas.
        
        Advogado (a)
         Não é possível criar advogados sem OAB.
         Recebem o salário por hora
         Recebem um adicional de R$120 para cada caso vencido em tribunal.

        Engenheiro (a)
         Não é possível criar engenheiros sem CREA.
         Recebem o salário por hora
         Não possuem adicional de serviço

        Secretário (a)
         Recebem salário fixo mensal
         Não possuem adicional de serviço
        
        
        Benefícios aos dependentes:
         Todos os funcionários têm direito a benefício para um dependente baseado na seguinte tabela
        de desconto:

        o Plano de Saúde  4%
        o Auxílio Educação  5%
        o Auxílio Nutricional e Esportivo  6%

         Por dependente considera-se filho (a) biológico (a) ou adotivo (a).
         Para ter direito ao Auxílio Educação o dependente tem que obrigatoriamente ser estudante.
         O limite de idade para os dependentes terem direito ao benefício é de 24 anos, ou 30 se 
        ainda forem estudantes.

         */
    }
}
