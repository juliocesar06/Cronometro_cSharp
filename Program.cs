using System.Runtime.InteropServices;
using System.ComponentModel.DataAnnotations;
using System;
using System.Threading;
namespace Cronometro
{
    class Program
    {
        // metodo padrao
        static void Main(string[] args)
        {

            int v = Menu();
            Start(v);
            fim();

        }

        // menu q escolhe os itens
        static int Menu()
        {
            string linha;
            Console.Clear();

            System.Console.WriteLine("m/ minutos  e s/ segundos");
            linha = Console.ReadLine();
            char tipo = char.Parse(linha);

            System.Console.WriteLine("coloque o valor do cronometro :");
            linha = Console.ReadLine();
            int v = Int32.Parse(linha);

            if (tipo == 'm' || tipo == 'M')
            {
                v = v * 60;
            }
            return v;


        }
        // funçao do fim do program
        static void fim()
        {
            Console.WriteLine("Terminou o programa...");

        }
        // funçao q inicia o contador
        static void Start(int time)
        {
            int Time = time;
            int time_atual = 0;

            while (Time != time_atual)
            {
                Console.Clear();
                time_atual++;
                System.Console.WriteLine($"{time_atual}s ==> {Time}s");
                Thread.Sleep(1000);

            }
        }

    }
}