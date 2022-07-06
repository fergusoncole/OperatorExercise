using OperatorExercise;
Console.WriteLine("Please input two numbers");
int input1 = Convert.ToInt32(Console.ReadLine());
int input2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The sum is equal to: "+ Simple_Calculator.Sum(input1,input2));
Console.WriteLine("The subtraction is equal to: "+ Simple_Calculator.Subtract(input1, input2));
Console.WriteLine("The multiplation is equal to: "+ Simple_Calculator.Multiply(input1, input2));
Console.WriteLine(Simple_Calculator.Divide(input1, input2)); //returning string instead
Console.WriteLine("The modulus is qual to: " + Simple_Calculator.Remainder(input1, input2));


Console.WriteLine("What is the radius of your circle?");
double radius = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("The area of your circle is: " + Simple_Calculator.Area(radius));

