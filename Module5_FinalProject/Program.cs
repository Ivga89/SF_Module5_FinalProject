internal class Program
{
    private static void Main(string[] args)
    {
        var userData = CollectUserData();
    }

    static (string name, string lastName, byte age, string[] petNames, string[] favorColors) CollectUserData()
    {
        string name;
        string lastName;
        byte age;
        byte countOfPets;
        byte countOfColors;
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
    }

    static bool IsValidString(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Incorrect input");
            return false;
        }
        return true;
    }

    
}