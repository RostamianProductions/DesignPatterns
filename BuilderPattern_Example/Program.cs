using BuilderPattern_Example.Builders.Person;
using BuilderPattern_Example.Dtos.Person;
using BuilderPattern_Example.Enums;

PersonBuilder personBuilder = new();
PersonDto personDto;

personDto = personBuilder
    .SetLastName("Nime")
    .SetFirstName("Rostamian")
    .Build();

Console.WriteLine(personDto.ToString());

personBuilder.SetAge(23);
personDto = personBuilder.Build();

Console.WriteLine(personDto.ToString());

personBuilder = new();
personDto = personBuilder
    .SetLastName("N")
    .SetFirstName("R")
    .SetAge(23)
    .SetAccessCodes(new List<AccessCode>() { AccessCode.Add, AccessCode.Edit })
    .Build();

Console.WriteLine(personDto.ToString());

Console.ReadKey();