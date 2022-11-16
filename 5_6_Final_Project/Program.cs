using System;

namespace _5_6_Final_Project
{
    class Program
    {
        static (string FirstName, string LastName, int Age, bool HasPet, int CountPet, string[] NamePet, string[] FavColors) UserInfo()
        {
            (string FirstName, string LastName, int Age, bool HasPet, int CountPet, string[] NamePet, string[] FavColors) User;

            Console.WriteLine("Здравствуйте! Давайте уточним ваши данные.");

            Console.WriteLine("Напишите ваше имя:");
            User.FirstName = Console.ReadLine();

            Console.WriteLine("Напишите вашу фамилию:");
            User.LastName = Console.ReadLine();

            Console.WriteLine("Напишите ваш возраст:");
            User.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Есть ли у вас питомцы? Ответ да или нет");
            User.HasPet = bool.Parse(Console.ReadLine());

            if(User.HasPet = "да")


        }
    }
}
