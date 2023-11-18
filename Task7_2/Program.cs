// напишите методы CreateIncreasingMatrix, PrintArray, FindNumberByPosition и
// PrintCheckIfError.
// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности,
// с каждым новым элементом увеличивающимся на определенное число. Метод принимает
// на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы,
// k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу,
// удовлетворяющую этим условиям.
// Метод PrintArray должен выводить на экран сгенерированную методом
// CreateIncreasingMatrix матрицу. Элементы матрицы должны быть выведены через символ
// табуляции для более читаемого вывода.
// Метод FindNumberByPosition принимает на вход сгенерированную матрицу и числа x и y -
// позиции элемента в матрице. Если указанные координаты находятся за пределами границ
// массива, метод должен вернуть массив с нулевым значением. Если координаты находятся
// в пределах границ, метод должен вернуть массив с двумя значениями: значением числа в
// указанной позиции, а второй элемент должен быть равен 0, чтобы показать, что операция
// прошла успешно без ошибок.
// Метод PrintCheckIfError должен принимать результат метода FindNumberByPosition и числа
// x и y - позиции элемента в матрице. Метод должен проверить, был ли найден элемент
// в матрице по указанным координатам (x и y), используя результаты из метода
// FindNumberByPosition. Если такого элемента нет, вывести на экран
// "There is no such index". Если элемент есть, вывести на экран
// "The number in [{x}, {y}] is {значение}"


int InputIntNumber(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateIncreasingMatrix(int m, int n, int k)
{
    int[,] matrix = new int[m, n];
    //matrix[0,0] = 1;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i,j] = matrix[0,0] + k * (i * m + j);
            Console.Write(i);
            Console.Write(j);
            Console.Write(matrix[i,j]);
            Console.WriteLine();
        }
    }
    return matrix;
}

void PrintMatrix(int[,] printmatrix)
{
    for (int i = 0; i < printmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < printmatrix.GetLength(1); j++)
        {
            System.Console.Write($"{printmatrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}


int m = InputIntNumber("Введите кол-во строк массива: ");
Console.WriteLine();
int n = InputIntNumber("Введите кол-во столбцов массива: ");
Console.WriteLine();
int k = InputIntNumber("Введите инкремен: ");
Console.WriteLine();

PrintMatrix(CreateIncreasingMatrix(m, n, k));

Console.WriteLine("Hello, World!");
