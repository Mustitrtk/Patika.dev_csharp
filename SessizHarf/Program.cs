string unluler = "aeıioöuü";

Console.Write("Metin giriniz : ");
string text = Console.ReadLine();

string[] kelimeler = text.Split(" ");


foreach(string kelime in kelimeler){
    int sayac =0;
    bool control = false;
    foreach(var harf in kelime){
        if(unluler.Contains(harf)){
            sayac =0;
        }
        else{
            sayac++;
            if(sayac ==2){
                control = true;
                break;
            }
        }
    }
    Console.Write(control+" ");
}