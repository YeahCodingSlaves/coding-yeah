using System;

namespace Slave
{
    class Program
    {
        static void Main(string[] args)
        {
            // R S P
            // 0 1 2

            var user = Int32.Parse(Console.ReadLine());
            
            var random = new Random();
            var pc = random.Next(0, 3);

            var diff = user - pc;

            var msg = $"{user} {pc}"
                .Replace("0", "R")
                .Replace("1", "S")
                .Replace("2", "P");
            Console.WriteLine(msg);

            if (diff == 0)
                Console.WriteLine("무승부");
            else if (diff < 0)
                Console.WriteLine("이김");
            else
                Console.WriteLine("짐");
        }
    }
}
