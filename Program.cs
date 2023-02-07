using System;
class Program
{
    static void Main (string[] args)
    {
        double x = 0;
        x = double.Parse(Console.ReadLine());
        Console.WriteLine(F(x));
    }
    static double F (double x)
    {
        if ( x > 4 )
        {
            return 1+F(x-((4*Math.Abs(x))/x));
        }
        else
        {
            return 2;
        }
    }
}