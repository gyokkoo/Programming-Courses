import java.util.Scanner;

public class _1_Timespan {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] startTime = scanner.nextLine().split(":");
        String[] endTime = scanner.nextLine().split(":");

        long startHours = Long.parseLong(startTime[0]);
        long startMinutes = Long.parseLong(startTime[1]);
        long startSeconds = Long.parseLong(startTime[2]);
        long startTotalSeconds = startHours*3600 + startMinutes*60 + startSeconds;

        long endHours = Long.parseLong(endTime[0]);
        long endMinutes = Long.parseLong(endTime[1]);
        long endSeconds = Long.parseLong(endTime[2]);
        long endTotalSeconds = endHours*3600 + endMinutes*60 + endSeconds;

        long resultSeconds = startTotalSeconds - endTotalSeconds;
        long resultHours = resultSeconds / 3600;
        long resultMinutes = (resultSeconds - resultHours * 3600)/60;
        System.out.printf("%d:%02d:%02d",
                resultHours, resultMinutes, resultSeconds % 60);
    }
}
