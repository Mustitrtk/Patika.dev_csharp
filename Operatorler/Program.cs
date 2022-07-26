// Atama işlemi 
int x = 3;
int y = 3;
y+=2;
Console.WriteLine(y);
y+=2;
Console.WriteLine(y);
y/=1;
Console.WriteLine(y);
x+=2;
Console.WriteLine(x);

// Mantıksal Operatörler
// ||, &&, !

bool isSuccess = true;
bool isCompleted = false;

if(isSuccess && isCompleted){
    Console.WriteLine("Perfect!");
}
if(isSuccess || isCompleted){
    Console.WriteLine("Great!");
}
if(isSuccess && !isCompleted){
    Console.WriteLine("Fine!");
}

// Ilişkisel Operatorler
// <, >, <=, >=, ==, !=

int a =3;
int b =4;
bool sonuc = a<b;

Console.WriteLine(sonuc);
sonuc = a>b;
Console.WriteLine(sonuc);
sonuc = a>=b;
Console.WriteLine(sonuc);
sonuc = a<=b;
Console.WriteLine(sonuc);
sonuc = a==b;
Console.WriteLine(sonuc);
sonuc = a!=b;
Console.WriteLine(sonuc);

// Aritmetiksel Operatorler
// +, -, /, *, %

int sayi1 = 10;
int sayi2 = 5;
int islem =  sayi1/sayi2;

Console.WriteLine(islem);
islem=sayi1*sayi2;
Console.WriteLine(islem);
islem=sayi1+sayi2;
Console.WriteLine(islem);
islem = sayi1++;
Console.WriteLine(islem);

int islem2 = 20%3;
Console.WriteLine(islem2);