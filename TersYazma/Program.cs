internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Cumle giriniz : ");
        string str = Console.ReadLine();
        string[] splt = str.Split(" ");

        for(int i =0;i<splt.Length;i++){
            rep(splt[i]);
            Console.WriteLine();
        }

    }
    public static void rep(string str)
    {
        char[] c = str.ToCharArray();
        
        for(int i = 1; i<c.Length;i++){
            Console.Write(c[i]);
        }
        Console.Write(c[0]);
    }
}