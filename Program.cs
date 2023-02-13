using System;
using System.IO;
using System.Linq;

namespace ArquivoDesordenado
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lê os números do arquivo que estão desordenados
            string[] numbers = File.ReadAllLines("input.txt");
            int[] intNumbers = Array.ConvertAll(numbers, int.Parse);
            
            // Usando a função sort consigo ordenar os números
            Array.Sort(intNumbers);
            
            // Efetuo a gravação dos números ordenados no arquivo
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                foreach (int number in intNumbers)
                {
                    writer.WriteLine(number);
                }
            }

            Console.WriteLine("Arquivo gravado com sucesso!");
            
            // Caminho utilizado para ler os arquivos com numeros ordenados e desordenados
            string path = @"C:\Erich\Acadêmico\Senac\Aulas\3-Fase\Desenvolvimento para Desktop\projetos\entrega_13-02-2023\entrega_13-02-2023\input.txt";
            string path2 = @"C:\Erich\Acadêmico\Senac\Aulas\3-Fase\Desenvolvimento para Desktop\projetos\entrega_13-02-2023\entrega_13-02-2023\output.txt";

            try
            {   // Ler caminho do arquivo desordenado
                string text = File.ReadAllText(path);
                Console.WriteLine("Conteúdo do arquivo desordenado: ");
                // Imprme em tela o arquivo desordenado
                Console.WriteLine(text);
                // Ler caminho do arquivo ordenado
                string text2 = File.ReadAllText(path2);
                Console.WriteLine("Conteúdo do arquivo ordenado: ");
                // Imprime em tela o arquivo ordenado
                Console.WriteLine(text2);
            }
            // Tratamento de mensagens de erro
            catch (FileNotFoundException)
            {
                Console.WriteLine("O arquivo não foi encontrado.");
            }
            catch (Exception)
            {
                Console.WriteLine("Ocorreu um erro ao ler o arquivo.");
            }
            // Julguei necessário utilizar o "Console.ReadKey", para que nao seja fechada a tela do terminal. Vi que seria uma boa prática
            //Console.ReadKey();

        }
    }
}