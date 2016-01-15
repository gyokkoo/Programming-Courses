namespace Methods
{
    using System;

    public static class Formatting
    {
        public static string NumberAsString(int number)
        {
            switch (number)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    throw new ArgumentOutOfRangeException(nameof(number), "The number must be between zero and nine.");
            }
        }

        public static string FormatNumber(object number, string format)
        {
            switch (format)
            {
                case "f":
                    return string.Format("{0:f2}", number);
                case "%":
                    return string.Format("{0:p0}", number);
                case "r":
                    return string.Format("{0,8}", number);
                default:
                    throw new ArgumentException("Wrong format string.", nameof(format));
            }
        }
    }
}
