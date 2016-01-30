namespace _01.InstructionSet
{
    using System;
    using System.Numerics;

    public class InstructionSet
    {
        public static void Main()
        {
            string line = Console.ReadLine();

            while (line != "END")
            {
                string[] codeArgs = line.Split(' ');

                BigInteger result = 0;
                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = operandOne + 1;
                            break;
                        }

                    case "DEC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = operandOne - 1;
                            break;
                        }

                    case "ADD":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = operandOne + operandTwo;
                            break;
                        }

                    case "MLA":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = operandOne * operandTwo;
                            break;
                        }

                    default:
                        {
                            throw new InvalidOperationException("Unknown command.");
                        }
                }

                Console.WriteLine(result);

                line = Console.ReadLine();
            }
        }
    }
}
