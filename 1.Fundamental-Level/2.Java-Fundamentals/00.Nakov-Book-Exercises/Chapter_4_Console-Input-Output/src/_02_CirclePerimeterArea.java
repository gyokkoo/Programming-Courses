import java.util.Scanner;

public class _02_CirclePerimeterArea {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter the radius of a circle.");
        double radius = scanner.nextDouble();

        double perimeter = 2 * radius * Math.PI;
        double area = Math.PI * Math.pow(radius, 2);

        System.out.printf("The circle perimeter is: %.2f \n", perimeter);
        System.out.printf("The circle area is: %.2f", area);
    }
}
