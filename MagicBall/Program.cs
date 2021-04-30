using System;
using System.Collections.Generic;


namespace MagicBall
{
    class Program
    {
        public static void Main(string[] args)
        {   
            Console.WriteLine("Это магический шар Вадима.");
            
            var todos = new List<string>() {
                "Абсолютно",
                "Да",
                "Вряд ли",
                "Как карта ляжет",
                "Лучше посиди на балконе",
                "Не об этом надо думать!",
                "Нет"
            };

            var repeat = "y";

            while (repeat != "n")
            {
                Console.WriteLine("Шо хочешь узнать?");
                Console.ReadLine();
                
                var random = new Random();
                var index = random.Next(todos.Count);
            
                Console.WriteLine(todos[index]);
                Console.WriteLine("Ещё что-нибудь хочешь узнать? (y/n)");
                repeat = Console.ReadLine();
            }
        }
    }
}