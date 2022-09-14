internal class Program
{
    private static void Main(string[] args)
    {
        GeometrikSekil g = new GeometrikSekil();

        bool control = true;
        int secim;
        while(control!=false){

            Console.Write("1-Kare&Dikdortgen\n2-Ucgen\n3-Daire\n4-Ayril\nSecim yapiniz: ");
            secim = int.Parse(Console.ReadLine());

            switch(secim){
                case 1:
                    g.giris();
                    g.Kare();
                break;
                case 2:
                    g.giris();
                    g.Ucgen();
                break;
                case 3:
                    g.Daire();
                break;
                case 4:
                    control = false;
                break;
                default:
                    Console.WriteLine("Hatali tuslama.");
                break;
            }
        }
    }
}