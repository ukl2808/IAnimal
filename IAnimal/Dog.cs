public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the dog says Woof!");
    }

    public override string GetInfo()
    {
        return $"Dog: ID = {UniqueID}, Name = {Name}, Age = {Age}";
    }
}
