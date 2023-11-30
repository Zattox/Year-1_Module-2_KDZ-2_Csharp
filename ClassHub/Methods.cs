using System.Text;

public class Methods
{
    //Проверка существования треугольника при помощи неравенства треугольника.
    internal static bool ExistenceOfTriangle(int a, int b, int c)
    {
        return a + b > c && a + c > b && b + c > a;
    }

    //Подсчет площади треуголька в квадрате во избежания ошибок при сравненнии в double.
    internal static double SquareOfTriangle(int a, int b, int c)
    {
        int p = (a + b + c) / 2;
        double s = p * (p - a) * (p - b) * (p - c);
        return s;
    }

    //Метод, который печает нужные данные по ТЗ.
    public static void PrintOfArrayInfo(int[][] jaggerArr, string nPath = "-")
    {

        StreamWriter sw;
        if (nPath != "-") //Для вывода в файл.
            sw = new StreamWriter(nPath);
        else //Для вывода в консоль.
        {
            sw = new StreamWriter(Console.OpenStandardOutput());
            sw.AutoFlush = true;
            Console.OutputEncoding = Encoding.UTF8;
        }

        //Печатаем сам созданный зубчатый массив.
        sw.WriteLine("Зубчатый массив: ");
        string[] ans = NumbJagged.StringOut(jaggerArr); //Предпологаю, что в условии ошибка и надо вывести созданным методом а не AsString().
        for (int i = 0; i < ans.Length; i++)
        {
            sw.WriteLine(ans[i]);
        }

        //Печатаем информацию о наибольшем трегольнике по площади в строке. 
        for (int i = 0; i < jaggerArr.Length; ++i)
        {
            if (jaggerArr[i].Length >= 3)
            {
                var output = NumbJagged.MinSquareNumb(jaggerArr, i + 1);
                if (ExistenceOfTriangle(output[0], output[1], output[2]))
                {
                    sw.WriteLine($"В строке {i + 1}: треугольник, имеющий наибольшую площадь, имеет следующие длины сторон: {output[0]} {output[1]} {output[2]}");
                }
                else
                {
                    sw.WriteLine($"В строке {i + 1}: невозможно создать треугольник");
                }

            } else
            {
                sw.WriteLine($"В строке {i + 1}: невозможно создать треугольник");
            }
        }
        sw.Close();

    }

    //Метод для печатания с выбранным цветом в консоль.
    public static void PrintWithColor(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message, color);
        Console.ForegroundColor= ConsoleColor.White;
    }

    public static string GetName()
    {
        string fileName;
        while (true)
        {
            fileName = Console.ReadLine();
            int len = fileName.Length;
            while (fileName.IndexOfAny(Path.GetInvalidPathChars()) != -1 || len < 5 || !fileName.EndsWith(".txt"))
            {
                if (fileName.IndexOfAny(Path.GetInvalidPathChars()) != -1)
                    PrintWithColor("Вы ввели файл с недопустимыми символами. Повторите попытку", ConsoleColor.Red);
                if (len < 5)
                    PrintWithColor("Вы ввели файл без названия", ConsoleColor.Red);
                if (!fileName.EndsWith(".txt"))
                    PrintWithColor("Вы ввели файл без расширения .txt", ConsoleColor.Red);
                PrintWithColor("Введите названия текстового файла c расширением: ", ConsoleColor.Blue);
                fileName = Console.ReadLine();
                len = fileName.Length;
            }
            return fileName;
        }
    }

    //Метод, который ищет корректный абсолютный путь до файла с входными данными.
    public static string GetInputPath()
    {
        PrintWithColor($"Введите название файла с входными данными c расширением: ", ConsoleColor.Blue);
        string fPath = GetName();
        while (fPath.IndexOfAny(Path.GetInvalidPathChars()) != -1 || !File.Exists(fPath))
        {
            if (fPath.IndexOfAny(Path.GetInvalidPathChars()) != -1)
                PrintWithColor("Путь содержит недопустимые символы, повторите попытку", ConsoleColor.Red);
            else if (!File.Exists(fPath))
                PrintWithColor("Файл недоступен, повторите попытку", ConsoleColor.Red);

            PrintWithColor($"Введите название файла с входными данными: ", ConsoleColor.Blue);
            fPath = GetName();
        }

        return fPath;
    }

    //Метод, который ищет корректный абсолютный путь до файла с выходными данными.
    public static string GetOutputPath(string inPath) 
    {
        string fPath;
        while (true)
        {
            PrintWithColor($"Введите название файла куда хотите сохранить данные, он должен быть отличен от входного: ", ConsoleColor.Blue);
            fPath = GetName();
            if (fPath == inPath)
            {
                PrintWithColor("Файл должен быть отличен от входного, повторите попытку", ConsoleColor.Red);
                continue;
            }
            if (fPath.IndexOfAny(Path.GetInvalidPathChars()) == -1)
            {
                return fPath;
            }
            PrintWithColor("Путь имеет недопустимые символы, повторите попытку", ConsoleColor.Red);
            continue;
        }
    }

    //Метод, который проверяет структуру файла (в файле дожно быть только одно число).
    internal static bool CheckFileStructure(string path)
    {
        StreamReader file = new StreamReader(path);
        string line = file.ReadLine();
        if (line != null)
        {
            if (int.TryParse(line, out int x))
                return x > 0;
            return false;
        }
        return false;
    }

    //Метод, возращающий корректное значение N из входного файла.
    public static void InputN(out int N, string fPath)
    {
        while (!CheckFileStructure(fPath))
        {
            PrintWithColor("Файл с неправильной структурой или в файле не число. Повторите попытку", ConsoleColor.Red);
            fPath = GetInputPath();
        }

        StreamReader file = new StreamReader(fPath);
        string line = file.ReadLine();
        N = int.Parse(line);
        file.Close();
    }
}
