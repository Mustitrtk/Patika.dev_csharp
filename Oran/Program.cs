Console.Write("Enter a size : ");
int s = int.Parse(Console.ReadLine());

int[] arr = new int[s];

int pozitive=0,negative=0,zero=0;

for(int i =0;i<s;i++){

    Console.Write($"Enter {i+1}. :");
    arr[i]=int.Parse(Console.ReadLine());

    if(arr[i]>0) pozitive++;
    else if(arr[i]<0) negative++;
    else zero++;

}

Console.WriteLine($"Pozitive rate : {(double)pozitive/s}");
Console.WriteLine($"Negative rate : {(double)negative/s}");
Console.WriteLine($"Zero rate : {(double)zero/s}");