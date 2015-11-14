import java.util.Scanner;

public class _1_GandalfsStash {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int mood = Integer.parseInt(scanner.nextLine());
        String[] foods = scanner.nextLine()
                    .toLowerCase()
                    .replaceAll("_", "")
                    .replaceAll("-","")
                    .split("\\W+");

        for (int i = 0; i < foods.length; i++) {
            if(foods[i].equals("cram")) {
                mood += 2;
            } else if(foods[i].equals("lembas")) {
                mood += 3;
            } else if(foods[i].equals("apple") || foods[i].equals("melon")) {
                mood += 1;
            } else if(foods[i].equals("honeycake")) {
                mood += 5;
            } else if(foods[i].equals("mushrooms")) {
                mood -= 10;
            } else {
                mood -= 1;
            }
        }

        System.out.println(mood);
        if(mood < -5) {
            System.out.println("Angry");
        } else if(mood >= -5 && mood < 0) {
            System.out.println("Sad");
        } else if(mood >= 0 && mood <= 15) {
            System.out.println("Happy");
        } else {
            System.out.println("Special JavaScript mood");
        }
    }
}
