public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the cat says Meow!");
    }

    public override string GetInfo()
    {
        return $"Cat: ID = {UniqueID}, Name = {Name}, Age = {Age}";
    }
}
