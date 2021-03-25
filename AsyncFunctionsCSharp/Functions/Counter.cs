using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AsyncFunctionsCSharp.Functions
{
    public class Counter
    {

        public async Task<string> PrintNumbers()
        {

            for (int i = 0; i < 200; i++)
            {

                Console.WriteLine(i);
            }

            return await Task.FromResult("Ya terminé de imprimir los numeros en la función PrintNumbers");
        }
    }
}
