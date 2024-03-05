using System.Runtime.CompilerServices;

namespace HW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();

            user1.Gender = Gender.Male;

            Console.Write("Enter user first name: ");
            user1.FirstName = Console.ReadLine();
            Console.Write("Enter user last name: ");
            user1.LastName = Console.ReadLine();

            Console.WriteLine(user1.ToString());
        }
    }
}
