namespace InversionOfControl
{
    /**
    * This is the Message data model which will be written to storage.
    */
    internal sealed class Message
    {
        public string Contents { get; }

        public Message(string contents)
        {
            Contents = contents;
        }
    }
}