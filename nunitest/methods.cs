
namespace nunitest
{
    public class Methods
    {
        public double GetCircleArea(double radius)
        {
            const float pi = 3.14F;
            double area = pi * radius * radius;
            return area;
        }

        public int GetFactorial(int n)
        {
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f = f * i;
            }

            return f;
        }

        public int CalculateSum(int[] a)
        {
            int sum = 0;
            foreach (var item in a)
            {
                sum += item;
            }
            return sum;
        }
    }
}
