internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a username : ");
        string username = Console.ReadLine();
        
        string password="";
        bool c = false;

        while(c==false){

            Console.Write("Enter a password : ");
            password = Console.ReadLine();
            c = control(password);
            if(c==false) Console.WriteLine("Invalid password please try again.");

        }

        Console.WriteLine();

        Console.Write("Password again : ");
        string passwordA = Console.ReadLine();
        if(password.CompareTo(passwordA)==0) Console.WriteLine("Password activeted!");
        else Console.WriteLine("Error!");
    }

    public static bool control(string s)
    {
        bool c = false;
        for(char i = '0',j='A';i<='9'&&j<='Z';i++,j++){
            if(s.Contains(i)||s.Contains(j)) c = true;
        }

        return c;
    }
}