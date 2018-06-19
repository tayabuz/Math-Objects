using System;

namespace Math_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IMathObject f = new Fraction(-8, 5);
                Console.WriteLine(f);
                IMathObject g = new Fraction(-2,5);
                Console.WriteLine(g);
                IMathObject k = f.Summa(g);
                IMathObject z = g.Multiply(2.0);
                Console.WriteLine(z);
                Console.WriteLine(k);
                IMathObject f1 = new Fraction(15, -5);
                Console.WriteLine(f1);
                IMathObject p = IMathObjectMethods.GetSummaInList(f, g, k, z, f1);
                Console.WriteLine(p);
                IMathObject[] list = {f, g, k, z, f1};
                IMathObject p1 = IMathObjectMethods.GetSummaInList(list);
                Console.WriteLine(p1);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
