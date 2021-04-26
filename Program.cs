using System;

namespace Media4Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--Média para notas--");
            Console.WriteLine();
            Console.ResetColor();

            Console.WriteLine("Digite as suas notas abaixo!");
            Console.WriteLine();

            Console.Write("Nota 1: ");
            double um = double.Parse(Console.ReadLine());

            Console.Write("Nota 2: ");
            double dois = double.Parse(Console.ReadLine());

            Console.Write("Nota 3: ");
            double tres = double.Parse(Console.ReadLine());

            Console.Write("Nota 4: ");
            double quatro = double.Parse(Console.ReadLine());

            double media = (um + dois + tres + quatro) / 4;
            
            if (um >10.0 || dois >10.0 || tres >10.0 || quatro >10.0 || um <0 || dois <0 || tres <0 || quatro <0)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Digite somente notas entre 0 e 10.");
                Console.ResetColor();
                Console.WriteLine();
                Environment.Exit(-1);
                
            }
            else if (media <5.0)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Média final {media}. Resultado..: Reprovado");
                Console.WriteLine();
                Console.ResetColor();
            }
            else if (media >= 5.0 && media <=6.0)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Média final {media}. Resultado..: Em Recuperação");
                Console.WriteLine();
                Console.ResetColor();
            }
            else if (media >= 6.0)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"Média final {media}. Resultado..: Aprovado");
                Console.WriteLine();
                Console.ResetColor();
            }
        }
   }
}
