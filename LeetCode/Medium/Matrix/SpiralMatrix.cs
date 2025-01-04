namespace LeetCode.Medium.Matrix;

public class SpiralMatrix
{
    public static IList<int> Execute(int[][] matrix)
    {
        var result = new List<int>();

        var rows = matrix.Length;
        var columns = matrix[0].Length;
        
        var currentRow = 0;
        var currentColumn = 0;
        var maxColumn = matrix[0].Length-1;
        var maxRow = matrix.Length-1;
        var minColumn = 0;
        var minRow = 0;

        var desired = rows * columns;
        
        while (true)
        {
            if (result.Count >= desired)
                break;
            
            GoForward(result, matrix, currentRow, currentColumn, maxColumn);
            currentColumn = maxColumn;
            maxColumn--;
            currentRow++;
            minRow++;
            
            if (result.Count >= desired)
                break;
            
            GoDown(result, matrix, currentRow, currentColumn, maxRow);
            currentRow = maxRow;
            maxRow--;
            
            if (result.Count >= desired)
                break;
            
            GoBackward(result, matrix, currentRow, currentColumn, minColumn);
            currentColumn = minColumn;
            currentRow--;
            minColumn++;
            
            if (result.Count >= desired)
                break;
            
            GoUp(result, matrix, currentRow, currentColumn, minRow);
            currentRow = minRow;
            currentColumn++;
        }
        
        return result;
    }

    private static void GoForward(IList<int> result, int[][] matrix, int currentRow, int startingColumn, int maximumColumnNumber)
    {
        for (int i = startingColumn; i <= maximumColumnNumber; i++)
            result.Add(matrix[currentRow][i]);
    }

    private static void GoBackward(IList<int> result, int[][] matrix, int currentRow, int startingColumn, int minimumColumnNumber)
    {
        for (int i = startingColumn; i >= minimumColumnNumber; i--)
            result.Add(matrix[currentRow][i]);
    }

    private static void GoUp(IList<int> result, int[][] matrix, int startingRow, int startingColumn, int minimumRowNumber)
    {
        for (int i = startingRow; i >= minimumRowNumber; i--)
            result.Add(matrix[i][startingColumn]);
    }

    private static void GoDown(IList<int> result, int[][] matrix, int startingRow, int startingColumn, int maximumRowNumber)
    {
        for (int i = startingRow; i < maximumRowNumber; i++)
            result.Add(matrix[i][startingColumn]);
    }
}