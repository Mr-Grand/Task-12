namespace Task_12;

public class Animal
{
    public string Gender { get; private set; }

    public Animal()
    {
        Gender = RandomClass.Random.Next(2) == 0 ? "male" : "female";
    }
}