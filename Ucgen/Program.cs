internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Satir sayisi giriniz : ");
        int satir = int.Parse(Console.ReadLine());
        ucgen(satir);
    }

    public static void ucgen(int satir)
    {
        for(int i=satir;i>0;i--){
            for(int j = i-1; j>0;j--){
                Console.Write(" ");
            }
            for(int k = i; k<satir;k++){
                Console.Write("*");
                Console.Write(" ");
            }

            Console.WriteLine();
        }
    }
}