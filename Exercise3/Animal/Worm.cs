internal class Worm : Animal
{
    public Worm(string name, int weight, int age, bool isPoisonous) : base(name, weight, age)
    {
        IsPoisonous = isPoisonous;
    }

    public bool IsPoisonous { get; set; }
    public override void DoSound()
    {
        Console.Write("do they even make sound?");
    }
}