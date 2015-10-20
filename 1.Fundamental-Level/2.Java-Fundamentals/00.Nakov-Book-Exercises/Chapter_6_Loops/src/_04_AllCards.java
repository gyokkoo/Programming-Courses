public class _04_AllCards {

    public static void main(String[] args) {
        for (int color = 1; color <= 4 ; color++) {
            for (int number = 2; number <= 14 ; number++) {
                printType(color);
                printNumber(number);
                System.out.print(" ");
            }
            System.out.println();
        }
    }

    private static void printNumber(int number) {
        switch (number) {
            case 2:
                System.out.print("2");
                break;
            case 3:
                System.out.print("3");
                break;
            case 4:
                System.out.print("4");
                break;
            case 5:
                System.out.print("5");
                break;
            case 6:
                System.out.print("6");
                break;
            case 7:
                System.out.print("7");
                break;
            case 8:
                System.out.print("8");
                break;
            case 9:
                System.out.print("9");
                break;
            case 10:
                System.out.print("10");
                break;
            case 11:
                System.out.print("J");
                break;
            case 12:
                System.out.print("Q");
                break;
            case 13:
                System.out.print("K");
                break;
            case 14:
                System.out.print("A");
                break;
        }
    }

    private static void printType(int color) {
        switch (color) {
            case 1:
                System.out.print("C");
                break;
            case 2:
                System.out.print("D");
                break;
            case 3:
                System.out.print("H");
                break;
            case 4:
                System.out.print("S");
                break;
        }
    }
}
