using System;
using System.IO;
using System.Numerics;

public class Methods
{
    internal static bool ExistenceOfTriangle(int a, int b, int c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
    internal static double SquareOfTriangle(int a, int b, int c)
    {
        int p = (a + b + c) / 2;
        double s = p * (p - a) * (p - b) * (p - c);
        return s;
    }
    public static void PrintOfArrayInfo(int[][] jaggerArr, string nPath)
    {
        StreamWriter sw = new StreamWriter(nPath);

        sw.WriteLine("Зубчатый массив: ");
        string[] ans = NumbJagged.StringOut(jaggerArr);
        for (int i = 0; i < ans.Length; i++)
        {
            sw.WriteLine(ans[i]);
        }

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
    public static string GetName()
    {
        string fileName;
        while (true)
        {
            fileName = Console.ReadLine();
            while(fileName.IndexOfAny(Path.GetInvalidPathChars()) != -1)
            {
                Console.WriteLine("Вы ввели файл с недопустимыми символами. Повторите попытку");
                Console.WriteLine("Введите названия текстового файла с данными: ");
                fileName = Console.ReadLine();
            }
            return fileName;
        }
    }
    public static string GetPath(string fileName)
    {
        string fPath;
        while (true)
        {
            Console.Write($"Введите абсолютный путь до {fileName}: ");
            fPath = Console.ReadLine();
            while (string.IsNullOrEmpty(fPath))
            {
                Console.WriteLine("Файл пустой, повторите попытку");
                Console.Write($"Введите абсолютный путь до {fileName}: ");
                fPath = Console.ReadLine();
            }

            if (File.Exists(fPath) && fPath.IndexOfAny(Path.GetInvalidPathChars()) == -1)
            {
                return fPath;
            }
            Console.WriteLine("Путь некорректный или файла не существует, повторите попытку");
            continue;
        }
    }

    internal static bool CheckFileStructure(string path)
    {
        StreamReader file = new StreamReader(path);
        string line = file.ReadLine();
        if (line != null)
        {
            return int.TryParse(line, out _);
        }
        return false;
    }
    public static void InputN(out int N)
    {
        Console.WriteLine("Введите название текстового файла с ровно одним числом (количество строк зубчатого массива): ");
        string fPath = GetPath(GetName());

        while (!CheckFileStructure(fPath))
        {
            Console.WriteLine("В файл записано не только число, либо число слишком большое, либо вовсе не число.");
            Console.Write("Повторите попытку. Введите другой файл: ");
            fPath = GetPath(GetName());
        }

        StreamReader file = new StreamReader(fPath);
        string line = file.ReadLine();
        N = int.Parse(line);
    }
}
