using System;
using System.Linq;
using System.Threading.Tasks;
using AsyncFunctionsCSharp.Functions;

namespace AsyncFunctionsCSharp
{
    class Program
    {

        static void Main(string[] args)
        {
            Counter counter = new Counter();
            string stringTask = "";
            bool secondaryTaskFinished = false;

            Task.Run(async () =>
            {
                //Este es el segundo hilo de mi programa
                stringTask = await counter.PrintNumbers();

            }).ContinueWith(cont =>
            {
                Console.WriteLine("Terminó la tarea en segundo plano!!");
                secondaryTaskFinished = true;
            });

            Console.WriteLine("Este es el hilo principal de mi programa");

            while (!secondaryTaskFinished)
                Console.WriteLine("Esperate, todavía no termino!! D:");


        }
    }
}
