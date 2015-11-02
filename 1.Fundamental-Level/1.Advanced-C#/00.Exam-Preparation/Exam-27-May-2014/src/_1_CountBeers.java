import java.util.Scanner;

public class _1_CountBeers {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String inputLine = scanner.nextLine();

        int totalBeers = 0;
        while(!inputLine.equals("End")) {
            String[] lineArgs = inputLine.split(" ");
            String measure = lineArgs[1];
            if(measure.equals("stacks")) {
                totalBeers += 20 * Integer.parseInt(lineArgs[0]);
            } else {
                totalBeers += Integer.parseInt(lineArgs[0]);
            }

            inputLine = scanner.nextLine();
        }

        System.out.printf("%d stacks + %d beers\n", totalBeers / 20, totalBeers % 20);

    }
}
