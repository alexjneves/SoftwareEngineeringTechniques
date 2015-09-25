namespace BuilderPattern
{
    /**
    * This is the builder for our Person data model. The class contains the same fields as our model.
    * We create public setters following the naming convention of "With[FieldName]".
    * The key here is that the setters all return a reference to the builder, meaning we can chain function calls.
    * The build function will use the fields that have been set to construct a new Person object and return
    * it to us.
    */
    internal sealed class PersonBuilder
    {
        public string Name { get; private set; }
        public string Occupation { get; private set; }
        public int Age { get; private set; }

        public PersonBuilder WithName(string name)
        {
            Name = name;
            return this;
        }

        public PersonBuilder WithOccupation(string occupation)
        {
            Occupation = occupation;
            return this;
        }

        public PersonBuilder WithAge(int age)
        {
            Age = age;
            return this;
        }

        public Person Build()
        {
            return new Person(Name, Occupation, Age);
        }
    }
}