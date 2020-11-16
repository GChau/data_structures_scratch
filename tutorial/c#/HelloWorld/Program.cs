using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n君のン前は何ですか? ");
            string name = Console.ReadLine();
            var date = DateTime.Now;
            var greeting = date.Hour < 12 ? "こんにち" : "今晩";
            Console.WriteLine($"\n{greeting}, {name}, {date:d}日、 {date:t}時!");
            Console.Write($"何れかのキーを押してください！");
            Console.ReadKey(true);
        }
    }
}
