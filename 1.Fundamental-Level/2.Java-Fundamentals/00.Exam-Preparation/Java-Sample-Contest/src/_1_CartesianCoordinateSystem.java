import java.util.Scanner;

public class _1_CartesianCoordinateSystem {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double coordinateX = scanner.nextDouble();
        double coordinateY = scanner.nextDouble();

        if(coordinateX == 0 && coordinateY == 0) {
            System.out.println(0);
        } else if(coordinateX == 0) {
            System.out.println(5);
        } else if(coordinateY == 0) {
            System.out.println(6);
        } else if(coordinateX > 0 && coordinateY > 0) {
            System.out.println(1);
        } else if(coordinateX < 0 && coordinateY > 0) {
            System.out.println(2);
        } else if(coordinateX < 0 && coordinateY < 0) {
            System.out.println(3);
        } else if(coordinateX > 0 && coordinateY < 0) {
            System.out.println(4);
        }
    }
}
