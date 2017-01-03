package _1_CubicArillery;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayDeque;
import java.util.Queue;

public class CubicArtillery {

    private static final String END_MESSAGE = "Bunker Revision";

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int bunkerCapacity = Integer.parseInt(reader.readLine());
        int freeCapacity = bunkerCapacity;
        Queue<String> bunkers = new ArrayDeque<>();
        Queue<Integer> weapons = new ArrayDeque<>();

        String line = reader.readLine();
        while (!END_MESSAGE.equals(line)) {
            String[] inputData = line.split(" ");
            for (String str : inputData) {
                if (!Character.isDigit(str.toCharArray()[0])) {
                    bunkers.add(str);
                } else {
                    int weapon = Integer.parseInt(str);
                    boolean weaponContained = false;
                    while (bunkers.size() > 1) {
                        if (freeCapacity >= weapon) {
                            weapons.add(weapon);
                            freeCapacity -= weapon;
                            weaponContained = true;
                            break;
                        }

                        if (weapons.size() == 0) {
                            System.out.printf("%s -> Empty%n", bunkers.peek());
                        } else {
                            System.out.printf("%s -> %s%n", bunkers.peek(), strJoin(weapons, ", "));
                        }

                        bunkers.poll();
                        weapons.clear();
                        freeCapacity = bunkerCapacity;
                    }

                    if (!weaponContained && bunkers.size() == 1) {
                        if (bunkerCapacity >= weapon) {
                            if (freeCapacity < weapon) {
                                while (freeCapacity < weapon) {
                                    int removedWeapon = weapons.poll();
                                    freeCapacity += removedWeapon;

                                }
                            }

                            weapons.add(weapon);
                            freeCapacity -= weapon;
                        }
                    }
                }
            }

            line = reader.readLine();
        }

    }

    private static String strJoin(Queue<Integer> aArr, String sSep) {
        StringBuilder sbStr = new StringBuilder();
        while (aArr.size() != 1) {
            sbStr.append(aArr.poll()).append(sSep);
        }

        sbStr.append(aArr.poll());
        return sbStr.toString();
    }
}