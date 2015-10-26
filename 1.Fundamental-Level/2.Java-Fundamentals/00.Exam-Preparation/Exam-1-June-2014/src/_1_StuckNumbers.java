import java.util.Scanner;
//https://judge.softuni.bg/Contests/Practice/Index/14#0

public class _1_StuckNumbers {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());
        String[] strNumbers = scanner.nextLine().split(" ");

        boolean isFound = false;

        for (String a : strNumbers) {
            for (String b : strNumbers) {
                for (String c : strNumbers) {
                    for (String d : strNumbers) {
                        if(!a.equals(b) && !a.equals(c) && !a.equals(d) &&
                                !b.equals(c) && !b.equals(d) && !c.equals(d)) {
                            if((a+b).equals(c+d)) {
                                System.out.printf("%s|%s==%s|%s%n", a, b, c, d);
                                isFound = true;
                            }
                        }
                    }
                }
            }
        }

        if(!isFound) {
            System.out.println("No");
        }
    }
}
