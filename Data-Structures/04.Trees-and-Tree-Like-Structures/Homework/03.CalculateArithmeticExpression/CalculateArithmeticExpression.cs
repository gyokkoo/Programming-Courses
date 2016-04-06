namespace _03.CalculateArithmeticExpression
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CalculateArithmeticExpression
    {
        public static void Main()
        {
            try
            {
                var result = CalculateExpression(Console.ReadLine());
                Console.WriteLine(result);
            }
            catch (Exception)
            {
                Console.WriteLine("error");
            }
        }

        private static double CalculateExpression(string expression)
        {
            var values = new Stack<double>();
            var operators = new Stack<char>();

            for (int i = 0; i < expression.Length; i++)
            {
                var token = expression[i];
                if (token == ' ')
                {
                    continue;
                }

                if ('0' <= token && token <= '9')
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(token);

                    while (i + 1 < expression.Length && (('0' <= expression[i + 1] && expression[i + 1] <= '9') || expression[i + 1] == '.'))
                    {
                        sb.Append(expression[i + 1]);
                        i++;
                    }

                    values.Push(double.Parse(sb.ToString()));
                }
                else if (token == '(')
                {
                    operators.Push(token);
                }
                else if (token == ')')
                {
                    while (operators.Peek() != '(')
                    {
                        var result = GetCalculation(operators.Pop(), values.Pop(), values.Pop());
                        values.Push(result);
                    }

                    operators.Pop();
                }
                else if (token == '+' || token == '-' || token == '*' || token == '/')
                {
                    while (operators.Count > 0 && HasPrecedence(token, operators.Peek()))
                    {
                        var result = GetCalculation(operators.Pop(), values.Pop(), values.Pop());
                        values.Push(result);
                    }

                    operators.Push(token);
                }
            }

            while (operators.Count > 0)
            {
                var result = GetCalculation(operators.Pop(), values.Pop(), values.Pop());
                values.Push(result);
            }

            return values.Pop();
        }

        private static bool HasPrecedence(char operatorA, char operatorB)
        {
            if (operatorB == '(' || operatorB == ')')
            {
                return false;
            }

            if ((operatorA == '*' || operatorA == '/') && (operatorB == '+' || operatorB == '-'))
            {
                return false;
            }

            return true;
        }

        private static double GetCalculation(char @operator, double b, double a)
        {
            switch (@operator)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    if (b == 0)
                    {
                        throw new DivideByZeroException();
                    }

                    return a / b;
                default:
                    return 0;
            }
        }
    }
}