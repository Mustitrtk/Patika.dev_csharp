Console.Write("Cumle giriniz : ");
string mtn = Console.ReadLine();
string[] metin = mtn.Split(" ");
foreach(string item in metin){
    char[] c = item.ToCharArray();
    for(int i =1;i<c.Length;i++){
        Console.Write(c[i]+"");
    }
    Console.Write(c[0]+" ");
}
