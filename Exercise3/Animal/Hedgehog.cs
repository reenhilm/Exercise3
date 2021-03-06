internal class Hedgehog : Animal
{
    public Hedgehog(string name, int weight, int age, uint nrOfSpikes) : base(name, weight, age)
    {
        NrOfSpikes = nrOfSpikes;
    }

    public uint NrOfSpikes { get; set; }
    public override void DoSound()
    {
        Console.Write("squeak");
    }
    public override string Stats()
    {
        return $"Name:{Name}, Weight: {Weight}, Age: {Age}, NrOfSpikes: {NrOfSpikes}";
    }
}