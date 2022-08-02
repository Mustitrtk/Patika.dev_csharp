
int[] arr = new int[]{1,2,5,8,0,11};

Console.WriteLine("****Sort****");
Array.Sort(arr);
foreach(int num in arr){
    Console.Write(num+" ");
}
Console.WriteLine();

int enKucuk = arr[0];

Console.WriteLine("****IndexOf****");
int enKucukIndex = Array.IndexOf(arr,enKucuk);
Console.WriteLine($"En kucuk eleman {enKucuk}, ve indexi {enKucukIndex}");

Array.Reverse(arr);
foreach(int num in arr){
    Console.Write(num+" ");
}
