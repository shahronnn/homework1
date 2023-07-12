int n=Convert.ToInt32(Console.ReadLine());
int cnt=0;

for (int i = 0; i < n; i++)
{
    cnt+=1/i;
}
Console.WriteLine($"{cnt}");