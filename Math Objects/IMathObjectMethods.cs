namespace Math_Objects
{
    class IMathObjectMethods
    {
        public static IMathObject GetSummaInList(params IMathObject[] list)
        {
            IMathObject result = list[0];
            for (int i = 1; i < list.Length; i++)
            {
                result = result.Summa(list[i]);
            }
            return result;
        }
    }
}
