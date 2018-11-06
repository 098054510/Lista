using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Lista
{
    class Funcionario
    {
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public double Salario { get; private set; }

        public Funcionario(string Nome, string Cpf, double Salario)
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Salario = Salario;
        }

        public void Aumentarsalario(double porcentagem)
        {
            Salario = porcentagem * Salario / 100.0 + Salario;
        }

        public override string ToString()
        {
            return "Nome: " 
                + Nome
                + ", "
                + "CPF: "
                + Cpf
                + ", "
                + "Salario: R$"
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
