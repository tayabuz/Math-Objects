namespace Math_Objects
{
    interface IMathObject
    {
        IMathObject Summa(IMathObject ob);
        IMathObject Substract(IMathObject ob);
        IMathObject Multiply(IMathObject ob);
        IMathObject Multiply(double number);
        string ToString();
    }
}
