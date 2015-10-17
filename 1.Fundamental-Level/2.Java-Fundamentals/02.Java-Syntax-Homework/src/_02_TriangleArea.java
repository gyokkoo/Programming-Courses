import java.util.Scanner;

public class _02_TriangleArea {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter the coordinates X and Y of three points.");
        int aX = scanner.nextInt();
        int aY = scanner.nextInt();
        int bX = scanner.nextInt();
        int bY = scanner.nextInt();
        int cX = scanner.nextInt();
        int cY = scanner.nextInt();

        double triangleArea = Math.abs((aX*(bY - cY) + bX*(cY - aY) + cX*(aY - bY)) / 2);
        //The formula -> http://www.mathopenref.com/coordtrianglearea.html

        System.out.println((int)triangleArea);
    }
}
