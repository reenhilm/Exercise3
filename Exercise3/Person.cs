using Excercise3.BL;

public class Person
{
    int age;
    string fName = null!;
    string lName = null!;
    int height;
    int weight;

    public Person(string fName, string lName)
    {
        FName = fName;
        LName = lName;
    }
    public int Age 
    {
        get
        {
            return age;
        }
        set
        {
            if(ValidateAge(value))
                age = value;
        }   
    }

    public bool ValidateAge(int age)
    {
        if(age <= 0)
            throw new ArgumentException(Language.ValidateAgeArgumentException);
        return true;
    }

    public string FName
    {
        get
        {
            return fName;
        }
        set
        {
            if (ValidateFName(value))
                fName = value;
        }
    }

    public bool ValidateFName(string fName)
    {
        if (fName.Length < 2 || fName.Length > 10)
            throw new ArgumentException(Language.ValidateFNameArgumentException);
        return true;
    }

    public string LName
    {
        get
        {
            return lName;
        }
        set
        {
            if (ValidateLName(value))
                lName = value;
        }
    }

    public bool ValidateLName(string lName)
    {
        if (lName.Length < 3 || lName.Length > 15)
            throw new ArgumentException(Language.ValidateLNameArgumentException);
        return true;
    }

    public int Height
    {
        get
        {
            return height;
        }
        set
        {
            height = value;
        }
    }

    public int Weight
    {
        get
        {
            return weight;
        }
        set
        {
            weight = value;
        }
    }
}