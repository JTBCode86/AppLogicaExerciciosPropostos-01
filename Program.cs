using System;

namespace AppLogicaExerciciosPropostos_01
{
    /// <summary>
    /// Exercícios sobre Estrutura Condicional (if-else)
    /// Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
    /// </summary>
    class Program
    {
        public static string ValidarNumero(int numero) 
        {
            string resultado = "";
            if (numero<0)
            {
                resultado = "Negativo";
            }
            else
            {
                resultado = "Não Negativo";
            }

            return resultado;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor de um número: ");
            string resultado = ValidarNumero(int.Parse(Console.ReadLine()));
            Console.Clear();
            Console.WriteLine("O seu número é: {0}", resultado);
            Console.ReadLine();
        }
    }
}
