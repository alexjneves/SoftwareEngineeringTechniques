using NSubstitute;
using NUnit.Framework;

namespace InversionOfControl
{
    [TestFixture]
    internal sealed class InversionOfControlUsage
    {
        /**
        * 
        * Here is an example usage of our MessageWriter class. I am using a mocking framework to construct
        * a mock implementation of our storage abstraction. This allows us to modify the behavior of the storage
        * as needed for this particular test. We inject our storage instance into our MessageWriter. This test
        * is ensuring our message is persisted by checking that the storage.Write function gets called. If we
        * were dependent on the concrete database storage then this test would require us to query a live database.
        * This means either creating a database for testing purposes, or worse yet: using the production database,
        * requiring a clean up after the tests and putting unnecessary strain on the database. 
        * This would make the tests slow, require extra set up and tear down, and be dependent on the database being 
        * available.
        */ 
        [Test]
        public void Write_WritesMessageToStorage()
        {
            var message = new Message("This is my message");
            var mockStorage = Substitute.For<IPersistentStorage>();

            var messageWriter = new MessageWriter(mockStorage);

            messageWriter.Write(message);

            mockStorage.Received(1).Write(Arg.Any<byte[]>());
        }
    }
}