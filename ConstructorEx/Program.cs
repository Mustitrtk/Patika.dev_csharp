internal class Program
{
    private static void Main(string[] args)
    {
        Obs ogr = new Obs();
        ogr.OgrenciAd="";
        ogr.OgrenciSoyad="";
        ogr.OgrenciNo="214742017";
        ogr.bilgiGoster();
    }
}

class Obs{
    private string ogrenciAd;
    private string ogrenciSoyad;
    private string ogrenciNo;

    public string OgrenciAd{
        get { return ogrenciAd; }
        set { 
            if(string.IsNullOrEmpty(value)==true) ogrenciAd = "bos";
            
            else ogrenciAd = value; 
        }
    }

    public string OgrenciSoyad {
        get { return ogrenciSoyad; } 
        set {
            if(string.IsNullOrEmpty(value)==true) ogrenciSoyad="bos";

            else ogrenciSoyad=value;
        }
    }

    public string OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }

    public Obs(string ad, string soyad, string no){
        ogrenciAd = ad;
        OgrenciSoyad = soyad;
        OgrenciNo = no;
    }

    public Obs(){}

    public void bilgiGoster(){
        Console.WriteLine($"Ogrenci ad-soyad : {ogrenciAd} {OgrenciSoyad}");
        Console.WriteLine($"Ogrenci no : {OgrenciNo}");
    }
}