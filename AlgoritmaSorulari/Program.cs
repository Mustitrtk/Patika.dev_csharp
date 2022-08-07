
internal class Program
{
    private static void Main(string[] args)
    {
        Algoritma algoritma = new Algoritma();

        algoritma.first();
        algoritma.second();
        algoritma.third();
        algoritma.forth();
    }
}

class Algoritma{
    
    public void first(){
        bool control = false;
        int a=0;
        while(control==false){
            Console.Write("Pozitif sayi giriniz : ");
            a=int.Parse(Console.ReadLine());
            if(a>0) control = true;
            else Console.WriteLine("Hata!!! Değerler negatif olamaz.");
        }

        int[] pozitive = new int[a];
        Console.WriteLine();

        for(int i =0; i<a;i++){
            Console.Write($"{i+1}. deger : ");
            pozitive[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine();

        foreach(int item in pozitive){
            if(item>=0) Console.Write(item+" ");
        }

        Console.WriteLine();
    }

    public void second(){
        bool control = false;
        int a=0,b=0;
        while(control==false){
            Console.Write("Ilk sayiyi giriniz : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Ikince sayiyiy giriniz : ");
            b = int.Parse(Console.ReadLine());

            if(a>0&&b>0) control = true;
            else Console.WriteLine("Hata!!! Değerler negatif olamaz."); 
        }

        int[] kat = new int[a];
        Console.WriteLine();

        for(int i =0;i<a;i++){
            Console.Write($"{i+1}. deger : ");
            kat[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();

        foreach(int item in kat){
            if(item%b ==0) Console.Write(item+" ");
        }

        Console.WriteLine();
    }

    public void third(){
        bool control = false;
        int a=0;
        while(control==false){
            Console.Write("Pozitif sayi giriniz : ");
            a=int.Parse(Console.ReadLine());
            if(a>0) control = true;
            else Console.WriteLine("Hata!!! Değerler negatif olamaz.");
        }

        int[] arr = new int[a];
        Console.WriteLine();

        for(int i =0; i<a;i++){
            Console.Write($"{i+1}. deger : ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine();
        Array.Reverse(arr);

        foreach(int item in arr){
            if(item>=0) Console.Write(item+" ");
        }

        Console.WriteLine();
    }

    public void forth(){
        Console.WriteLine("Cumle giriniz : ");
        string cumle = Console.ReadLine();

        int bosluk=0,kelime=1,harf=0;
        
        foreach(char c in cumle){
            if(c==' ') bosluk++;
        }

        harf = (cumle.Length)-bosluk;
        kelime = kelime+bosluk;

        Console.Write($"Harf sayisi {harf}\nKelime sayisi {kelime}");
    }
}