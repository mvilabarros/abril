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
        static bool[] tropezar = new bool[5]; // { true, true, true, true, true };
        static int apuesta = -1;
        static int ganador;
        static void carrera(object numCaballo)
        {
            int avance;
            int cont = 0;
            int tropiezo = 0;
            int caballo = Convert.ToInt32(numCaballo);

            while (corriendo)
            {
                lock (l)
                {
                    if (corriendo)
                    {
                        avance = 2;
                        if (tropezar[caballo - 1]) //si tropezar false pierde turno en cambiarlo a true
                        {
                            cont += avance;
                            if (cont >= 76)
                            {
                                corriendo = false;
                                ganador = caballo;
                                Console.SetCursorPosition(1, 0);
                                Console.WriteLine("LLega el caballo numero: " + caballo);
                                
                              
                                Monitor.Pulse(l);
                            }
                            Console.SetCursorPosition(cont, (caballo * 2));
                          //  for (int i = 1; i < avance; i++)
                            {
                                Console.Write("~");
                            }
                        }
                        else
                        {
                            tropezar[caballo - 1] = true;
                            tropiezo++;
                            Console.SetCursorPosition(cont, (caballo * 2));
                          //  for (int i = 1; i < avance; i++)
                            {
                                Console.Write("X");
                            }
                            Console.SetCursorPosition(1, (caballo + 12));
                            Console.WriteLine("Caballo " + caballo + " pierde turno: " + tropiezo);
                        }
                    }
                }
                //Thread.Sleep(random.Next(0, 2000));
                Thread.Sleep(300);
            }
        }


        static void parar()
        {
            while (corriendo)
            {
                lock (l)
                {
                    if (corriendo)
                    {
                        int valor = random.Next(0, 5);
                        tropezar[valor] = false;
                     //   Monitor.Pulse(l);
                    }
                }
                Thread.Sleep(2000);
            }
        }


        static void Main(string[] args)
        {
            try
            {
                Console.SetCursorPosition(0, 20);
                while (apuesta < 0 || apuesta > 5)
                {
                    Console.WriteLine("Introduce número caballo (1-5): ");
                    apuesta = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 2; i <= 10; i += 2)
                {
                    Console.SetCursorPosition(75, i);
                    Console.Write("|");
                }

                for (int i = 0; i < tropezar.Length; i++)
                {
                    tropezar[i] = true;
                }

                Thread par = new Thread(parar);
                Thread[] caballos = new Thread[5];

                for (int i = 0; i < caballos.Length; i++)
                {
                    caballos[i] = new Thread(carrera);
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("¡La carrera ha empezado!");

                for (int i = 0; i < caballos.Length; i++)
                {
                    caballos[i].Start(i + 1);
                }
                par.Start();

                lock (l)
                {
                    Monitor.Wait(l);
                    Console.SetCursorPosition(1, 25);
                    if (apuesta == ganador)
                    {
                        Console.WriteLine("Has ganado la apuesta!");
                        Console.WriteLine("Apuesta: " + apuesta + " Ganador: " + ganador);
                    }
                    else
                    {
                        Console.WriteLine("Has perdido la apuesta!");
                        Console.WriteLine("Apuesta: " + apuesta + " Ganador: " + ganador);
                    }
                }
            }
            catch (Exception)
            {

            }
            Console.ReadKey();
        }
    }
}

/*
 for (int i = 0; i < 4; i++)
    {
        int localNum = i;
        threadsArray[i] = new Thread(() => c1.k(localNum));
    }
*/