int a = int.Parse(Console.ReadLine());

if(a%3==0 && a%5==0){
    Console.WriteLine("FizzBuzz");
}
else if(a%3==0){
    Console.WriteLine("Fizz");
}
else if(a%5==0){
    Console.WriteLine("Buzz");
}
else Console.WriteLine(a);
