using System;

namespace _5_6_Final_Project
{
    class Program
    {

        static (string FirstName, string LastName, int Age, bool HasPet, int CountPet, string[] NamePet, int CountColors, string[] FavColors) UserInfo()
        {
            (string FirstName, string LastName, int Age, bool HasPet, int CountPet, string[] NamePet, int CountColors, string[] FavColors) User;

            Console.WriteLine("Здравствуйте! Давайте уточним ваши данные.");

            Console.WriteLine("Напишите ваше имя:");
            User.FirstName = Console.ReadLine();

            Console.WriteLine("Напишите вашу фамилию:");
            User.LastName = Console.ReadLine();

            string age;
            int intage;
            do
            {
                Console.WriteLine("Напишите ваш возраст цифрами:");
                age = Console.ReadLine();
            }
            while (CheckNum(age, out intage));

            User.Age = intage;

            Console.WriteLine("Есть ли у вас питомцы? Ответ да или нет");
            var Answer = Console.ReadLine();

            if (Answer == "да")
                User.HasPet = true;
            else
                User.HasPet = false;

            if(User.HasPet == true)
            {
                Console.WriteLine("Сколько у вас питомцев? Введите пожалуйста ответ цифрами.");
                User.CountPet = int.Parse(Console.ReadLine());
                int num = User.CountPet;

                User.NamePet = new string[num];
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("\nВведите кличку {0} питомца:", i + 1);
                    User.NamePet[i] = Console.ReadLine();
                }

            }

            Console.WriteLine("Сколько у вас любимых цветов? Введите пожалуйста ответ цифрами.");
            User.CountColors = int.Parse(Console.ReadLine());
            int colornum = User.CountColors;

            User.FavColors = new string[colornum];
            for (int j = 0; j < colornum; j++)
            {
                Console.WriteLine("\nВведите ваш любимый цвет {0}", j + 1);
                User.FavColors[j] = Console.ReadLine();
            }

            return User;
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

       

        

    }
}
