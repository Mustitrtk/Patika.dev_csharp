
try{
    int a = int.Parse(Console.ReadLine());
}
catch(FormatException e){
    Console.WriteLine("Hatalı giris!!!");
    Console.WriteLine(e.Message);
}
catch(ArgumentNullException e){
    Console.WriteLine("Değer boş olamaz!!!");
    Console.WriteLine(e.Message);
}
catch(ArgumentOutOfRangeException e){
    Console.WriteLine("Değerin sınırlarını aştı!!!");
    Console.WriteLine(e.Message);
}
finally{
    Console.WriteLine("Bitiş.");
}