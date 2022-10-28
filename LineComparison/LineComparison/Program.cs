namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problem Statement");
            CalculateLength calculateLength1 = new CalculateLength(1,2,3,4);
            double length1 = calculateLength1.Calculate();
            CalculateLength calculateLength2 = new CalculateLength(1, 2, 3, 4);
            double length2 = calculateLength2.Calculate();
            if(length1 == length2)
                Console.WriteLine("length1 is equals to length2");
            else
                Console.WriteLine("length1 is not equals to length2");

        }
    }
}