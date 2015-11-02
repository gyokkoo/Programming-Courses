import java.util.Scanner;

public class _2_Durts {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int cX = scanner.nextInt();
        int cY = scanner.nextInt();
        int r = scanner.nextInt();
        int n = scanner.nextInt();
        for (int i = 0; i < n; i++) {
            int x = scanner.nextInt();
            int y = scanner.nextInt();

            boolean isInsideVerticalRectangle =
                    x >= (cX - r/2) && x <= (cX + r/2) &&
                    y >= (cY - r) && y <= (cY + r);

            boolean isInsideHorizontalRectangle =
                    x >= (cX - r) && x <= (cX + r) &&
                    y >= (cY - r/2) && y <= (cY + r/2);

            if(isInsideHorizontalRectangle || isInsideVerticalRectangle) {
                System.out.println("yes");
            } else {
                System.out.println("no");
            }

        }

    }
}
