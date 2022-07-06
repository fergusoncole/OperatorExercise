
namespace OperatorExercise
    
{
    internal class Simple_Calculator
    {
        public static int Sum(int x, int y)
        { return x + y; }
       public static int Subtract(int x, int y)
        { return x - y; }

        public static int Multiply(int x, int y)
        
         { return x * y; }
        
        public static string Divide(int x, int y)
            
        {
            int quotient = x / y;
            int remainder = x % y;
            return $"{x}/{y} is {quotient} remainder {remainder}";

        
        }

        public static int Remainder(int x, int y)
        { return x % y; }

        public static double Area(double x)
        {
            return Math.PI * Math.Pow(x, 2);
        }
    }
 

}

