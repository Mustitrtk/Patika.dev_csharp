// Uc sayiyi Buyuk, Orta ve Kucuk olarak ayıran c# programı.
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int eb,ek,mid; // eb -> en buyuk, ek -> en kucuk, mid -> ortanca

if(a>b){
    if(b>c){
        eb=a;
        ek=c;
        mid=b;
    }
    else if(c>a){
        eb=c;
        ek=b;
        mid=a;
    }
    else{
        eb=a;
        ek=b;
        mid=c;
    }
}

else{
    if(a>c){
        eb=b;
        ek=c;
        mid=a;
    }
    else if(c>b){
        eb=c;
        ek=a;
        mid=b;
    }
    else{
        eb=b;
        ek=a;
        mid=c;
    }
}

Console.WriteLine(eb+" "+mid+" "+ek);
