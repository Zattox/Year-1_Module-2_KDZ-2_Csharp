/*
  Студент:     Тепляков Владислав Витальевич  
  Группа:      БПИ2310-2
  Задача:      Контрольное домашнее задание 2, модуль 2
  Вариант:     12
*/
internal class Program
{
    //  Точка запуска.
    static void Main()
    {
        Methods.PrintWithColor("Здравствуйте!", ConsoleColor.White);
        while (true)
        {
            try
            {
                //Получение входных данных и построение зубчатого массива по ним.
                Methods.PrintWithColor("Файл с входными данными должен иметь ровно 1 число", ConsoleColor.Yellow);
                string inputPath = Methods.GetInputPath();
                Methods.InputN(out int N, inputPath);
                NumbJagged arr = new NumbJagged(N);

                //Вывод в файл нужных данных по ТЗ.
                Methods.PrintOfArrayInfo(arr.jagArr);

                //Сохранение данных.
                Methods.PrintWithColor("Хотите сохранить данные?", ConsoleColor.Yellow);
                Methods.PrintWithColor("1. Да", ConsoleColor.Green);
                Methods.PrintWithColor("2. Нет", ConsoleColor.Red);
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Methods.PrintOfArrayInfo(arr.jagArr, Methods.GetOutputPath(inputPath));
                        Methods.PrintWithColor("Данные успешно сохранены!", ConsoleColor.Green);
                        break;
                    case ConsoleKey.D2:
                        Methods.PrintWithColor("Данные будут утеряны", ConsoleColor.Yellow);
                        break;
                }

                //Повтор решения.
                Methods.PrintWithColor("Если не хотите повторять решение нажмите на ESC", ConsoleColor.Yellow);
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    Methods.PrintWithColor("Программа завершена. Спасибо!", ConsoleColor.Green);
                    break;
                }
                Console.Clear();
            }
            catch (Exception ex)
            {
                //Общая обработка всех исключений.
                Methods.PrintWithColor("Тип ошибки: " + ex.GetType, ConsoleColor.Red);
                Methods.PrintWithColor("Сообщение ошибки: " + ex.Message, ConsoleColor.Yellow);

                Console.WriteLine("Хотите попробовать еще раз?");
                Console.WriteLine("1. Да");
                Console.WriteLine("2. Нет");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        continue;
                    case ConsoleKey.D2:
                        Methods.PrintWithColor("Программа завершена. Спасибо!", ConsoleColor.Green);
                        return;
                }
            }
        }
    }
}