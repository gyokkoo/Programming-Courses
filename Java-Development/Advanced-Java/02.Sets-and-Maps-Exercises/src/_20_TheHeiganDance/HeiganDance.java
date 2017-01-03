package _20_TheHeiganDance;

import java.util.Scanner;

public class HeiganDance {
    private static final int CHAMBER_SIZE = 15;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int playerRow = 7;
        int playerCol = 7;
        double heiganHealth = 3000000;
        double playerHealth = 18500;

        double damage = Double.parseDouble(scanner.nextLine());
        String lastSpell = "";
        while (scanner.hasNextLine()) {
            String[] lineArgs = scanner.nextLine().split("\\s+");
            if (lastSpell.equals("Cloud")) {
                heiganHealth -= damage;
                playerHealth -= 3500;
            }

            if (playerHealth <= 0 || heiganHealth <= 0) {
                break;
            }

            if (!lastSpell.equals("Cloud")) {
                heiganHealth -= damage;
                if (heiganHealth <= 0) {
                    break;
                }
            }

            lastSpell = "Eruption";
            int row = Integer.parseInt(lineArgs[1]);
            int col = Integer.parseInt(lineArgs[2]);
            String spellName = lineArgs[0];
            int nextRow = playerRow;
            int nextCol = playerCol;
            if (isInDamageArea(row, col, nextRow, nextCol)) {
                nextRow = playerRow - 1;
                if (isInDamageArea(row, col, nextRow, nextCol) || isNextMoveWall(nextRow, nextCol)) {
                    nextRow = playerRow;
                    nextCol = playerCol + 1;
                    if (isInDamageArea(row, col, nextRow, nextCol) || isNextMoveWall(nextRow, nextCol)) {
                        nextRow = playerRow + 1;
                        nextCol = playerCol;
                        if (isInDamageArea(row, col, nextRow, nextCol) || isNextMoveWall(nextRow, nextCol)) {
                            nextRow = playerRow;
                            nextCol = playerCol - 1;
                            if (isInDamageArea(row, col, nextRow, nextCol) || isNextMoveWall(nextRow, nextCol)) {
                                if (spellName.equals("Cloud")) {
                                    playerHealth -= 3500;
                                } else {
                                    playerHealth -= 6000;
                                }
                                lastSpell = spellName;
                            } else {
                                playerCol--;
                            }
                        } else {
                            playerRow++;
                        }
                    } else {
                        playerCol++;
                    }
                } else {
                    playerRow--;
                }
            }
        }

        if (heiganHealth > 0) {
            System.out.printf("Heigan: %.2f%n", heiganHealth);
        } else {
            System.out.println("Heigan: Defeated!");
        }

        if (playerHealth <= 0) {
            System.out.printf("Player: Killed by %s%n", lastSpell.equals("Cloud") ? "Plague Cloud" : lastSpell);
        } else {
            System.out.printf("Player: %.0f%n", playerHealth);
        }

        System.out.printf("Final position: %d, %d%n", playerRow, playerCol);
    }

    private static boolean isInDamageArea(int damageRow, int damageCol, int playerRow, int playerCol) {
        for (int row = damageRow - 1; row <= damageRow + 1; row++) {
            for (int col = damageCol - 1; col <= damageCol + 1; col++) {
                if (row == playerRow && col == playerCol) {
                    return true;
                }
            }
        }

        return false;
    }

    private static boolean isNextMoveWall(int row, int col) {
        return row < 0 || CHAMBER_SIZE <= row || col < 0 || CHAMBER_SIZE <= col;
    }
}
