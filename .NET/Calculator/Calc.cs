namespace Calculator
{

    public class Calc
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Substract(int a, int b)
        {
            return a - b;
        }
        
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        
        public static int Devide(int a, int b)
        {
            return a / b;
        }

        public static int Square(int a)
        {
            return a * a;
        }

        public static double Root(double d, int a, int b)
        {
            return d = 0.5*(b + a / b);
        }

    }
}
