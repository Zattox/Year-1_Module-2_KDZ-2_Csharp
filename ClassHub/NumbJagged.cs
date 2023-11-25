public class NumbJagged
{
    const int minElement = 0, maxElement = 5;
    int[][] jagArr;
    public NumbJagged(int N)
    {
        if (N < 0)
            throw new ArgumentOutOfRangeException("Количество строк в ступенчатом массиве не может быть меньше 0");

        Random rnd = new Random();
        jagArr = new int[N][];

        for (int i = 0; i < N; ++i)
        {
            int element = rnd.Next(minElement, maxElement);
            while (element != 0)
            {
                jagArr[i].Append(element);
                element = rnd.Next(minElement, maxElement);
            }
            jagArr[i].Append(element);
        }
    }

    static public string[] StringOut(int[][] arr)
    {
        string[] outArr = new string[arr.GetLength(0)];
        for (int i = 0; i < outArr.Length; ++i)
        {
            string str = String.Empty;
            for (int j = 0; j < arr[i].Length; ++j)
            {
                str += arr[i][j].ToString();
                str += " ";
            }
            outArr[i] = str;
        }
        return outArr;
    }

    static public int[] MinSquareNumb(int[][] arr, int numOfRow)
    {
        numOfRow -= 1;
        if (numOfRow < 0)
            throw new ArgumentOutOfRangeException("Номер строки не может быть отрицательным");
        if (numOfRow >= arr.GetLength(0))
            throw new ArgumentOutOfRangeException("Номер строки больше количества строк в массиве");

        string strRow = NumbJagged.StringOut(arr)[numOfRow];
        return new int[0];

    }
}