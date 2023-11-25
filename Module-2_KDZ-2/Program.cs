/*
  Студент:     Тепляков Владислав Витальевич  
  Группа:      БПИ2310-2
  Задача:      Контрольное домашнее задание 2, модуль 2
  Вариант:     12
*/
using System.Reflection;

internal class Program
{
    //  Точка запуска.
    static void Main()
    {
        while (true)
        {
            Console.Write("Введите N (Число строк зубчатого массива): ");
            int N = int.Parse(Console.ReadLine());
            NumbJagged x = new NumbJagged(N);
            Methods.PrintOfArray(x.jagArr);
        }
    }
}