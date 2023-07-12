Console.Write("salary: ");
int salary=Convert.ToInt32(Console.ReadLine());
Console.Write("year: ");
int year=Convert.ToInt32(Console.ReadLine());

if (year>=5)
{
    Console.WriteLine($"bonus: {salary*5/100}");
}
else
{
    Console.WriteLine($"bonus: 0$");
}