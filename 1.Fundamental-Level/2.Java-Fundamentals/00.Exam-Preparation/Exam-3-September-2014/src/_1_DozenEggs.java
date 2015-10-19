import java.util.Scanner;

public class _1_DozenEggs {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int totalEggs = 0;
        int totalDozens = 0;
        for (int i = 1; i <= 7; i++) {
            String[] lineArgs = scanner.nextLine().split(" ");
            int count = Integer.parseInt(lineArgs[0]);
            String measure = lineArgs[1];
            if(measure.equals("dozens")) {
                totalDozens += count;
            } else if (measure.equals("eggs")) {
                totalEggs += count;
            }
        }
        totalDozens += totalEggs / 12;
        totalEggs = totalEggs % 12;

        System.out.printf("%d dozens + %d eggs", totalDozens, totalEggs);
    }
}