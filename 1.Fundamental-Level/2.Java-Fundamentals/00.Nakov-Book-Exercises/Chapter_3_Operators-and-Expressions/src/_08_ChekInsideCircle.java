import java.util.Scanner;

public class _08_ChekInsideCircle {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter X and Y coordinates of a point.");
        int coordinateX = scanner.nextInt();
        int coordinateY = scanner.nextInt();

        boolean IsInsideCircle = coordinateX * coordinateX + coordinateY
                * coordinateY <= 25;
        System.out.println("Is the point inside the circle ? -> " + IsInsideCircle);
    }
}