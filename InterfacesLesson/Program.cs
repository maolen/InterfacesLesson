using System;

namespace InterfacesLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            ISender sender = CreatorService.MessageSender;
            sender.To = "admin@gmail.com";
            sender.From = "bill@gmail.com";

            sender.SendMessage("Сломался интернет.");
            Console.ReadKey();
        }
    }
}
