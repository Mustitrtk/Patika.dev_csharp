Console.Write("Dizi uzunlugunu giriniz : ");
int l = int.Parse(Console.ReadLine());
int[] ikiler = new int[l];
for(int i =0;i<l;i++){
    Console.Write($"Dizinin {i+1}. elemanini giriniz : ");
    ikiler[i]=int.Parse(Console.ReadLine());
}
for(int j=0; j<l;j+=2){
    if(l%2==1 && j+1==l) Console.Write(ikiler[j]);
    else if(ikiler[j]!=ikiler[j+1]){
        Console.Write((ikiler[j]+ikiler[j+1])+" ");
    }
    else{
        Console.Write(Math.Pow((ikiler[j]+ikiler[j+1]),2)+" ");
    }
}
