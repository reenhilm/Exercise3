internal abstract class Animal
{
    public string Name;
    public int Weight;
    public int Age;

    public abstract void DoSound();

    public Animal(string name, int weight, int age)
    {
        this.Name = name;
        this.Weight = weight;
        this.Age = age;
    }
}