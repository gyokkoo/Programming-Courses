import java.util.Scanner;

public class _1_VideoDurations {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String line = scanner.nextLine();

        int totalMinutes = 0;
        while(!line.equals("End")) {
            String[] inputArgs = line.split(":");
            int currentHours = Integer.parseInt(inputArgs[0]);
            int currentMinutes = Integer.parseInt(inputArgs[1]);
            totalMinutes += currentHours * 60 + currentMinutes;

            line = scanner.nextLine();
        }

        System.out.printf("%d:%02d", totalMinutes / 60, totalMinutes % 60);
    }
}
