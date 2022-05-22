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
    //13. i klassen Bird
    //14. i klassen Animal   
    #endregion

    #region 3.4 Mer polymorfism
    List<Animal> animalList = new() {
     new Bird("Birden", weight: 100, age: 10, wingSpan: 100),
     new Dog("Hundis", weight: 100, age: 10, loudness: 9223372036854775806),
     new Flamingo("Flamingon", weight: 100, age: 10, wingSpan: 110, pinkness: 10),
     new Hedgehog("Hedgehoggen", weight: 100, age: 10, nrOfSpikes: 1),
     new Horse("Hästisen", weight: 100, age: 10),
     new Pelican("Pelikanen", weight: 100, age: 10, wingSpan: 110, beaksize: 10),
     new Swan("Svanen", weight: 100, age: 10, wingSpan: 110, necklength: 20),     
     new Wolf("Wolf", weight: 100, age: 10, Wolf.Scaryness.yikes),
     new Wolfman("Wolfmannen", weight: 100, age: 10, Wolf.Scaryness.uhuh),
     new Worm("Wormen", weight: 100, age: 10, false)
    };
    Console.WriteLine("Alla djur som finns i listan med hjälp av en foreach loop");
    foreach (Animal a in animalList)
    {
        Console.Write($"{a.ToString()} ");
        a.DoSound();
        if (a is Wolfman w)
        {
            Console.Write(" ");
            w.Talk();
        }
        Console.WriteLine();
    }

    //8-10 
    List<Dog> dogList = new()
    {
        //new Horse("hejsan", 100, 10, true) <- Går ej för att listan kan bara innehålla hundar eller objekt som ärver utav hundar. Listan måste vara av typen Animal eller object 
    };

    //11-13 Samtliga animal stats
    Console.WriteLine("Det som händer att att den mest specifika överlagrade metoden för Stats körs");
    foreach (Animal a in animalList)
    {
        Console.WriteLine($"{a.Stats()} ");
    }
    //14
    Console.WriteLine("Enbart hundar i listan animals");
    foreach (Animal a in animalList)
    {
        if (a is Dog)
            Console.WriteLine($"{a.Stats()} ");
    }
    //15-18
    foreach (Animal a in animalList)
    {
        //a.FoundBoneCheer <- FoundBoneCheer finns ej i med i det interface (implicit interface) som Animal har.
        if (a is Dog d)
            Console.WriteLine($"{d.FoundBoneCheer} ");
    }

    #endregion

}
catch (ArgumentException ex)
{
    Debug.WriteLine(ex.Message);
}
