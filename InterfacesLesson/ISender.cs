namespace InterfacesLesson
{
    public interface ISender
    {
        string From { get; set; }
        string To { get; set; }
        new string Text { get; set; }

        void SendMessage(string text);
    }
}
