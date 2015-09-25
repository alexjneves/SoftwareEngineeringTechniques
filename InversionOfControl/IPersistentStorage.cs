namespace InversionOfControl
{
    /**
    * This is our storage abstraction. We have a write function which will take a collection
    * of bytes and write them to a persistent storage.
    */
    internal interface IPersistentStorage
    {
        void Write(byte[] data);
    }
}