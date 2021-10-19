using System;

namespace SalarioMinimoCalculo
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario, salario_minimo;
            float resultado;
            Program program = new Program();

            Console.WriteLine("Digite seu salário");
            salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o salário minimo atual:");
            salario_minimo = float.Parse(Console.ReadLine());

            resultado = program.Calculo(salario, salario_minimo);
            Console.WriteLine("Voce ganha {0} salários mínimos", resultado);
        }

        public float Calculo(float salario, float salario_minimo)
        {
            return salario / salario_minimo;
        }
    }
}

