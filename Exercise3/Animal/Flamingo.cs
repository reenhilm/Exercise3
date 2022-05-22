internal class Flamingo : Bird
{
    public int Pinkness { get; set; }
    public Flamingo (string name, int weight, int age, int wingSpan, int pinkness) : base(name, weight, age, wingSpan)
    {
        Pinkness = pinkness;
    }
}