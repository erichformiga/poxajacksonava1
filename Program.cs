using System;
using System.IO;
using System.Linq;

namespace ArquivoDesordenado
{
    class Program
    {
        static void Main(string[] args)
        {
           int count = 0;
            // Lê os números do arquivo que estão desordenados
            string[] numbers = File.ReadAllLines("input.txt");
            int[] intNumbers = Array.ConvertAll(numbers, int.Parse);
            Console.WriteLine($"Valores desordenados: {string.Join(",", intNumbers)}");
            // Usando a função sort consigo ordenar os números
            //Array.Sort(intNumbers);
            
            for (int j = 0; j <= numbers.Length - 2; j++)
            {
            
                for (int i = 0; i <= numbers.Length - 2; i++)
                {
                    count = count + 1;
                    if (intNumbers[i] > intNumbers[i + 1])
                    {
                        int temp = intNumbers[i + 1];
                        intNumbers[i + 1] = intNumbers[i];
                        intNumbers[i] = temp;
                    }
                }
            }
        
            Console.WriteLine($"Valores ordenados: {string.Join(",", intNumbers)}");

            // Efetuo a gravação dos números ordenados no arquivo
            StreamWriter writer = new StreamWriter("output.txt");
            foreach (int number in intNumbers)
            {
                writer.WriteLine(number);
            }

            Console.WriteLine("Arquivo gravado com sucesso!");
        }
    }
}