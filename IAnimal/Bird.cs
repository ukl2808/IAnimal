public class Bird : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the bird sings Chirp!");
    }

    public override string GetInfo()
    {
        return $"Bird: ID = {UniqueID}, Name = {Name}, Age = {Age}";
    }
}
