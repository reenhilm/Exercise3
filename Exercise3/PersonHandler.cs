public class PersonHandler
{
    public Person CreatePerson(int age, string fname, string lname, double height, double weight) => CreatePerson(age, fname, lname, Convert.ToInt32(height), Convert.ToInt32(weight));

    private Person CreatePerson(int age, string fname, string lname, int height, int weight)
    {
        var person = new Person(fname, lname)
        {
            Age = age,
            Height = height,
            Weight = weight
        };
        return person;
    }
    public void SetAge(Person pers, int age)
    {
        pers.Age = age;
    }
}