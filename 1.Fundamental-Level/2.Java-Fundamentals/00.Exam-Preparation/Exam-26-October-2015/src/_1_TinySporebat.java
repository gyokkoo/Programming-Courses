import java.util.Scanner;

public class _1_TinySporebat {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int healthPoints = 5800;
        int glowcapsCounter = 0;

        String line = scanner.nextLine();
        while(!line.equals("Sporeggar")) {
            for (int i = 0; i < line.length() - 1; i++) {
                if(line.charAt(i) == 'L') {
                    healthPoints += 200;
                } else {
                    healthPoints -= line.charAt(i);
                    if(healthPoints <= 0) {
                        break;
                    }
                }
            }

            if (healthPoints > 0 && Character.isDigit(line.charAt(line.length() - 1))) {
                int glowcaps = Character.getNumericValue(line.charAt(line.length() - 1));
                glowcapsCounter += glowcaps;
            }

            if(healthPoints <= 0) {
                break;
            }
            line = scanner.nextLine();
        }

        if(healthPoints > 0) {
            System.out.printf("Health left: %d\n", healthPoints);
            if(glowcapsCounter >= 30) {
                System.out.printf("Bought the sporebat. Glowcaps left: %d\n", (glowcapsCounter - 30));
            } else {
                System.out.printf("Safe in Sporeggar, but another %d Glowcaps needed.\n", (30 - glowcapsCounter));
            }
        } else {
            System.out.printf("Died. Glowcaps: %d\n", glowcapsCounter);
        }
    }
}
