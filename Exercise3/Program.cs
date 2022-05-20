//Ja, jag kommer åt dom publika variablerna efter jag instantierat en Person

try
{
    //1.
    var person = new Person("Christian", "Rönnholm");
    person.Age = 40;
    person.LName = "Test";
    person.FName = "Test";
    person.Weight = 100;
    person.Height = 189;

    //2.
    var personHandler = new PersonHandler();
    personHandler.SetAge(person, 41);
}
catch(ArgumentException ex)
{
    Debug.WriteLine(ex.Message);
}
