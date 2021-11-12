using System;
using System.Threading;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = PrintAll();
            Console.ReadKey();
        }
        public static async Task PrintAll()
        {
            for (int i = 0; i <10; i++)
            {
                    await PrintA();
                    await PrintB();
            }


        }
        public static async Task PrintA()
        {
            await Task.Run(() =>
            {

                for (int i = 0; i <2; i++)
                {
                    Console.WriteLine("A");
                    Task.Delay(50).Wait();

                }
            });
        }
        public static async Task PrintB()
        {
            await Task.Run(() =>
            {
                    Console.WriteLine("B");
                    Task.Delay(20).Wait();
            });
        }
    }

}
