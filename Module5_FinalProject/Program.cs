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
        int numberOfPets;
        int numberOfColors;
        string[] petNames = null;
        string[] favorColors = null;
        bool hasFavorColor;
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

        do
        {
            Console.WriteLine("Do you have a pet? ");
        } while ( !IsValidYesNo(Console.ReadLine(), out hasPet) );
        if (hasPet)
        { do
            {
                Console.WriteLine("Enter the number of your pets: ");
            } while (!int.TryParse(Console.ReadLine(), out numberOfPets) || (!IsValidNumber(numberOfPets)));
            petNames = PetNames(numberOfPets);
        }

        do
        {
            Console.WriteLine("Do you have favorite color?");
        } while ( !IsValidYesNo(Console.ReadLine(), out hasFavorColor) );
        if (hasFavorColor)
        {
            do
            {
                Console.WriteLine("Enter the number of favorite colors: ");
            } while ( !int.TryParse(Console.ReadLine(), out numberOfColors) || (!IsValidNumber(numberOfColors)) );
            favorColors = FavorColorNames(numberOfColors);
        }

        return (name, lastName, age, petNames, favorColors);
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

    static bool IsValidYesNo(string input, out bool result)
    {
        result = false;
        if (input.ToLower() == "yes")
        {
            result = true;
            return true;
        }
        else if (input.ToLower() == "no")
        {
            result = false;
            return true;
        }
        else
        {
            Console.WriteLine("Incorrect input, try one more time: ");
            return false;
        }
    }

    static string[] PetNames(int numberOfPets)
    {
        string[] petNames = new string[numberOfPets];
        for (int i = 0; i < numberOfPets; i++)
        {
            do
            {
                Console.WriteLine("Enter the name of pet {0}: ", petNames[i]);
            } while (!IsValidString(petNames[i]));
        }
        return petNames;
    }

    static string[] FavorColorNames(int numberOfColors)
    {
        string[] colorNames = new string[numberOfColors];
        for (int i = 0; i < numberOfColors; i++)
        {
            do
            {
                Console.WriteLine("Enter the name of color {0}: ", colorNames[i]);
            } while (!IsValidString(colorNames[i]));
        }
        return colorNames;
    }
    
}