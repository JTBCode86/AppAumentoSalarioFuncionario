using System;

namespace AppAumentoSalarioFuncionario
{
    /// <summary>
    /// Exercicios - Fixação - POO - Classes
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            
            Console.WriteLine("Nome: ");
            funcionario.nome = Console.ReadLine();
            
            Console.WriteLine("Salario Bruto: ");
            funcionario.salarioBruto = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Imposto: ");
            funcionario.imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Funcionario "+ funcionario);

            Console.WriteLine();
            Console.WriteLine("Deseja aumentar o salario em qual percentual?");
            double percentual = double.Parse(Console.ReadLine());
            funcionario.aumentarSalario(percentual);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: "+ funcionario);
            Console.ReadLine();
        }
    }
}
