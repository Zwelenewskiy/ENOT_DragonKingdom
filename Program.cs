using System;

namespace DragonKingdom
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Прилижаемся к пещере...");
                Console.ReadKey();

                int chance = new Random().Next(1, 11);
                if((chance >= 1) && (chance <= 8))
                {
                    Console.WriteLine();
                    Console.WriteLine("Вы попали в пещеру к дружелюбному дракону!");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Не повезло: Вы попали в пещеру со злым драконом дракону!");
                    Console.ReadKey();

                    Console.WriteLine("Игрок погиб! Конец игры...");
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
