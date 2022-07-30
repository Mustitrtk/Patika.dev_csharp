Console.Write("Bir sayi giriniz : ");
int a = int.Parse(Console.ReadLine());
bool asalMi= true;
for(int i = 2; i<a;i++){
    if(a%i==0) asalMi = false;
}
Console.WriteLine(asalMi==true?$"{a} sayisi asaldir. ":$"{a} sayisi asal degildir.");