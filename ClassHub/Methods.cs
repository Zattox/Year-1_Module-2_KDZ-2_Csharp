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
    public static void PrintOfArray(int[][] jaggerArr) {
        Console.WriteLine("Выбранный зубчатый массив: ");
        for (int i = 0; i < jaggerArr.GetLength(0); ++i)
        {
            for (int j = 0; j < jaggerArr[i].Length; ++j) {
                Console.Write($"{jaggerArr[i][j]} ");
            }
            Console.WriteLine();
        }
    }
}

