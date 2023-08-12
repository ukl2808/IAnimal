public abstract class Animal : IAnimal
{
    private static int nextID = 1;

    public string UniqueID { get; private set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal()
    {
        UniqueID = $"ID_{nextID++}";
    }

    public abstract void MakeSound();
    public abstract string GetInfo();
}