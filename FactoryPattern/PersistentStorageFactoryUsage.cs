using FluentAssertions;
using NUnit.Framework;

namespace FactoryPattern
{
    [TestFixture]
    internal sealed class PersistentStorageFactoryUsage
    {
        /**
        * This example creates a known valid connection string which is used to construct the factory.
        * The factory then decides which storage implementation is created. The consumer does not know
        * nor care which implementation is used, just that they have a valid instance to use.
        */
        [Test]
        public void Create_WithValidConnectionString_ReturnsValidPersistentStorage()
        {
            const string validConnectionString = "file://C:\\Desktop\\";

            var storageFactory = new PersistentStorageFactory(validConnectionString);

            var storage = storageFactory.Create();

            storage.Should().NotBeNull();
        }
    }
}