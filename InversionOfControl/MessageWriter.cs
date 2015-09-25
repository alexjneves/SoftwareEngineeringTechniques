using System.Text;

namespace InversionOfControl
{
    /**
    * This is the writer class that is responsible for accepting messages, serializing them and writing
    * them to a persistent storage. 
    */
    internal sealed class MessageWriter
    {
        private readonly IPersistentStorage _storage;

        /** 
        * This is an example of a bad constructor. We have a hard dependency on a concrete implementation,
        * resulting in tight coupling and no flexibility to swap out implementations. We may decide
        * we don't want to write to a database in future, requiring this class to be altered. It also
        * makes this class difficult to test, requiring a functional database to do so.
        */
        private MessageWriter()
        {
            _storage = new DatabasePersistentStorage();
        }

        /**
        * This is the Inversion of Control method. We inject an abstraction of our storage, telling
        * the writer where we want the serialized messages to be written to. This allows us to swap
        * our implementations depending on configurations, and enables Dependancy Injection to take place.
        * We can now easily test our MessageWriter with a mock implementation of our storage abstraction.
        */
        public MessageWriter(IPersistentStorage storage)
        {
            _storage = storage;
        }

        public void Write(Message message)
        {
            var serializedMessage = SerializeMessage(message);

            _storage.Write(serializedMessage);
        }

        private static byte[] SerializeMessage(Message message)
        {
            return Encoding.UTF8.GetBytes(message.Contents);
        }
    }
}
