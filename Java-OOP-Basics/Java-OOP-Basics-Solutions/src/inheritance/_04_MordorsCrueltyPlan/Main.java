package inheritance._04_MordorsCrueltyPlan;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        int happyness = 0;
        String[] foods = reader.readLine().split("\\s+");
        for (String food : foods) {
            switch (food.toLowerCase()) {
                case "cram":
                    happyness += 2;
                    break;
                case "lembas":
                    happyness += 3;
                    break;
                case "apple":
                    happyness += 1;
                    break;
                case "melon":
                    happyness += 1;
                    break;
                case "honeycake":
                    happyness += 5;
                    break;
                case "mushrooms":
                    happyness -= 10;
                    break;
                default:
                    happyness -= 1;
            }
        }

        System.out.println(happyness);
        if (happyness < -5) {
            System.out.println("Angry");
        } else if (happyness < 0) {
            System.out.println("Sad");
        } else if (happyness < 15) {
            System.out.println("Happy");
        } else {
            System.out.println("JavaScript");
        }
    }
}
