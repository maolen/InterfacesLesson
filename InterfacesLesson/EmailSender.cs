using System;

namespace InterfacesLesson
{
    public class EmailSender : Object, ISender, ITextCleaner
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Text { get; set; }

        string ISender.Text { get; set; }
        string ITextCleaner.Text { get; set; }

        public string ClearText(string text)
        {
            // STUB
            return string.Empty;
        }

        public void SendMessage(string text)
        {
            if(string.IsNullOrEmpty(From) || string.IsNullOrEmpty(To))
            {
                Console.WriteLine("Укажите отправителя и получателя!");
            }
            else
            {
                Console.WriteLine($"{From}: {To} - {text}");
            }
        }
    }
}
