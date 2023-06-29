
using GenshinQuake;
using GenshinQuake.Characters;

namespace ConsoleGenshin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Amber amber = new(50, 15);
            Eula eula = new(100, 10);
            amber.Say(Console.WriteLine);
            eula.Say(Console.WriteLine);
            Console.WriteLine("+-----------------------------+");

            bool amber_round = true;
            while (amber.IsAlive && eula.IsAlive)
            {
                if (amber_round)
                {
                    Console.WriteLine("Amber attacking...");
                    amber.Attacking(eula);
                    amber_round = false;
                }
                else
                {
                    Console.WriteLine("Eula attacking...");
                    eula.Attacking(amber);
                    amber_round = true;
                }

                amber.Say(Console.WriteLine);
                eula.Say(Console.WriteLine);
                Console.WriteLine("+-----------------------------+");
            }
            if (amber.IsAlive)
            {
                Console.WriteLine("Amber win~");
            }
            else
            {
                Console.WriteLine("Eula win~");
            }
        }
    }
}