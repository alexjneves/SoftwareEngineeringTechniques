namespace InversionOfControl
{
    /**
    * This is an implementation of our storage that would be used in production, writing
    * data to a persistent database.
    */
    internal sealed class DatabasePersistentStorage : IPersistentStorage
    {
        public void Write(byte[] data)
        {
            throw new System.NotImplementedException();
        }
    }
}