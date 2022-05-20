internal class Dog : Animal
{
    public Dog(string name, int weight, int age, long loudness) : base(name, weight, age)
    {
        Loudness = loudness;
    }

    public long Loudness { get; set; }
    public override void DoSound()
    {
        Console.Write("bark");
    }
}