using BuilderPattern_Example.Enums;

namespace BuilderPattern_Example.Dtos.Person
{
    public class PersonDto
    {
        private string LastName { get; set; }
        private string FirstName { get; set; }
        private int Age { get; set; }
        public List<AccessCode> AccessCodes { get; set; }

        public PersonDto(string lastName,
                         string firstName,
                         int age,
                         List<AccessCode> accessCodes)
        {
            LastName = lastName;
            FirstName = firstName;
            Age = age;
            AccessCodes = accessCodes;
        }

        public override string ToString() => $"LastName: {LastName}\nFirstName: {FirstName}\nAge: {Age}\nAccessCodes: {string.Join(", ", AccessCodes)}";
    }
}
