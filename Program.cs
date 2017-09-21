using System;
using System.Linq;

namespace LinqTestes
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidarExistenciaDeNumerosImpares();
            ValidarNumerosQueNaoExistemNoSegundoArray();
        }

        private static void ValidarNumerosQueNaoExistemNoSegundoArray()
        {
            int[] primeiroArray = { 1, 3, 7, 29, 42, 98, 234, 93 };
            int[] segundoArray = { 4, 6, 93, 7, 55, 32, 3 };

            var numerosQueNaoExistemNoSegundoArray = primeiroArray.Except(segundoArray);

            Console.WriteLine("Problema 3:");
            foreach (var item in numerosQueNaoExistemNoSegundoArray)
                Console.Write($"{item},");
        }

        private static void ValidarExistenciaDeNumerosImpares()
        {
            int[] numeros = { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };

            var mensagem = numeros.Any(n => n % 2 != 0) ? "Existe número impar no array" : "Só existem números pares";
            Console.WriteLine("Problema 2:");
            Console.WriteLine($"{ mensagem}");
        }
    }
}
