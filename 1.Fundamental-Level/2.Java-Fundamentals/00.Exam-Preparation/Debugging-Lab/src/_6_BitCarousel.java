import java.util.Scanner;

public class _6_BitCarousel {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        int number = Integer.parseInt(input.nextLine());
        int rotations = Integer.parseInt(input.nextLine());

        for (int i = 0; i < rotations; i++) {
            String direction = input.nextLine();
            if (direction.equals("right")) {
                int rightMostBit = number & 1;
                number = number >> 1;
                number = number | (rightMostBit << 5);
            } else if (direction.equals("left")) {
                int leftMostBit = (number >> 5) & 1;
                number = number << 1;
                number = number & (~(1 << 6));
                number = number | leftMostBit;
            }
        }
        System.out.println(number);
    }
}
