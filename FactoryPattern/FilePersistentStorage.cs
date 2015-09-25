namespace FactoryPattern
{
    /**
    * A file implementation of the persistent storage interface.
    */
    internal sealed class FilePersistentStorage : IPersistentStorage
    {
        private readonly string _connectionString;

        public FilePersistentStorage(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}