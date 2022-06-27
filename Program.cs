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
            preStart();
            Start(v);
            fim();

        }

        // menu q escolhe os itens
        static int Menu()
        {
            string linha;
            Console.Clear();

            System.Console.WriteLine("-s/ segundos");
            System.Console.WriteLine("-m/ minutos");
            System.Console.WriteLine("x sair");
            linha = Console.ReadLine();
            char tipo = char.Parse(linha);
            int v = 0;



            if (tipo == 'm' || tipo == 'M')
            {
                System.Console.WriteLine("coloque o valor do cronometro :");
                linha = Console.ReadLine();
                v = Int32.Parse(linha);
                v = v * 60;
            }

            else if (tipo == 'x' || tipo == 'X')
            {
                v = 0;
            }
            else
            {
                System.Console.WriteLine("coloque o valor do cronometro :");
                linha = Console.ReadLine();
                v = Int32.Parse(linha);

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

            while (Time != time_atual && Time != 0)
            {
                Console.Clear();
                time_atual++;
                System.Console.WriteLine($"{time_atual}s ==> {Time}s");
                Thread.Sleep(1000);

            }
        }

        static void preStart()
        {
            Console.Clear();
            System.Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            System.Console.WriteLine("Set...");
            Thread.Sleep(1000);
            System.Console.WriteLine("Go...");
            Thread.Sleep(1000);
        }

    }
}