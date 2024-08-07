namespace FindLargestNumin2DArray;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of rows: ") ;
        int rows = int.Parse(Console.ReadLine()) ;
        Console.Write("Enter the number of columns: ") ;
        int cols =  int.Parse(Console.ReadLine());
        double[,] matrix = new double[rows, cols];
        Console.WriteLine("Enter the elements of the matrix:") ;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Enter element at position ({i}, {j}): ") ;
                matrix[i, j] = double.Parse(Console.ReadLine()) ;
            }
        }
        Console.WriteLine("Entered matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        double maxValue = matrix[0, 0] ;
        int maxRow = 0, maxCol = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] > maxValue)
                {
                    maxValue = matrix[i, j];
                    maxRow = i;
                    maxCol = j;
                }
            }
        }
        Console.WriteLine($"The largest element is {maxValue} at position ({maxRow}, {maxCol})");
    }
}

