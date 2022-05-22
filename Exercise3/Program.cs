try
{
    #region 3.1) Inkapsling
    //Ja, jag kommer åt dom publika variablerna efter jag instantierat en Person
    //1.
    //var person = new Person("Christian", "Rönnholm");
    //person.Age = 40;
    //person.LName = "Test";
    //person.FName = "Test";
    //person.Weight = 100;
    //person.Height = 189;

    //2.
    //var personHandler = new PersonHandler();
    //personHandler.SetAge(person, 41);

    //3.
    //var person2 = personHandler.CreatePerson(age: 41, "Christian", "Rönnholm", height: 189, weight: 100);

    //5.
    var personHandler = new PersonHandler();
    var person1 = personHandler.CreatePerson(age: 41, "Christian", "Rönnholm", height: 189, weight: 100);
    var person2 = personHandler.CreatePerson(age: 39, "Miranda", "Saarnio", height: 160, weight: 80);
    personHandler.SetWeight(person1, 110);
    personHandler.SetAge(person2, 40);
    personHandler.SetFName(person2, "Mirre");
    personHandler.SetLName(person2, "Rönnholm");
    #endregion

    #region 3.2) Polymorfism
    var userErrorList = new List<UserError>()
    {
        new NumericInputError(),
        new TextInputError(),
        new DateInputError(),
        new EmailInputError(),
        new ZipcodeInputError()
    };

    foreach(UserError e in userErrorList)
        Console.WriteLine(e.UEMessage());
    #endregion

    #region 3.3 Arv
    List<Animal> animalList = new() {
     new Horse("Hästisen", weight: 100, age: 10),
     new Dog("Hundis", weight: 100, age: 10, loudness: 9223372036854775806),
     new Hedgehog("Hedgehoggen", weight: 100, age: 10, 1),
     new Worm("Wormen", weight: 100, age: 10, false),
     new Wolf("Wolf", weight: 100, age: 10, Wolf.Scaryness.yikes)
    };
    //13. i klassen Bird
    //14. i klassen Animal
    
    #endregion

}
catch (ArgumentException ex)
{
    Debug.WriteLine(ex.Message);
}
