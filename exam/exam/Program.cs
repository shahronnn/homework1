int min=999999999;
int FindMinimum (int a, int b, int c, int d)
{
    if(a<b && a<c && a<d)
    {
         return a;
    }
    if(b<a && b<c && a<d)
    {
         return b;
    }
    if(c<a && c<b && c<d)
    {
        return c;
    }
    else return d;
};

System.Console.WriteLine(FindMinimum(2, 1, 3, 4));