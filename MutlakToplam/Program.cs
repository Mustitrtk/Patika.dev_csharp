int kucuk=0,buyuk=0;

Console.Write("Dizi boyutunu giriniz : ");
int l = int.Parse(Console.ReadLine());


for(int i =1;i<=l;i++){
    Console.Write($"{i}. degeri giriniz : ");
    int sayi = int.Parse(Console.ReadLine());
    if(sayi>67){    
        buyuk+=(int)(Math.Pow((sayi-67),2));
    }
    else{
        kucuk+=(67-sayi);
    }
}

Console.Write($"{kucuk} {buyuk}");