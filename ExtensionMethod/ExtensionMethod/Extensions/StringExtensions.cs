namespace ExtensionMethod.Extensions
{
    public static class StringExtensions
    {
        public static string Cut(this string thisObj, int numberOfCaracters)
        {
            if (thisObj.Length <= numberOfCaracters)
            {
                return thisObj;
            }
            else
            {
                return thisObj.Substring(0, numberOfCaracters);
            }
        }
    }
}
