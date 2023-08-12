class AnimalShelter
{
    private List<Animal> animals = new List<Animal>();

    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
    }

    public void RemoveAnimal(Animal animal)
    {
        animals.Remove(animal);
    }

    public void PrintAnimals()
    {
        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal.GetInfo());
            animal.MakeSound(); // Выводим звук, который издает животное
        }
    }

    public Animal GetAnimalByID(string id)
    {
        return animals.FirstOrDefault(animal => animal.UniqueID == id);
    }
}