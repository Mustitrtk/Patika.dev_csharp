
public class Islem{  
    public Dictionary<string,string> list = new Dictionary<string, string>();
    public string adSoyad;
    public string numara;
    public void Add(){
        Console.Write("Ad ve soyad giriniz : ");
        adSoyad = Console.ReadLine();
        Console.Write("Numara giriniz : ");
        numara = Console.ReadLine();

        list.Add(adSoyad,numara);
    }

    public void Delete(){
        Console.Write("Lütfen numarasini silmek istediğiniz kişinin adini-soyadini giriniz:");
        adSoyad = Console.ReadLine();
        if(list.ContainsKey(adSoyad)){
            list.Remove(adSoyad); 
            Console.WriteLine("Islem basarili");
        } 
        else Console.WriteLine("Kisi bulunamadi tekrar deneyiniz.");
    }

    public void Update(){
        Console.Write("Lütfen numarasini guncellemek istediğiniz kişinin adini-soyadini giriniz:");
        adSoyad = Console.ReadLine();
        if(list.ContainsKey(adSoyad)){
            list.Remove(adSoyad);
            Console.Write("Yeni numarayi giriniz : ");
            numara=Console.ReadLine();
            list.Add(adSoyad,numara);
            Console.WriteLine("Islem basarili");
        }
        else Console.WriteLine("Kisi bulunamadi tekrar deneyiniz.");
    }

    public void SortBy(){
        var l = list.Keys.ToList();
        l.Sort();

        foreach(var key in l){
            Console.WriteLine($"{key} - {list[key]}");
        }
    }

    public void CallWithName(){
        Console.Write("Lütfen aramak istediğiniz kişinin adını-soyadını giriniz:");
        adSoyad = Console.ReadLine();
        
        if(list.ContainsKey(adSoyad)){
            Console.WriteLine($"araniyor {list[adSoyad]}");
        }
        else Console.WriteLine("Kisi bulunamadi tekrar deneyiniz.");
    }

    public void CallWithNumber(){
        Console.Write("Lütfen aramak istediğiniz kişinin numarasını giriniz:");
        numara = Console.ReadLine();
        if(list.ContainsValue(numara)){
            var myKey = list.FirstOrDefault(x => x.Value == numara).Key;
            Console.WriteLine($"araniyor {myKey}");
        }
        else Console.WriteLine("Kisi bulunamadi tekrar deneyiniz.");
    }
}