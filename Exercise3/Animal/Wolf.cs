internal class Wolf : Animal
{
    public enum Scaryness
    {
        laughable,
        uhuh,
        yikes
    }
    public Wolf(string name, int weight, int age, Scaryness scarynessLevel) : base(name, weight, age)
    {
        ScarynessLevel = scarynessLevel;
    }

    public Scaryness ScarynessLevel { get; set; }
    public override void DoSound()
    {
        Console.Write("howl");
    }
}