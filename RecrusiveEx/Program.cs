internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(pow(3,4));
    }

    public static int faktoriyel(int n) {
        if(n<1) return 1;
        else return n*faktoriyel(n-1);
    }

    public static int pow(int a, int b){
        if(b<2) return a;
        
        return a * pow(a,b-1);
    }
}