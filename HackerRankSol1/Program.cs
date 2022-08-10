internal class Program
{
    private static void Main(string[] args)
    {
        Calculator myCalculator=new Calculator();

        Console.Write("Enter first number :");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter second number :");
        int p = int.Parse(Console.ReadLine());

        Console.WriteLine(myCalculator.power(n,p));
    }
}
class Calculator{
    public int power(int n, int p){
        if(n<0||p<0) throw new System.Exception("n and p should be non-negative");
        return (int) Math.Pow(n,p);
    }
}