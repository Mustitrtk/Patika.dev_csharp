// Fibonacci serisinde kullanicinin girdiği değere göre ortalama alma.
Console.Write("Satir degerini giriniz : ");
int satir = int.Parse(Console.ReadLine()); 

int a =1;
int b =1;
int c, ort=2;

Console.WriteLine(a+"\n"+b);
for(int i =0; i<satir;i++){
    c=a+b;
    Console.WriteLine(c);
    a = b;
    b = c;
    ort+=c;
}
Console.WriteLine("Ortalama : "+ort/satir);
