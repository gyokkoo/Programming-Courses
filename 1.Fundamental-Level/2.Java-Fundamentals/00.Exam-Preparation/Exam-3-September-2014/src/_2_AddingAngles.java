import java.util.Scanner;

public class _2_AddingAngles {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int count = Integer.parseInt(scanner.nextLine());

        int[] numbers = new int[count];
        for (int i = 0; i < numbers.length; i++) {
            numbers[i] = scanner.nextInt();
        }

        Boolean isFound = false;
        for (int i = 0; i < numbers.length; i++) {
            for (int j = i + 1; j < numbers.length; j++) {
                for (int k = j + 1; k < numbers.length; k++) {
                    int sum = numbers[i] + numbers[j] + numbers[k];
                    if(sum % 360 == 0) {
                        System.out.printf("\n%d + %d + %d = %d degrees", numbers[i], numbers[j], numbers[k], sum);
                        isFound = true;
                    }
                }
            }
        }

        if(!isFound) {
            System.out.println("No");
        }
    }
}