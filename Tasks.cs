using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tareas_Hilos
{
    public  class Tasks
    {
        static async Task  Main()
        {
            Task task1 = Task.Run(() =>
            {
                Task.Delay(2000).Wait(); // Simula trabajo.
                Console.WriteLine("Tarea 1 completada.");
            });

            Task task2 = Task.Run(() =>
            {
                Task.Delay(1000).Wait(); // Simula trabajo.
                Console.WriteLine("Tarea 2 completada.");
            });

            await Task.WhenAny(task1, task2); // Espera a que una termine.
            Console.WriteLine("Al menos una tarea ha terminado.");


        }
    }
}
