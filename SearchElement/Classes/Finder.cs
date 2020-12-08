using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SearchElement.Classes
{
    /// <summary>
    ///     Клас для пошуків елементів
    /// </summary>
    static class Finder
    {
        /// <summary>
        ///     Виконує пошук по Id
        /// </summary>
        /// <param name="users">Колекція користувачів</param>
        /// <param name="Id">Сам ідентифікатор</param>
        /// <returns>Повертає масив з користувачами які підходять під заданий ідентифікатор</returns>        
        public static List<User> FindForId(DbSet<User> users, int Id) 
        {
            List<User> user = users.Where((User us) => us.id == Id).ToList();
            return user;
        }
        /// <summary>
        ///     Виконує пошук по імені
        /// </summary>
        /// <param name="users">Колекція користувачів</param>
        /// <param name="name">Ім'я</param>
        /// <returns>Повертає масив з користувачами які підходять під задане ім'я</returns>
        public static List<User> FindForName(DbSet<User> users, string name)
        {
            List<User> us = users.Where((User us) => us.name == name).ToList();
            return us;
        }
        /// <summary>
        ///     Виконує пошук по прізвищу
        /// </summary>
        /// <param name="users">Колекція користувачів</param>
        /// <param name="surname">Прізвище</param>
        /// <returns>Повертає масив з користувачами які підходять під задане прізвище</returns>
        public static List<User> FindForSurname(DbSet<User> users, string surname)
        {
            List<User> us = users.Where((User us) =>  us.surname == surname).ToList();
            return us;
        }
        /// <summary>
        ///     Виконує пошук по по-батькові
        /// </summary>
        /// <param name="users">Колекція користувачів</param>
        /// <param name="lastname">по-батькові</param>
        /// <returns>Повертає масив з користувачами які підходять під задане по-батькові</returns>
        public static List<User> FindForLastname(DbSet<User> users, string lastname)
        {
            List<User> us = users.Where((User us) => us.lastname == lastname).ToList();
            return us;
        }
        /// <summary>
        ///     Виконує пошук по номеру телефону
        /// </summary>
        /// <param name="users">Колекція користувачів</param>
        /// <param name="telNumer">Телефон</param>
        /// <returns>Повертає масив з користувачами які підходять під заданий номер телефону</returns>
        public static List<User> FindForTelNumer(DbSet<User> users, string telNumer)
        {
            List<User> us = users.Where((User us) => us.telNumer == telNumer).ToList();
            return us;
        }
        /// <summary>
        ///     Виконує пошук по розміру ноги
        /// </summary>
        /// <param name="users">Колекція користувачів</param>
        /// <param name="footSize">Розмір ноги</param>
        /// <returns>Повертає масив з користувачами які підходять під заданий розмір ноги</returns>
        public static List<User> FindForFootSize(DbSet<User> users, int footSize)
        {
            List<User> us = users.Where((User us) => us.footSize == footSize).ToList();
            return us;
        }
        /// <summary>
        ///     Виконує пошук по віку
        /// </summary>
        /// <param name="users">Колекція користувачів</param>
        /// <param name="age">Вік</param>
        /// <returns>Повертає масив з користувачами які підходять під заданий вік</returns>
        public static List<User> FindForAge(DbSet<User> users, int age)
        {
            List<User> us = users.Where((User us) => us.age == age).ToList();
            return us;
        }
        /// <summary>
        ///     Виконує пошук по вазі
        /// </summary>
        /// <param name="users">Колекція користувачів</param>
        /// <param name="weight">Вага</param>
        /// <returns>Повертає масив з користувачами які підходять під задану вагу</returns>
        public static List<User> FindForWeight(DbSet<User> users, int weight)
        {
            List<User> us = users.Where((User us) => us.weigth == weight).ToList();
            return us;
        }
        /// <summary>
        ///     Виконує пошук по статі
        /// </summary>
        /// <param name="users">Колекція користувачів</param>
        /// <param name="state">Стать (0 або 1)</param>
        /// <returns>Повертає масив з користувачами які підходять під задану стать</returns>
        public static List<User> FindForState(DbSet<User> users, byte state)
        {
            List<User> us = users.Where((User us) => us.state == state).ToList();
            return us;
        }
    }
}
