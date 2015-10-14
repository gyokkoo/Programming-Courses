import java.util.Scanner;

public class _09_ChekInsideCircleOutsideRectangle {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter X and Y coordinates of a point.");
        int coordinateX = scanner.nextInt();
        int coordinateY = scanner.nextInt();

        boolean IsInsideCircle = coordinateX * coordinateX + coordinateY
                * coordinateY <= 25;
        boolean IsOutsideRectangle = (coordinateX >= -1 && coordinateX <= 5)
                && (coordinateY >= 1 && coordinateY <= 5);

        System.out
                .println("Is the point inside the circle and outside rectangle? -> "
                        + (IsInsideCircle & IsOutsideRectangle));
    }
}