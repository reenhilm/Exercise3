internal class Bird : Animal
{
    public Bird(string name, int weight, int age, int wingSpan) : base(name, weight, age)
    {
        WingSpan = wingSpan;
    }

    public int WingSpan { get; set; }
    public override void DoSound()
    {
        Console.Write("tweet/twitter/cheep/chirp");
    }
}