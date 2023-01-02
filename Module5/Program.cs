using System;
using System.Data;

class program
{
    static void Main(string[] args)
    {
        (string Name, string LastName, int Age, bool HasPets, int PetsCount, string[] NamePets, string[] favcolour, int ColourCount) DataUser;

        // Вводим имия фамилия и возрвсть

        Console.WriteLine("Введите имя");
        DataUser.Name = Console.ReadLine();

        Console.WriteLine("Введите фамилию");
        DataUser.LastName = Console.ReadLine();

        string age;
        int intage;

        do
        {
            Console.WriteLine("Введите возраст пользователя");
            age = Console.ReadLine();
        }


        while (CheckNum(age, out intage));
        DataUser.Age = intage;

        DataUser.HasPets = CheckHasPets();

        if (DataUser.HasPets)
        {
            DataUser.PetsCount = EnterPetsCount();
            DataUser.NamePets = EnterPetsNames(DataUser.PetsCount);
        }
        DataUser.ColourCount = EnterFavColoursCount();
        DataUser.favcolour = EnterFavColouers(DataUser.ColourCount);

        static bool CheckNum(string number, out int corrnumber)
        {
            if (int.TryParse(number, out int intnum))
                if (intnum > 0)
                {
                    corrnumber = intnum;
                    return false;
                }
            corrnumber = 0;
            return true;

        }
    }
    // Животные
    static bool CheckHasPets()
    {
        Console.WriteLine("У вас усть домашние животние?");

        string HasPets = Console.ReadLine();
        if (HasPets == "Да")
            return true;

        return false;
    }

    static int EnterPetsCount()
    {
        Console.WriteLine("Сколько у вас домашних животных? ");

        return Convert.ToInt32(Console.ReadLine());
    }
    static string[] EnterPetsNames(int count)
    {
        Console.WriteLine("Введите клички ваших питомцев: ");
        var result = new string[count];

        for (int k = 0; k < result.Length; k++)
        {
            Console.Write(k + 1 + ": ");
            result[k] = Console.ReadLine();
        }
        Console.WriteLine("Клички ваших питомцев: ");
        foreach (var NamePets in result)
        {
            Console.Write(NamePets + ", ");
        }

        return result;
    }

    //Любимые цвета
    static int EnterFavColoursCount()
    {
        Console.WriteLine("Сколько у вас любимых цветов? ");

        return Convert.ToInt32(Console.ReadLine());
    }
    static string[] EnterFavColouers(int ColourCount)
    {
        Console.WriteLine("Введите ваш лубимый цвета: ");
        var result = new string[ColourCount];

        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(i + 1 + ": ");
            result[i] = Console.ReadLine();
        }
        Console.WriteLine("Ваш любимые цвета: ");
        foreach (var favcolour in result)
        {
            Console.Write(favcolour + ", ");
        }

        return result;
    }
    static void ShowDataUser((string Name, string LastName, int Age, bool HasPets, int PetsCount, string[] NamePets, string[] FavColour, int ColourCount) DataUser)
    {
        Console.WriteLine(DataUser.Name);
        Console.WriteLine(DataUser.LastName);
        Console.WriteLine(DataUser.Age);

        if (DataUser.HasPets)
        {
            foreach (var names in DataUser.NamePets)
                Console.WriteLine(names);
        }
        foreach (var colours in DataUser.FavColour)
            Console.WriteLine(colours);

    }

}
