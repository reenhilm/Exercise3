//Ja, jag kommer åt dom publika variablerna efter jag instantierat en Person
//1.
try
{ 
    var person = new Person("Christian", "Rönnholm");
    person.Age = 40;
    person.LName = "Test";
    person.FName = "Test";
    person.Weight = 100;
    person.Height = 189;
}
catch(ArgumentException ex)
{
    Debug.WriteLine(ex.Message);
}
