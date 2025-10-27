using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.UlukhanovDV.Sprint3.Task3.V18.Lib
{
    public class DataService : ISprint3Task3V18
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            string str = "4n5nvf 56 bgy";
            foreach (char c in value)
            {
                if (Char.IsDigit(c))
                {
                    str = str.Replace(c, item);
                }

            }
            return str;
        }
    }
}
