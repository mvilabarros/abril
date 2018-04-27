using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace serv1_1
{
    class Program
    {
        static readonly private object l = new object();
        static Random random = new Random();
        static bool corriendo = true;
        static int cont = 0;


        static void carrera(Thread caballo, int numCaballo)
        {
            while (corriendo)
            {
                lock (l)
                {
                    if (corriendo)
                    {
                        if(cont == 5)corriendo = false;
                        Console.WriteLine("LLega el caballo numero: " + numCaballo);
                        Monitor.Pulse(l);
                    }
                    cont++;

                }
                Thread.Sleep(10);
            }
        }

        static void Main(string[] args)
        {
            Thread[] caballos = new Thread[6];
            for(int i = 0; i < 5; i++)
            {
                caballos[i] = new Thread(() => carrera(Thread.CurrentThread, i));
                caballos[i].Start();
            }
            lock (l)
            {
                Monitor.Wait(l);
                Console.WriteLine("Salida!");
            }
            Console.ReadKey();
        }
    }
}
