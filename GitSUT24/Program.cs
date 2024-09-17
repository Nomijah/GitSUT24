namespace GitSUT24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this super awesome game!");
            Console.WriteLine("Choose a nickname:");
            string userNick = Console.ReadLine();
            Console.WriteLine($"Greetings, oh exalted {userNick}!");
        }
    }
}
