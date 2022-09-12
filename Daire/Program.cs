internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Radius'u giriniz : ");
        int radius = int.Parse(Console.ReadLine());
    }
    public static void ucgen(int satir)
    {
        for(int i=0;i<satir;i++){
            for(int j=i+1; j<satir;j++){
                Console.Write(" ");
            }
            for(int k=0; k<(2*i)-1;k++){
                Console.Write("*");
            }

            Console.WriteLine();
        }
        for(int x =satir-1;x>0;x--){
            for(int y=x;y<satir;y++){
                Console.Write(" ");
            }
            for(int z =0;z<=(2*x)-4;z++){
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}