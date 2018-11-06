using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            int M;

            Console.Write("Digite a quantidade de funcionarios: ");
            M = int.Parse(Console.ReadLine());

            List<Funcionario> lista = new List<Funcionario>();

            for (int i = 1; i<=M; i++)
            {
                Console.WriteLine("Digite os dados do " + i + "º funcionario: ");
                Console.Write("Nome: ");
                string Nome = Console.ReadLine();
                Console.Write("CPF: ");
                string Cpf = Console.ReadLine();
                Console.Write("Salario: R$");
                double Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Funcionario F = new Funcionario(Nome, Cpf, Salario);
                lista.Add(F);
            }

            Console.WriteLine(); 
            Console.Write("Digite o CPF do funcionario que reberá aumento: ");
            string CpfBuscado = Console.ReadLine();

            int pos = lista.FindIndex(x => x.Cpf == CpfBuscado);

            if (pos == -1)
            {
                Console.WriteLine("CPF INEXISTENTE!");
            }
            else
            {
                Console.Write("Digite a porcentagem de aumento: ");
                double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lista[pos].Aumentarsalario(porc);
            }
            Console.WriteLine();

            Console.WriteLine("Informações gerais dos funcionarios: ");

            for (int i=0; i<lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            Console.ReadLine();
        }
    }
}
