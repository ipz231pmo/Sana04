namespace MatrixLibrary
{
    public class Matrix
    {
        public static int[,] GenerateMatrix(int rows, int columns, int minElement = -100, int maxElement = 100)
        {
            Random rnd = new Random();
            int[,] matrix = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = rnd.Next(minElement, maxElement);
                }
            }
            return matrix;
        }
        public static void PrintMatrix(int[,] matrix)
        {
            Console.WriteLine("Matrix");
            for(int i = 0;i < matrix.GetLength(0); i++) { 
                for(int j = 0;j < matrix.GetLength(1);j++)
                {
                    Console.Write($"{matrix[i,j]}\t");
                }
                Console.WriteLine();
            }
        }
        public static int PositiveElementsCount(int[,] matrix)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0) count++;
                }
            }
            return count;
        }
        public static int NonZeroRows(int[,] matrix)
        {
            int num = 0;
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                bool flag = true;
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0) flag = false;
                }
                if(flag) num++;
            }
            return num;
        }
        public static int ZeroColumns(int[,] matrix)
        {
            int num = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                bool flag = false;
                for(int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] == 0) flag = true;
                }
                if(flag) num++;
            }
            return num;
        }
        public static int[,] TransMatrix(int[,] matrix)
        {
            int[,] tMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++) 
            {
                for(int j = 0;j < matrix.GetLength(1); j++)
                {
                    tMatrix[j, i] = matrix[i,j];
                }
            }
            return tMatrix;
        }

        public static int NegativeColumns(int[,] matrix)
        {
            int count = 0;
            for(int j = 0; j < matrix.GetLength(1); j++) 
            {
                bool flag = false;
                for(int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] < 0) { flag = true; break; }                    
                }
                if(flag) count++;
            }
            return count;
        }
        public static int[] NegativeColumnsIndexes(int[,] matrix)
        {
            int[] indexes = new int[NegativeColumns(matrix)];
            int k = 0;
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                bool flag = false;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] < 0) 
                    {
                        flag = true;
                        break;
                    }                
                }
                if(flag) indexes[k++] = j;
            }
            return indexes;
        }
        public static int[] SumNegativeColumns(int[,] matrix)
        {
            int[] sums = new int[NegativeColumns(matrix)];
            int k = 0;
            foreach(int j in NegativeColumnsIndexes(matrix))
            {
                sums[k] = 0;
                for(int i = 0; i < matrix.GetLength(0); i++)
                {
                    sums[k] += matrix[i, j];
                }
                k++;
            }
            return sums;
        }

        public static int NoNegativeColumns(int[,] matrix)
        {
            int count = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                bool flag = true;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] < 0) { flag = false; break; }
                }
                if (flag) count++;
            }
            return count;
        }
        public static int[] NoNegativeColumnsIndexes(int[,] matrix)
        {
            int[] indexes = new int[NoNegativeColumns(matrix)];
            int k = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                bool flag = true;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] < 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag) indexes[k++] = j; 
            }
            return indexes;
        }
        public static int[] SumNoNegativeColumns(int[,] matrix)
        {
            int[] sums = new int[NoNegativeColumns(matrix)];
            int k = 0;
            foreach (int j in NoNegativeColumnsIndexes(matrix))
            {
                sums[k] = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    sums[k] += matrix[i, j];
                }
                k++;
            }
            return sums;
        }

        public static int NoNegativeRows(int[,] matrix)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                bool flag = true;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0) { flag = false; break; }
                }
                if (flag) count++;
            }
            return count;
        }
        public static int[] NoNegativeRowsIndexes(int[,] matrix)
        {
            int[] indexes = new int[NoNegativeRows(matrix)];
            int k = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                bool flag = true;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag) indexes[k++] = i;
            }
            return indexes;
        }
        public static int[] ProductNoNegativeRows(int[,] matrix)
        {
            int[] prods = new int[NoNegativeRows(matrix)];
            int k = 0;
            foreach (int i in NoNegativeRowsIndexes(matrix))
            {
                prods[k] = 1;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    prods[k] *= matrix[i, j];
                }
                k++;
            }
            return prods;
        }
    
        public static bool Find(int[,] matrix, int element)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++) 
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == element) count++;
                }
            }
            return count > 1;
        }
        public static int MaxRepeatedElement(int[,] matrix)
        {
            int maxElement = -101;
            for (int i = 0; i < matrix.GetLength(0); i++) 
            { 
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(Find(matrix, matrix[i, j]) && matrix[i, j] > maxElement) maxElement = matrix[i, j];
                }
            }
            return maxElement;

        }

        public static int DiagonalsSum(int[,] matrix)
        {
            int sum = int.MinValue;
            for (int i = 1; i < matrix.GetLength(0); i++) 
            {
                int tmp_sum = 0;
                for(int j =  0, k = i; j < matrix.GetLength(1) && k < matrix.GetLength(0); j++, k++)
                {
                    tmp_sum += matrix[k, j];
                }
                Console.WriteLine(tmp_sum);
                if(tmp_sum > sum) sum = tmp_sum;
            }
            Console.WriteLine();
            for (int j = 1; j < matrix.GetLength(1); j++) 
            {
                int tmp_sum = 0;
                for (int i = 0, k = j; i < matrix.GetLength(0) && k < matrix.GetLength(1); i++, k++) 
                { 
                    tmp_sum += matrix[i, k];
                }
                Console.WriteLine(tmp_sum);
                if(tmp_sum > sum) sum = tmp_sum;
            }
            Console.WriteLine();
            return sum;
        }
        public static int OtherDiagonals(int[,] matrix) 
        {
            int sum = int.MaxValue;
            for (int k = 0; k < matrix.GetLength(0)-1; k++) 
            {
                int tmp_sum = 0;
                for (int i = k, j = 0; i >= 0 && j < matrix.GetLength(1); i--, j++)
                {
                    tmp_sum += Math.Abs(matrix[i, j]);
                }
                if(tmp_sum < sum) sum = tmp_sum;
                //Console.WriteLine(tmp_sum);
            }
            //Console.WriteLine();
            for (int k = 1; k < matrix.GetLength(1); k++)
            {
                int tmp_sum = 0;
                for (int i = matrix.GetLength(0)-1, j = k; i >= 0 && j < matrix.GetLength(1); i--, j++)
                {
                    tmp_sum += Math.Abs(matrix[i, j]);
                }
                if (tmp_sum < sum) sum = tmp_sum;
                //Console.WriteLine(tmp_sum);
            }
            //Console.WriteLine();
            return sum;
        }

        public static int LongestCommonSubsuqenceRow(int[,] matrix) 
        {
            int rowIndex = 0;
            int maxCount = 0;
            for (int i = 0; i < matrix.GetLength(0); i++) 
            {
                int count = 1;
                for (int j = 1; j < matrix.GetLength(1); j++) 
                {
                    if (matrix[i, j] == matrix[i, j - 1]) count++;
                    else 
                    {
                        if (count > maxCount) { 
                            maxCount = count; 
                            rowIndex = i; 
                        }
                        count = 1;
                    }
                }
            }
            return rowIndex;
        }
    }
}