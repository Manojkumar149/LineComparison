namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problem Statement");
            CalculateLength calculateLength = new CalculateLength(1,2,3,4);
            calculateLength.Calculate();
        }
    }
}