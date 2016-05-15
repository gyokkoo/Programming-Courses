import java.math.BigInteger;
import java.util.*;

import static java.math.BigInteger.*;

public class _3_CriticalBreakpoint {
    private static final String END_COMMAND = "Break it.";

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        ArrayList<ArrayList<Long>> lines = new ArrayList<>();
        long absoluteCriticalRatio = 0;
        String line = scanner.nextLine();
        while (!END_COMMAND.equals(line)) {
            String[] inputArgs = line.split("\\s+");
            ArrayList<Long> result = new ArrayList<>();
            long x1 = Long.parseLong(inputArgs[0]);
            long y1 = Long.parseLong(inputArgs[1]);
            long x2 = Long.parseLong(inputArgs[2]);
            long y2 = Long.parseLong(inputArgs[3]);
            result.add(x1);
            result.add(y1);
            result.add(x2);
            result.add(y2);

            long actualRatio = Math.abs((x2 + y2) - (x1 + y1));
            if (actualRatio != 0 && absoluteCriticalRatio == 0) {
                absoluteCriticalRatio = actualRatio;
            }

            if (actualRatio != 0 && absoluteCriticalRatio != actualRatio) {
                System.out.println("Critical breakpoint does not exist.");
                return;
            }

            lines.add(result);
            line = scanner.nextLine();
        }

        BigInteger criticalBreakpoint = calculateCriticalBreakpoint(absoluteCriticalRatio, lines.size());
        for (ArrayList<Long> currentLine : lines) {
            System.out.println("Line: " + currentLine);
        }
        System.out.println("Critical Breakpoint: " + criticalBreakpoint);
    }

    private static BigInteger calculateCriticalBreakpoint(long actualCriticalRatio, int lines) {
        return valueOf(actualCriticalRatio).pow(lines).remainder(valueOf(lines));
    }
}
