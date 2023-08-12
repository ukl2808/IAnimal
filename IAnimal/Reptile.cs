public class Reptile : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the reptile hisses!");
    }

    public override string GetInfo()
    {
        return $"Reptile: ID = {UniqueID}, Name = {Name}, Age = {Age}";
    }
}
