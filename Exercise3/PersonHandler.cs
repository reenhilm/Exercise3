public class PersonHandler
{
    public Person CreatePerson(int age, string fname, string lname, double height, double weight) => CreatePerson(age, fname, lname, ConvertDoubleToInt(height), ConvertDoubleToInt(weight));

    private Person CreatePerson(int age, string fname, string lname, int height, int weight) => new (fname, lname)
        {
            Age = age,
            Height = height,
            Weight = weight
        };
        
    public void SetAge(Person pers, int age)
    {
        pers.Age = age;
    }

    public void SetFName(Person pers, string fname)
    {
        pers.FName = fname;
    }

    public void SetLName(Person pers, string lname)
    {
        pers.LName = lname;
    }

    private int ConvertDoubleToInt(double dValue) => Convert.ToInt32(dValue);

    public void SetHeight(Person pers, double height)
    {
        pers.Height = ConvertDoubleToInt(height);
    }

    public void SetWeight(Person pers, double weight)
    {
        pers.Weight = ConvertDoubleToInt(weight);
    }
}