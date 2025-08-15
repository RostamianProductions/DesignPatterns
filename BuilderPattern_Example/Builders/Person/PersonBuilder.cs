using BuilderPattern_Example.Dtos.Person;
using BuilderPattern_Example.Enums;

namespace BuilderPattern_Example.Builders.Person
{
    public class PersonBuilder
    {
        private string lastName = string.Empty;
        private string firstName = string.Empty;
        private int age;
        private List<AccessCode> accessCodes = new();

        public PersonBuilder SetLastName(string lastName)
        {
            this.lastName = lastName;
            return this;
        }

        public PersonBuilder SetFirstName(string firstName)
        {
            this.firstName = firstName;
            return this;
        }

        public PersonBuilder SetAge(int age)
        {
            this.age = age;
            return this;
        }

        public PersonBuilder SetAccessCodes(List<AccessCode> accessCodes)
        {
            this.accessCodes = accessCodes;
            return this;
        }

        public PersonDto Build() => new PersonDto(lastName, firstName, age, accessCodes);
    }
}
