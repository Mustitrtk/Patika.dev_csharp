internal class Program
{
    private static void Main(string[] args)
    {
        Obs ogr = new Obs("213242017");
        ogr.bilgiGoster();
    }
}

class Obs{
    private string ogrenciAd;
    private string ogrenciSoyad;
    private string ogrenciNo;

    public Obs(string ad, string soyad, string no){
        ogrenciAd = ad;
        ogrenciSoyad = soyad;
        ogrenciNo = no;
    }

    public Obs(string no){
        ogrenciNo = no;
    }

    public void bilgiGoster(){
        Console.WriteLine($"Ogrenci ad-soyad : {ogrenciAd}{ogrenciSoyad}");
        Console.WriteLine($"Ogrenci no : {ogrenciNo}");
    }
}