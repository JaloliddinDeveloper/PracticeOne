namespace SoftExam.Classes
{
    internal static class Mathe
    {
        public const double PI = 3.14;
        public const double E = 2.71;

        public static double Abs(double x)
        {
            if (x > 0)
                return x;
            else if (x < 0)
                return -x;
            return 0;
        }

        public static float Abs(float x)
        {
            if (x > 0)
                return x;
            else if (x < 0)
                return -x;
            return 0;
        }

        public static int Abs(int x)
        {
            if (x > 0)
                return x;
            else if (x < 0)
                return -x;
            return 0;
        }

        public static double Pow(double x, double y)
        {
            double p = 1;
            if (y > 0)
            {
                for (double i = 0; i < y; i++)
                {
                    p *= x;
                }
            }
            else
            {
                for (double i = 0; i < (-y); i++)
                {
                    p = p / x;
                }
            }
            return p;
        }

        public static double Sqrt(double x)
        {
            double k = Math.Pow(x, (0.5));
            return k;
        }

        public static int Max(int a, int b)
        {
            int max = a;
            if (b > a)
                return max = b;

            return max;
        }

        public static int Min(int a, int b)
        {
            int min = a;
            if (a > b)
                return min = b;

            return min;
        }
    }
}
