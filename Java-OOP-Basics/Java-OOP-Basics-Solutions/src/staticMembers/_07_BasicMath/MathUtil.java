package staticMembers._07_BasicMath;

public class MathUtil {
    public static double sum(double firstNumber, double secondNumber) {
        return firstNumber + secondNumber;
    }

    public static double subtract(double firstNumber, double secondNumber) {
        return firstNumber - secondNumber;
    }

    public static double multiply(double firstNumber, double secondNumber) {
        return firstNumber * secondNumber;
    }

    public static double divide(double dividend, double divisor) {
        return dividend / divisor;
    }

    public static double percentage(double totalNumber, double percentOfThatNumber) {
        return totalNumber * percentOfThatNumber / 100;
    }
}
