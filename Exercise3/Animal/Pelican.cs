internal class Pelican : Bird
{
    public int Beaksize { get; set; }
    public Pelican(string name, int weight, int age, int wingSpan, int beaksize) : base(name, weight, age, wingSpan)
    {
        Beaksize = beaksize;
    }
    public override string Stats()
    {
        return $"Name:{Name}, Weight: {Weight}, Age: {Age}, WingSpan: {base.WingSpan}, Beaksize: {Beaksize}";
    }
}