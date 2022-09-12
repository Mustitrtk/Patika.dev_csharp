// See https://aka.ms/new-console-template for more information
Console.Write("Lütfen kelime ve index giriniz (arada virgül ile) :  ");
string str = Console.ReadLine();
string[] metin = str.Split(",");
int index = int.Parse(metin[1]);
metin[0] = metin[0].Remove(index,1);
Console.WriteLine(metin[0]);
