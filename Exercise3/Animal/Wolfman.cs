internal class Wolfman : Wolf, IPerson
{
    public Wolfman(string name, int weight, int age, Scaryness scarynessLevel) : base(name, weight, age, scarynessLevel)
    {
    }

    public void Talk()
    {
        Console.Write("gonatt");
    }
}