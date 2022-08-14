using System.Collections.Generic;
using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        Soru algo = new Soru();
        algo.First();
        algo.Second();

    }
}

class Soru{
    public void First(){
        ArrayList asal = new ArrayList();
        ArrayList asalOlmayan = new ArrayList();
        int[] numList = new int[10];
        for(int i =0;i<10;i++){
            bool control = false;
            Console.Write($"{i+1}. elemani giriniz : ");
            while(control == false){
                numList[i]= Convert.ToInt32(Console.ReadLine());
                if(numList[i]<0) Console.WriteLine("Negatif sayi girilemez!");
                else control =true;
            }
            
        }

        foreach(int num in numList ){
            if(asalMi(num)==true) asal.Add(num);
            else asalOlmayan.Add(num);
        }
        Console.WriteLine("Asal olanlar");
        foreach(int item in asal){
            Console.Write(item+" ");
        }
        Console.WriteLine();
        Console.WriteLine("Asal olmayanlar");
        foreach(int item in asalOlmayan){
            Console.Write(item+" ");
        }
    }

    public void Second(){
        ArrayList ebOrt = new ArrayList();
        ArrayList ekOrt = new ArrayList();
        int[] numList = new int[10];

        for(int i =0; i<10;i++){
            bool control = false;
            Console.Write($"{i+1}. elemani giriniz : ");
            while(control == false){
                numList[i]= Convert.ToInt32(Console.ReadLine());
                if(numList[i]<0) Console.WriteLine("Negatif sayi girilemez!");
                else control =true;
            }
        }

        Array.Sort(numList);

        ebOrt.Add(numList[9]);
        ebOrt.Add(numList[8]);
        ebOrt.Add(numList[7]);

        ekOrt.Add(numList[0]);
        ekOrt.Add(numList[1]);
        ekOrt.Add(numList[2]);

        int total=0;
        Console.WriteLine("En buyuk sayilar");
        foreach(int num in ebOrt){
            Console.Write(num+" ");
            total+=num;
        }
        Console.WriteLine("Ortalama : "+((double)total/3));
        total =0;

        Console.WriteLine();

        Console.WriteLine("En kucuk sayilar");
        foreach(int num in ekOrt){
            Console.Write(num+" ");
            total+=num;
        }
        Console.WriteLine("Ortalama : "+((double)total/3));
    }

    public static bool asalMi(int n){
        bool control = true;
        for(int i =2; i<n;i++){
            if(n%i==0) control = false;
        }
        return control;
    }
}