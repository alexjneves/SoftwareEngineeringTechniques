namespace FactoryPattern
{
    /**
    * The factory will decide which persistent storage implementation to be used based on the supplied 
    * connection string. This connection string would be read from configuration. This allows us to run 
    * our application against a different persistent storage without having to change any code. The implementations 
    * are hidden to external consumers of the library, instead they use our storage abstraction. In this example we 
    * inspect the connection string to see if it contains any known substrings which indicate the type of storage 
    * to be used. Each storage implementation would then know how to interpret this string, e.g. the file storage 
    * would expect a file path to indicate where to write data.
    */
    public sealed class PersistentStorageFactory
    {
        private readonly string _connectionString;

        public PersistentStorageFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IPersistentStorage Create()
        {
            if (IsDatabaseConnectionString())
            {
                return new DatabasePersistentStorage(_connectionString);
            }

            if (IsFileConnectionString())
            {
                return new FilePersistentStorage(_connectionString);
            }

            throw new InvalidConnectionStringException();
        }

        private bool IsDatabaseConnectionString()
        {
            return _connectionString.Contains("db");
        }

        private bool IsFileConnectionString()
        {
            return _connectionString.Contains("file");
        }
    }
}
