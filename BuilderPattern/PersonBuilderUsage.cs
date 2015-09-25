using FluentAssertions;
using NUnit.Framework;

namespace BuilderPattern
{
    /**
    * Here is an example usage of our PersonBuilder. We can construct a new Person object in a fluent and
    * easily readable way. We set our fields by chaining the setter function calls and build the object when
    * we are done.
    */
    [TestFixture]
    internal sealed class PersonBuilderUsage
    {
        [Test]
        public void Build_WhenAllFieldsAreSet_ReturnsExpectedPerson()
        {
            const string expectedName = "Alex";
            const string expectedOccupation = "Student";
            const int expectedAge = 21;

            var personBuilder = new PersonBuilder();

            var person = personBuilder.WithName(expectedName)
                .WithOccupation(expectedOccupation)
                .WithAge(expectedAge)
                .Build();

            person.Name.Should().Be(expectedName);
            person.Occupation.Should().Be(expectedOccupation);
            person.Age.Should().Be(expectedAge);
        }
    }
}