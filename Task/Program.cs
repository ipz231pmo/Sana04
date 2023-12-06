using MatrixLibrary;

Console.WriteLine("Enter count of rows and cols: ");
int n = int.Parse(Console.ReadLine()), m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter min and max value: ");
int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine());

int[,] matrix = Matrix.GenerateMatrix(n, m, a, b);
Matrix.PrintMatrix(matrix);

Console.WriteLine($"Positive elements count: {Matrix.PositiveElementsCount(matrix)}");
Console.WriteLine($"Max repeated element is {Matrix.MaxRepeatedElement(matrix)}");
Console.WriteLine($"Count of rows without null elements is {Matrix.NonZeroRows(matrix)}");
Console.WriteLine($"Count of columns with null elements is {Matrix.ZeroColumns(matrix)}");
Console.WriteLine($"Number of row with the longest amount of identical elements is {Matrix.LongestCommonSubsuqenceRow(matrix)}");
Console.WriteLine($"Product of rows` elements without negative numbers is ");
foreach (var i in Matrix.ProductNoNegativeRows(matrix)) 
{
    Console.WriteLine(i.ToString());
}
Console.WriteLine($"Max sum of diagonals that are paralel to main diagonal is {Matrix.DiagonalsSum(matrix)}");
Console.WriteLine($"Sums of columns` elements without negative elements:");
foreach ( var i in Matrix.SumNoNegativeColumns(matrix)) 
{
    Console.WriteLine(i.ToString());
}
Console.WriteLine($"Minimum of sum of abs elements of in not main diagonal"); // Other diagonals
foreach (var i in Matrix.SumNegativeColumns(matrix))
{
    Console.WriteLine($"{i}");
}
int[,] tmatrix = Matrix.TransMatrix(matrix);
Console.Write("Transponated ");
Matrix.PrintMatrix(tmatrix);
