using System;

class Printer
{
    public static void PrintArray <T>(T[] arr){
        foreach(T i in arr){
            Console.WriteLine(i);
        }
    }

    static void Main(string[] args)
	{
        Console.Write("Int dizi boyutu giriniz : ");
		int n = Convert.ToInt32(Console.ReadLine());
		int[] intArray = new int[n];
		for (int i = 0; i < n; i++)
		{
            Console.Write($"{i+1}. eleman : ");
			intArray[i] = Convert.ToInt32(Console.ReadLine());
		}
		
        Console.Write("String dizi boyutu giriniz : ");
		n = Convert.ToInt32(Console.ReadLine());
		string[] stringArray = new string[n];
		for (int i = 0; i < n; i++)
		{
            Console.Write($"{i+1}. eleman : ");
			stringArray[i] = Console.ReadLine();
		}
		
		PrintArray<Int32>(intArray);
		PrintArray<String>(stringArray);
	}
}
