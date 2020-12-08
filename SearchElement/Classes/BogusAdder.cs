using Bogus;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using static Bogus.DataSets.Name;



namespace SearchElement.Classes
{
    /// <summary>
    ///     Клас для заповнення БД
    /// </summary>
    static class BogusAdder
    {
        private static Faker<User> faker = null;
        /// <summary>
        ///     Створює Faker та задає йому правила
        /// </summary>
        private static void CreateFaker() 
        {
            faker = new Faker<User>("uk");
            faker.RuleFor((User us) => us.gender, (Faker f) => f.PickRandom<Gender>());
            faker.RuleFor((User us) => us.name, (Faker f, User us) => f.Name.FirstName(us.gender));
            faker.RuleFor((User us) => us.surname, (Faker f, User us) => f.Name.LastName(us.gender));
            faker.RuleFor((User us) => us.age, (Faker f) => f.Random.Int(1, 90));
            faker.RuleFor((User us) => us.telNumer, (Faker f) => f.Phone.PhoneNumber());
            faker.RuleFor((User us) => us.weigth, (Faker f) => f.Random.Int(12, 200));
            faker.RuleFor((User us) => us.footSize, (Faker f) => f.Random.Int(5,50));
            faker.RuleFor((User us) => us.state, (Faker f, User us) => (byte)us.gender);
            faker.RuleFor((User us) => us.lastname, (Faker f,User us) => f.Name.FirstName(Gender.Male));
        }
        /// <summary>
        ///     Метод для заповнення таблички
        /// </summary>
        /// <param name="count">Кількість користувачів, яких потрібно додати</param>
        /// <param name="users">Колекція користувачів типу DbSet</param>
        public static void PushToBd(int count, DbSet<User> users) 
        {
            if (faker == null) 
            {
                CreateFaker();
            }

            for (int i = 0; i < count; i++)
            {
                User user = faker.Generate();

                if (user.state == 0)
                {
                    if (user.lastname.EndsWith('о'))
                    {
                        user.lastname += "вич";
                    }
                    else 
                    {
                        user.lastname += "ович";
                    }
                } 
                else if (user.state == 1) 
                {
                    if (user.lastname.EndsWith('о'))
                    {
                        user.lastname += "вна";
                    }
                    else 
                    {
                        user.lastname += "івна";
                    }
                }

                
                users.Add(user);
            }


            Console.WriteLine("Успішно додано!");
        }
    }
}
