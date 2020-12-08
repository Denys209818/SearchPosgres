using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SearchElement.Classes.Menu
{
    /// <summary>
    ///     Відповідає за меню
    /// </summary>
    static class Menu
    {
        public static void StartMenu(Context c) 
        {

            int counter = 1;
            while (true) 
            {
             Console.Clear();
            ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
            
                Console.WriteLine("----------------------");
               while (keyInfo.Key != ConsoleKey.Enter) 
            {
                Clear();
                if (counter == 1) 
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }
                Console.WriteLine("| 1. Знайти по Id");
                Console.BackgroundColor = ConsoleColor.Black;



                if (counter == 2)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }
                Console.WriteLine("| 2. Знайти по імені");
                Console.BackgroundColor = ConsoleColor.Black;



                if (counter == 3)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }
                Console.WriteLine("| 3. Знайти по прізвищу");
                Console.BackgroundColor = ConsoleColor.Black;


                if (counter == 4)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }
                Console.WriteLine("| 4. Знайти по побатькові");
                Console.BackgroundColor = ConsoleColor.Black;



                if (counter == 5)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }
                Console.WriteLine("| 5. Знайти по віку");
                Console.BackgroundColor = ConsoleColor.Black;



                if (counter == 6)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }
                Console.WriteLine("| 6. Знайти по статі");
                Console.BackgroundColor = ConsoleColor.Black;



                if (counter == 7)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }
                Console.WriteLine("| 7. Знайти по номеру телефону");
                Console.BackgroundColor = ConsoleColor.Black;



                if (counter == 8)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }
                Console.WriteLine("| 8. Знайти по розміру ноги");
                Console.BackgroundColor = ConsoleColor.Black;



                if (counter == 9)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }
                Console.WriteLine("| 9. Знайти по вазі");
                Console.BackgroundColor = ConsoleColor.Black;


                if (counter == 10)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }
                Console.WriteLine("| 10. Вийти");
                Console.BackgroundColor = ConsoleColor.Black;

                Console.WriteLine("----------------------");



                    keyInfo = Console.ReadKey();

                switch (keyInfo.Key) 
                {
                    case ConsoleKey.UpArrow: 
                        {
                            if (counter > 1)
                            {
                                counter--;
                            }
                            else 
                            {
                                counter = 10;
                            }
                            break; 
                        }
                    case ConsoleKey.DownArrow: 
                        {
                            if (counter < 10)
                            {
                                counter++;
                            }
                            else 
                            {
                                counter = 1;
                            }
                            break; 
                        }
                }
            }
             Console.Clear();
                ReadBorders();

                List<User> users = new List<User>();
                switch (counter) 
                {
                    case 1: 
                        {
                            int Id = ReadNumber();
                            users = Finder.FindForId(c.users,Id);
                            break; 
                        }
                    case 2: 
                        {
                            string name = ReadText("ім'я");
                            users = Finder.FindForName(c.users, name);
                            break;
                        }
                    case 3:
                        {
                            string surname = ReadText("прізвище");
                            users = Finder.FindForSurname(c.users, surname);
                            break;
                        }
                    case 4:
                        {
                            string lastname = ReadText("по-батькові");
                            users = Finder.FindForLastname(c.users,lastname);
                            break;
                        }
                    case 5:
                        {
                            int age = ReadNumber();
                            users = Finder.FindForAge(c.users, age);
                            break;
                        }
                    case 6:
                        {
                            byte state;
                            do
                            {
                               state = byte.Parse(ReadNumber(" (0. Чоловік, 1.Жінка)").ToString());
                            } while (state != 0 && state != 1);
                            users = Finder.FindForState(c.users,state);
                            break;
                        }
                    case 7:
                        {
                            string numer = ReadText("номер");
                            users = Finder.FindForTelNumer(c.users, numer);
                            break;
                        }
                    case 8:
                        {
                            int footSize = ReadNumber();
                            users = Finder.FindForFootSize(c.users, footSize);
                            break;
                        }
                    case 9:
                        {
                            int weight = ReadNumber();
                            users = Finder.FindForWeight(c.users, weight);
                            break;
                        }

                    case 10: { Console.SetCursorPosition(57, 12); Console.WriteLine("Кінець"); Console.SetCursorPosition(0, 20); return; }
                }

                ConsoleKeyInfo key = new ConsoleKeyInfo();
                int count = 0;
                while (key.Key != ConsoleKey.Enter) 
                {
                    Console.Clear();
                    foreach (var us in users.Skip(count).Take(3)) 
                {
                    string state;
                    if (us.state == 0)
                    {
                        state = "Чоловік";
                    }
                    else 
                    {
                        state = "Жінка";
                    }
                    Console.WriteLine("\t\t----------------------------");
                    Console.WriteLine($"\t\tНомер: {us.id}; Ім'я: {us.name}; \n\t\tПрізвище: {us.surname}; По-батькові {us.lastname}; " +
                        $"\n\t\tВік: {us.age}; Стать: {state}; Телефон: {us.telNumer}; \n\t\tРозмір ноги: {us.footSize}; Вага: {us.weigth} ");
                    Console.WriteLine("\t\t----------------------------");

                }

                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    for (int i = 0; i < 3; i++) 
                    {
                    Console.SetCursorPosition(10+i,1);
                    Console.WriteLine("В");
                    Console.SetCursorPosition(10+i, 2);
                    Console.WriteLine("е");
                    Console.SetCursorPosition(10+i, 3);
                    Console.WriteLine("р");
                    Console.SetCursorPosition(10+i, 4);
                    Console.WriteLine("х");
                    Console.SetCursorPosition(10+i, 6);
                    Console.WriteLine("@");
                    Console.SetCursorPosition(10+i, 7);
                    Console.WriteLine("@"); 
                    Console.SetCursorPosition(10+i, 8);
                    Console.WriteLine("@");
                    Console.SetCursorPosition(10+i, 10);
                    Console.WriteLine("В");
                    Console.SetCursorPosition(10+i, 11);
                    Console.WriteLine("н");
                    Console.SetCursorPosition(10+i, 12);
                    Console.WriteLine("и");
                    Console.SetCursorPosition(10+i, 13);
                    Console.WriteLine("з");
                    }
                    Console.BackgroundColor = ConsoleColor.Black;


                    key = Console.ReadKey();

                    switch (key.Key) 
                    {
                        case ConsoleKey.DownArrow: 
                            {
                                if (count + 3 < users.Count()) 
                                {
                                    count += 3;
                                } 
                                break; }
                        case ConsoleKey.UpArrow: 
                            {
                                if (count > 0) 
                                {
                                    count -= 3;
                                }
                                break; 
                            }
                    }
                }

                Console.ReadKey();

            }
        }
        /// <summary>
        ///     Очищує головне меню
        /// </summary>
        public static void Clear() 
        {
            for (int y = 1; y <= 9; y++) 
            {
               for (int i = 0; i < 30; i++) 
               {
                    Console.SetCursorPosition(i,y);
                    Console.WriteLine(" ");
               }
            }

            Console.SetCursorPosition(0, 1);
        }
        /// <summary>
        ///     Перевіряє чи коректно введені дані
        /// </summary>
        /// <param name="str">Приймає строку коли це потрібно</param>
        /// <returns>Повертає число</returns>
        public static int ReadNumber(string str = null) 
        {
            int num = 0;
            while (true) 
            {
                ClearSearchBox();
                Console.SetCursorPosition(26, 12);
                Console.Write($"Ведіть число{str}: ");
                string number = Console.ReadLine();
                if (string.IsNullOrEmpty(number)) 
                {
                    return -1;
                }

                try
                {
                    num = int.Parse(number);
                    
                    return num;

                } catch { }
            }


        }
        /// <summary>
        ///     Очищує поле для пошуку
        /// </summary>
        public static void ClearSearchBox() 
        {
            for (int i = 26; i < 95; i++) 
            {
                Console.SetCursorPosition(i, 12);
                Console.WriteLine(" ");
            }
        }
        /// <summary>
        ///     Малює рамки
        /// </summary>
        public static void ReadBorders() 
        {
            Console.BackgroundColor = ConsoleColor.Red;
            for (int i =0; i < 5; i++) 
            {
                Console.SetCursorPosition(25, 10+i);
                Console.WriteLine("@");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(95, 10 + i);
                Console.WriteLine("@");
            }

            for (int i = 0; i < 70; i++)
            {
                Console.SetCursorPosition(25 + i, 10);
                Console.WriteLine("@");
            }

            for (int i = 0; i < 70; i++)
            {
                Console.SetCursorPosition(25 + i, 14);
                Console.WriteLine("@");
            }
            Console.BackgroundColor = ConsoleColor.Black;

        }
        /// <summary>
        /// Зчитує текст
        /// </summary>
        /// <param name="str">Приймає строку яку вставляє у вивідну строку для кращого змісту запросу</param>
        /// <returns>Повертає строку</returns>
        public static string ReadText(string str) 
        {
            string text = "";
            ClearSearchBox();
            Console.SetCursorPosition(26,12);
            Console.Write($"Ведіть {str}: ");
            text = Console.ReadLine();
            return text;
        }
    }
}
