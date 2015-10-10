using System;
using System.Security;
using System.Text;

class TextGravity
{
    static void Main()
    {
        int totalColls = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        int rows = text.Length/totalColls;
        if (text.Length%totalColls != 0)
        {
            rows++;
        }

        char[,] matrix = new char[rows, totalColls];

        FillMatrix(matrix, text);

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            RunGravity(matrix, col);
        }

        StringBuilder output = new StringBuilder();

        string result = GetOutputString(output, matrix);

        Console.WriteLine(result);

    }

    private static string GetOutputString(StringBuilder output, char[,] matrix)
    {
        output.Append("<table>");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            output.Append("<tr>");
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                output.AppendFormat("<td>{0}</td>",
                    SecurityElement.Escape(matrix[row, col].ToString()));
            }
            output.Append("</tr>");
        }
        output.Append("</table>");
        return output.ToString();
    }

    private static void FillMatrix(char[,] matrix, string text)
    {
        int currentCharIndex = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (currentCharIndex < text.Length)
                {
                    matrix[row, col] = text[currentCharIndex];
                    currentCharIndex++;
                }
                else
                {
                    matrix[row, col] = ' ';
                }
            }
        }
    }

    private static void RunGravity(char[,] matrix, int col)
    {
        while (true)
        {
            bool hasFallen = false;
            for (int row = 1; row < matrix.GetLength(0); row++)
            {
                char topChar = matrix[row - 1, col];
                char currentChar = matrix[row, col];
                if (currentChar == ' ' && topChar != ' ')
                {
                    matrix[row, col] = topChar;
                    matrix[row - 1, col] = ' ';
                    hasFallen = true;
                }
            }

            if (!hasFallen)
            {
                break;
            }
        }
    }
}
