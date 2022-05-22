internal class Swan : Bird
{
    public int Necklength { get; set; }
    public Swan (string name, int weight, int age, int wingSpan, int necklength) : base(name, weight, age, wingSpan)
    {
        Necklength = necklength;
    }
}