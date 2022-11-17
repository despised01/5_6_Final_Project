using System;

namespace _5_6_Final_Project
{
    class Program
    {

        static (string FirstName, string LastName, int Age) UserInfoPrimary()
        {
            (string FirstName, string LastName, int Age) UserPrimary;

            Console.WriteLine("Напишите ваше имя:");
            UserPrimary.FirstName = Console.ReadLine();

            Console.WriteLine("Напишите вашу фамилию:");
            UserPrimary.LastName = Console.ReadLine();

            string age;
            int intage;
            do
            {
                Console.WriteLine("Напишите ваш возраст цифрами:");
                age = Console.ReadLine();
            }
            while (CheckNum(age, out intage));

            UserPrimary.Age = intage;

            return UserPrimary;
        }

        static (bool HasPet, int CountPet, string[] NamePet, int CountColors, string[] FavColors) UserInfoSecondary()
        {
            (bool HasPet, int CountPet, string[] NamePet, int CountColors, string[] FavColors) UserSecondary;

            Console.WriteLine("Есть ли у вас питомцы? Ответ да или нет");
            var Answer = Console.ReadLine();

            if (Answer == "да")
                UserSecondary.HasPet = true;
            else
                UserSecondary.HasPet = false;

            if (UserSecondary.HasPet == true)
            {
                Console.WriteLine("Сколько у вас питомцев? Введите пожалуйста ответ цифрами.");              
            }
            UserSecondary.CountPet = int.Parse(Console.ReadLine());
            int num = UserSecondary.CountPet;

            UserSecondary.NamePet = new string[num];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("\nВведите имя вашего {0} питомца:", i + 1);
                UserSecondary.NamePet[i] = Console.ReadLine();
            }

            Console.WriteLine("Сколько у вас любимых цветов? Введите пожалуйста ответ цифрами.");
            UserSecondary.CountColors = int.Parse(Console.ReadLine());
            int colornum = UserSecondary.CountColors;

            UserSecondary.FavColors = new string[colornum];
            for (int j = 0; j < colornum; j++)
            {
                Console.WriteLine("\nВведите ваш любимый цвет {0}", j + 1);
                UserSecondary.FavColors[j] = Console.ReadLine();
            }
            

            return UserSecondary;
        }

        static bool CheckNum(string number, out int corrnumber)
        {
            if (int.TryParse(number, out int intage))
            {
                if (intage > 0)
                {
                    corrnumber = intage;
                    return false;
                }
            }
            {
                corrnumber = 0;
                return true;
            }
        }

        static void Main(string[] args)
        {
            var (FirstName, LastName, Age) = UserInfoPrimary();
            var (HasPet, CountPet, NamePet, CountColors, FavColors) = UserInfoSecondary();

            Console.WriteLine("Ваше имя и фамилия: {0} {1}", FirstName, LastName);
            Console.WriteLine("Ваш возраст: {0}", Age);

            if (HasPet == true)
            {
                Console.WriteLine("Количество ваших питомцев: {0}", CountPet);
                foreach(string Names in NamePet)
                    Console.WriteLine($"Имя вашего питомца: {Names}");
            }

            Console.WriteLine("Количество ваших любимых цветов: {0}", CountColors);
            foreach(string Colors in FavColors)
                Console.WriteLine($"Ваш любимый цвет: {Colors}");
        }


       

        

    }
}
