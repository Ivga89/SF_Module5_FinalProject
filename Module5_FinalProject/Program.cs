internal class Program
{
    private static void Main(string[] args)
    {
        var userData = CollectUserData();
    }

    static (string name, string lastName, int age, string[] petNames, string[] favorColors) CollectUserData()
    {
        string name;
        string lastName;
        int age;
        int countOfPets;
        int countOfColors;
        string[] petNames = null;
        string[] favorColors = null;
        bool hasPet;

        do
        {
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
        } while (!IsValidString(name));

        do
        {
            Console.WriteLine("Enter your last name");
            lastName = Console.ReadLine();
        } while (IsValidString(lastName));

        do
        {
            Console.WriteLine("Enter your age: ");
        } while (!int.TryParse(Console.ReadLine(), out age) || (!IsValidNumber(age)));
    }



    static bool IsValidString(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Incorrect input, try one more time: ");
            return false;
        }
        return true;
    }

    static bool IsValidNumber(int number)
    {
        if (number <= 0)
        {
            Console.WriteLine("Incorrect input, try one more time: ");
            return false;
        }
        return true;
    }

    
}