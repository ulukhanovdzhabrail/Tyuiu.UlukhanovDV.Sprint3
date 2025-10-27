using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.UlukhanovDV.Sprint3.Task6.V2.Lib
{
    public class DataService : ISprint3Task6V2
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int c = 0;
            int x;
            for (x = startValue; x <= stopValue; x++)
            {
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0) 
                    {
                        c += 1;
                    }

                }
            }
            return c;
        }
    }
}
