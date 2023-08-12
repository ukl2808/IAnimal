AnimalShelter shelter = new AnimalShelter();

Cat cat = new Cat { Name = "Whiskers", Age = 3 };
Dog dog = new Dog { Name = "Buddy", Age = 5 };
Bird bird = new Bird { Name = "Tweety", Age = 2 };

shelter.AddAnimal(cat);
shelter.AddAnimal(dog);
shelter.AddAnimal(bird);

while (true)
{
    Console.WriteLine("Меню:");
    Console.WriteLine("1. Добавить животное");
    Console.WriteLine("2. Удалить животное");
    Console.WriteLine("3. Вывести информацию о животных");
    Console.WriteLine("4. Выйти");
    Console.Write("Выберите действие: ");

    string choiceInput = Console.ReadLine();
    if (!int.TryParse(choiceInput, out int choice))
    {
        Console.WriteLine("Ошибка: Введите число от 1 до 4.");
        continue;
    }

    switch (choice)
    {
        case 1:
            Console.Write("Введите тип животного (Cat, Dog, Bird, Reptile): ");
            string animalType = Console.ReadLine();
            Animal newAnimal;

            if (animalType == "Cat")
                newAnimal = new Cat();
            else if (animalType == "Dog")
                newAnimal = new Dog();
            else if (animalType == "Bird")
                newAnimal = new Bird();
            else if (animalType == "Reptile")
                newAnimal = new Reptile();
            else
            {
                Console.WriteLine("Неверный тип животного.");
                continue;
            }

            Console.Write("Введите имя животного: ");
            newAnimal.Name = Console.ReadLine();

            Console.Write("Введите возраст животного: ");
            newAnimal.Age = int.Parse(Console.ReadLine());

            shelter.AddAnimal(newAnimal);
            break;

        case 2:
            Console.Write("Введите уникальный ID животного для удаления: ");
            string idToRemove = Console.ReadLine();
            Animal animalToRemove = shelter.GetAnimalByID(idToRemove);

            if (animalToRemove != null)
                shelter.RemoveAnimal(animalToRemove);
            else
                Console.WriteLine("Животное с таким ID не найдено.");
            break;

        case 3:
            Console.WriteLine("Информация о животных:");
            shelter.PrintAnimals();
            break;

        case 4:
            Console.WriteLine("Программа завершена.");
            return;

        default:
            Console.WriteLine("Неверный выбор.");
            break;
    }
}