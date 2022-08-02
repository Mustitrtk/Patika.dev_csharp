Console.Write("Enter a number : ");
int n = Convert.ToInt32(Console.ReadLine());
int sayac = 1;
int total =0;
while(sayac <= n){
    total += sayac;
    sayac++;
}

Console.WriteLine($"Avarage of the number {(double)total/n}");

int[] numbers = new int[]{1,2,3,4,5,6,7,8};
int total2 =0;
int len = numbers.Length;
foreach(int num in numbers){
    total2+=num;
}

Console.WriteLine($"Avarage of the array {(double)total2/len}");
