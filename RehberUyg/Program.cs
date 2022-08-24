Islem islem = new Islem();
bool bitis = true;

while(bitis == true){
    Console.WriteLine("Lutfen yapmak istediginiz islemi seciniz");
    Console.WriteLine("*************************");
    Console.WriteLine("1-Yeni numara kaydetmek\n2-Var olan numarayi silmek\n3-Var olan numarayi guncellemek\n4-Rehberi listele\n5-Arama yap(isim ile)\n6-Arama yap(numara ile)\n7-Programi kapat");
    Console.Write("secim : ");
    string key = Console.ReadLine();
    switch(key){
        case "1":
            islem.Add();
        break;
        case "2":
            islem.Delete();
        break;
        case "3":
            islem.Update();
        break;
        case "4":
            islem.SortBy();
        break;
        case "5":
            islem.CallWithName();
        break;
        case "6":
            islem.CallWithNumber();
        break;
        case "7":
            bitis = false;
        break;
        default:
            Console.WriteLine("Hatali tuslama");
        break;
    }
    Console.WriteLine();
}
