package methodsHomework._03_LastDigitName;

public class Number {
    private static String[] digitsName = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
    private Integer number;

    public Number(Integer number) {
        this.number = number;
    }

    public String getLastDigitName() {
        return digitsName[this.number % 10];
    }
}