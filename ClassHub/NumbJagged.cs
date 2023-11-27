public class NumbJagged
{
    private const int minElement = 0, maxElement = 5;
    public int[][] jagArr;
    public NumbJagged()
    {
        jagArr = new int[0][];
    }
    public NumbJagged(int N)
    {
        if (N < 0)
            throw new ArgumentOutOfRangeException("Количество строк в ступенчатом массиве не может быть меньше 0");

        Random rnd = new Random();
        jagArr = new int[N][];

        for (int i = 0; i < N; ++i)
        {
            string str = String.Empty;
            int element = rnd.Next(minElement, maxElement);
            while (element != 0)
            {
                str += element.ToString();
                element = rnd.Next(minElement, maxElement);
            }
            str += element.ToString();
            
            jagArr[i] = new int[str.Length];
            for (int j = 0; j < str.Length; ++j)
            {
                jagArr[i][j] = str[j] - '0';
            }
        }
    }
    internal static string[] StringOut(int[][] arr)
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

    internal static int[] MinSquareNumb(int[][] arr, int numOfRow)
    {
        numOfRow -= 1;
        if (numOfRow < 0)
            throw new ArgumentOutOfRangeException("Номер строки не может быть меньше 1");
        if (numOfRow >= arr.GetLength(0))
            throw new ArgumentOutOfRangeException("Номер строки больше количества строк в массиве");
        if (arr[numOfRow].Length < 3)
            throw new ArgumentException("В выбранной строке меньше трех элементов");

        int n = arr[numOfRow].Length;
        int[] ans = new int[3];
        double squareCur = 0;

        for (int i = 0; i < n; ++i)
        {
            for (int j = i + 1; j < n; ++j)
            {
                for (int g = j + 1; g < n; ++g)
                {
                    if (Methods.ExistenceOfTriangle(arr[numOfRow][i], arr[numOfRow][j], arr[numOfRow][g])){
                        double squareNew = Methods.SquareOfTriangle(arr[numOfRow][i], arr[numOfRow][j], arr[numOfRow][g]);
                        if (squareNew > squareCur)
                        {
                            ans[0] = arr[numOfRow][i];
                            ans[1] = arr[numOfRow][j];
                            ans[2] = arr[numOfRow][g];
                            squareCur = squareNew;
                        }
                    }
                }
            }
        }

        return ans;
    }
}