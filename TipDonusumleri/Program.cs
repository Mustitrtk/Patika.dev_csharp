// Kapali donusumler

int intSayi = 210;
byte byteSayi = (byte)intSayi;

float floatSayi = 10.8f;
byte byteSayi2=(byte) floatSayi;

// .ToString()

int sayi = 711;
string sSayi = sayi.ToString();
Console.WriteLine(sSayi);

string fSayi = 12.5f.ToString();
Console.WriteLine(fSayi);

// System Convert.

string s1="15", s2="13";
int sayi1,sayi2;
int toplam;

sayi1 = Convert.ToInt32(s1);
sayi2 = Convert.ToInt32(s2);

toplam = sayi1+sayi2;

Console.WriteLine(toplam);

// .Parse()

string metin1 = "216";
string metin2 = "21,13";

int metinInt = Int32.Parse(metin1);
double metinDouble = Double.Parse(metin2);

Console.WriteLine(metinInt);
Console.WriteLine(metinDouble);