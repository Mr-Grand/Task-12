namespace Task_12;

public class Enclosure
{
    public string AnimalName { get;}
    public int AnimalCount { get;}
    public string AnimalSound { get;}

    private List<Animal> Animals { get; set; } = new();

    public Dictionary<string, int> AnimalGender { get; private set; } = new()
    {
        ["male"] = 0,
        ["female"] = 0
    };
    public Enclosure(string animalName, int animalCount, string animalSound)
    {
        AnimalName = animalName;
        AnimalCount = animalCount;
        AnimalSound = animalSound;
        
        for (int i = 0; i < animalCount; i++)
        {
            Animals.Add(new Animal());
        }
        
        foreach (var animal in Animals)
        {
            AnimalGender[animal.Gender] += 1;
        }
    }

    public void ShowEnclosureInfo()
    {
        
        Console.WriteLine($"Животные - {AnimalName}, кол-во - {AnimalCount}," +
                          $"издаваемый звук - {AnimalSound}," +
                          $"самцов - {AnimalGender["male"]}, самок  - {AnimalGender["female"]}");
    }
}