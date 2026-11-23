using System;

namespace HabitCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            bool running = true;

            while (running)
            {
                PrintMenu();
                Console.Write("Выберите пункт меню (0 - выход): ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // TODO: Студент 1: Добавить вызов функции CalculateSteps()
                        Console.WriteLine("Функция подсчёта шагов пока не реализована.");
                        break;
                    case "2":
                        // TODO: Студент 2: Добавить вызов функции CalculateWater()
                        Console.WriteLine("Функция подсчёта воды пока не реализована.");
                        break;
                    case "3":
                        // TODO: Студент 3: Добавить вызов функции CalculatePages()
                        Console.WriteLine("Функция прочитанных страниц пока не реализована.");
                        break;
                    case "4":
                        // TODO: Студент 4: Добавить вызов функции CalculateCalories()
                        Console.WriteLine("Функция подсчёта калорий пока не реализована.");
                        break;
                    case "5":
                        // TODO: Студент 5: Добавить вызов функции CalculateMeditation()
                        Console.WriteLine("Функция минут медитации пока не реализована.");
                        break;
                    case "6":
                        // TODO: Студент 6: Добавить вызов функции CalculateSquats()
                        Console.WriteLine("Функция приседаний пока не реализована.");
                        break;
                    case "7":
                        // TODO: Студент 7: Добавить вызов функции CalculateWorkoutCalories()
                        Console.WriteLine("Функция калорий тренировки пока не реализована.");
                        break;
                    case "8":
                        // TODO: Студент 8: Добавить вызов функции CalculateSleep()
                        Console.WriteLine("Функция качества сна пока не реализована.");
                        break;
                    case "9":
                        // TODO: Студент 9: Добавить вызов функции CalculateBMI()
                        Console.WriteLine("Функция калькулятора ИМТ пока не реализована.");
                        break;
                    case "10":
                        // TODO: Студент 10: Добавить вызов функции CalculateHeartRate()
                        Console.WriteLine("Функция пульса и зон пока не реализована.");
                        break;
                    case "11":
                        // TODO: Студент 11: Добавить вызов функции CalculateMacros()
                        Console.WriteLine("Функция баланса БЖУ пока не реализована.");
                        break;
                    case "12":
                        // TODO: Студент 12: Добавить вызов функции CalculateScreenTime()
                        Console.WriteLine("Функция времени за экраном пока не реализована.");
                        break;
                    case "13":
                        // TODO: Студент 13: Добавить вызов функции CalculateFloors()
                        Console.WriteLine("Функция пройденных этажей пока не реализована.");
                        break;
                    case "14":
                        // TODO: Студент 14: Добавить вызов функции CalculateStretch()
                        Console.WriteLine("Функция растяжки и разминки пока не реализована.");
                        break;
                    case "15":
                        // TODO: Студент 15: Добавить вызов функции CalculateMood()
                        Console.WriteLine("Функция уровня настроения пока не реализована.");
                        break;
                    case "0":
                        running = false;
                        Console.WriteLine("До свидания!");
                        break;
                    default:
                        Console.WriteLine("Неверный пункт меню. Попробуйте снова.");
                        break;
                }

                if (running)
                {
                    Console.WriteLine();
                    Console.WriteLine("Нажмите Enter, чтобы вернуться в меню...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        static void PrintMenu()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("   КАЛЬКУЛЯТОР ПОЛЕЗНЫХ ПРИВЫЧЕК");
            Console.WriteLine("============================================");
            Console.WriteLine(" 1. Подсчёт шагов");
            Console.WriteLine(" 2. Подсчёт выпитой воды");
            Console.WriteLine(" 3. Прочитанные страницы");
            Console.WriteLine(" 4. Подсчёт калорий в блюде");
            Console.WriteLine(" 5. Минуты медитации");
            Console.WriteLine(" 6. Приседания");
            Console.WriteLine(" 7. Калории тренировки");
            Console.WriteLine(" 8. Качество сна");
            Console.WriteLine(" 9. Калькулятор ИМТ");
            Console.WriteLine("10. Пульс и зоны");
            Console.WriteLine("11. Баланс БЖУ");
            Console.WriteLine("12. Время за экраном");
            Console.WriteLine("13. Пройденные этажи");
            Console.WriteLine("14. Растяжка и разминка");
            Console.WriteLine("15. Уровень настроения");
            Console.WriteLine(" 0. Выход");
            Console.WriteLine("============================================");
        }

        // ============================================================
        // МЕТОДЫ СТУДЕНТОВ (ДОБАВЛЯЙТЕ СВОЙ МЕТОД ЗДЕСЬ)
        // ============================================================
        //
        // СТУДЕНТ 1: Добавьте сюда метод CalculateSteps()
        //
        // СТУДЕНТ 2: Добавьте сюда метод CalculateWater()
        //
        // СТУДЕНТ 3: Добавьте сюда метод CalculatePages()
        //
        // СТУДЕНТ 4: Добавьте сюда метод CalculateCalories()
        //
        // СТУДЕНТ 5: Добавьте сюда метод CalculateMeditation()
        //
        // СТУДЕНТ 6: Добавьте сюда метод CalculateSquats()
        //
        // СТУДЕНТ 7: Добавьте сюда метод CalculateWorkoutCalories()
        //
        // СТУДЕНТ 8: Добавьте сюда метод CalculateSleep()
        //
        // СТУДЕНТ 9: Добавьте сюда метод CalculateBMI()
        //
        // СТУДЕНТ 10: Добавьте сюда метод CalculateHeartRate()
        //
        // СТУДЕНТ 11: Добавьте сюда метод CalculateMacros()
        //
        // СТУДЕНТ 12: Добавьте сюда метод CalculateScreenTime()
        //
        // СТУДЕНТ 13: Добавьте сюда метод CalculateFloors()
        //
        // СТУДЕНТ 14: Добавьте сюда метод CalculateStretch()
        //
        // СТУДЕНТ 15: Добавьте сюда метод CalculateMood()
        //
        // ============================================================
    }
}