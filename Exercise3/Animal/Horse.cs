﻿internal class Horse : Animal
{
    public Horse(string name, int weight, int age, bool canGalopp = true) : base(name, weight, age)
    {
        CanGalopp = canGalopp;
    }

    public bool CanGalopp { get; set; }
    public override void DoSound()
    {
        Console.Write("neigh");
    }
}