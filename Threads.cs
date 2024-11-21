using System;
using System.Threading;

namespace Tareas_Hilos
{
    public class Threads
    {
        static void Main(string[] args)
        {
            //Ejemplo de Threads (Hilos)
            // Creacion de hilos
            Thread Hilo_Numeros = new Thread(ImprimirNumeros);
            Thread Hilo_Letras = new Thread(ImprimirLetras);

            //Inicia ejecución
            Hilo_Numeros.Start();
            Hilo_Letras.Start();

            // Esto hace que el subproceso principal espere hasta que numberThread y letterThread hayan completado su ejecución antes de continuar.
            Hilo_Numeros.Join();
            Hilo_Letras.Join();

            Console.WriteLine("Ambos hilos completados");

        }

        static void ImprimirNumeros()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Numero: {i}");
                Thread.Sleep(500); // Simulate work
            }
        }
        static void ImprimirLetras()
        {
            for (char c = 'A'; c <= 'E'; c++)
            {
                Console.WriteLine($"Numero: {c}");
                Thread.Sleep(700); // Simulate work
            }
        }


    }
}
