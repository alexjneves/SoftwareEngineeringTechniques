namespace FactoryPattern
{
    /**
    * A database implementation of the persistent storage interface.
    */
    internal sealed class DatabasePersistentStorage : IPersistentStorage
    {
        private readonly string _connectionString;

        public DatabasePersistentStorage(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}