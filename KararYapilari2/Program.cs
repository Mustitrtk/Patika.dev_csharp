Console.Write("Ay giriniz(tamsayi) : ");
int ay = int.Parse(Console.ReadLine());

switch(ay){
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Kis");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("İlkbahar");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Yaz");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Sonbahar");
        break;
    default:
    break;
}
