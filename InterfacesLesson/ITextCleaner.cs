namespace InterfacesLesson
{
    interface ITextCleaner
    {
        string Text { get; set; }

        string ClearText(string text);
    }
}
