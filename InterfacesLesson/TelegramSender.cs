using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesLesson
{
    public class TelegramSender : ISender
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Text { get; set; }

        string ISender.Text { get; set; }

        public void SendMessage(string text)
        {
            if (string.IsNullOrEmpty(From) || string.IsNullOrEmpty(To))
            {
                Console.WriteLine("Укажите отправителя и получателя!");
            }
            else
            {
                Console.WriteLine($"Telegram {From}: {To} - {text}");
            }
        }
    }
}
