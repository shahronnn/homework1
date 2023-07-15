public class Person
{
    public string Name;
    public string Surname;
    public int Age;

    public void GetInfo()
    {
        System.Console.WriteLine($"Hello! My name is {Name} {Surname}");
    }
}