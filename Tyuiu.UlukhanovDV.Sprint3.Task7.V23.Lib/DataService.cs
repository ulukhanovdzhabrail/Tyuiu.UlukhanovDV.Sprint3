using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.UlukhanovDV.Sprint3.Task7.V23.Lib
{
    public class DataService : ISprint3Task7V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = stopValue - startValue + 1;
            valueArray = new double[len];
            double y;
            int c = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (2 * x - 2 == 0)
                {
                    y = 0;
                    valueArray[c] = y;
                    c++;
                }
                else
                {
                    y = Math.Round((4 - 2 * x) + ((2 + Math.Cos(x)) / (2 * x - 2)), 2);
                    valueArray[c] = y;
                    c++;
                }
            }
            return valueArray; 
        }
    }
}
