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
        Console.WriteLine("Здравствуйте!");
        while (true)
        {
            try
            {
                Methods.InputN(out int N);
                NumbJagged arr = new NumbJagged(N);

                Console.WriteLine("Введите названия файла куда хотите сохранить данные");
                string outPath = Methods.GetPath(Methods.GetName()); 
                Methods.PrintOfArrayInfo(arr.jagArr, outPath);
                Console.WriteLine("Данные успешно сохранены!");
                Console.WriteLine("Если не хотите повторять решение нажмите на ESC");
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Программа завершена. Спасибо!");
                    break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Тип ошибки: " + ex.GetType);
                Console.WriteLine("Сообщение ошибки: " + ex.Message);

                Console.WriteLine("Хотите попробовать еще раз?");
                Console.WriteLine("1. Да");
                Console.WriteLine("2. Нет");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        continue;
                    case ConsoleKey.D2:
                        Console.WriteLine("Программа завершена. Спасибо!");
                        return;
                }
            }
        }
    }
}