class GeometrikSekil{
    public int kenar1;
    public int kenar2;
    public int r;
    public void giris(){
        Console.Write("Ilk kenari giriniz : ");
        kenar1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ikinci kenari giriniz : ");
        kenar2 = Convert.ToInt32(Console.ReadLine());
    }
    public void Kare(){
        Console.WriteLine("Alan : "+(kenar1*kenar2));
        Console.WriteLine("Cevre : "+(2*(kenar1+kenar2)));
    }

    public void Ucgen(){
        int kenar3 = (int)(Math.Sqrt(Math.Pow(kenar1,2)+Math.Pow(kenar2,2)));
        Console.WriteLine("Alan : "+(kenar1*kenar2/2));
        Console.WriteLine("Cevre : "+(kenar1+kenar2+kenar3));
    }

    public void Daire(){
        Console.Write("Radius giriniz : ");
        r = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Alan : "+(Math.PI*r*r));
        Console.WriteLine("Cevre : "+(2*Math.PI*r));
    }
}