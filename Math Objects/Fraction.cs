using System;

namespace Math_Objects
{
    class Fraction:IMathObject
    {
        private int Numerator;
        private int Denominator;

        public Fraction(int n = 1, int d = 1)
        {
            if (d == 0) throw new FormatException("Error: Denominator = 0");
            Numerator = n;
            Denominator = d;
            Reduction();
        }
        private void Reduction()
        {
            int a = Numerator;
            int b = Denominator;
            while (b != 0) b = a % (a = b);
            Numerator = Numerator / a;
            Denominator = Denominator / a;
        }
        public IMathObject Summa(IMathObject ob)
        {
            Fraction obj1 = ob as Fraction;
            int N = obj1.Denominator*Numerator + obj1.Numerator*Denominator;
            int D = obj1.Denominator * Denominator;
            Fraction result = new Fraction(N, D);
            return result;
        }

        public IMathObject Substract(IMathObject ob)
        {
            Fraction obj1 = ob as Fraction;
            int N = obj1.Denominator * Numerator - obj1.Numerator * Denominator;
            int D = obj1.Denominator * Denominator;
            Fraction result = new Fraction(N, D);
            return result;
        }

        public IMathObject Multiply(IMathObject ob)
        {
            Fraction obj1 = ob as Fraction;
            int N = Numerator * obj1.Numerator;
            int D = obj1.Denominator * Denominator;
            Fraction result = new Fraction(N, D);
            return result;
        }

        private Fraction DoubleToFraction(double number)
        {
            int NumberOfRanks = number.ToString().Substring(number.ToString().IndexOf(".") + 1).Length;
            int D = 10 * NumberOfRanks;
            int N = (int)(number*D);
            Fraction result = new Fraction(N, D);
            return result;
        }

        public IMathObject Multiply(double number)
        {
            return Multiply(DoubleToFraction(number));
        }

        public override string ToString()
        {
            return Numerator + "/" + Denominator;
        }
    }
}
