namespace BuilderPattern
{
    /** 
    * This is our data model we have created a builder class for 
    */
    internal sealed class Person
    {
        public string Name { get; }
        public string Occupation { get; }
        public int Age { get; }

        public Person(string name, string occupation, int age)
        {
            Name = name;
            Occupation = occupation;
            Age = age;
        }
    }
}
