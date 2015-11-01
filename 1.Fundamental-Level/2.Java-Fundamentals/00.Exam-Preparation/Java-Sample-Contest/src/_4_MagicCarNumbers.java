import java.util.Scanner;

public class _4_MagicCarNumbers {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int targetSum = scanner.nextInt();

        int weight = 0;
        int counter = 0;
        for (int a = 0; a <= 9 ; a++) {
            for (int b = 0; b <= 9; b++) {
                for (int c = 0; c <= 9; c++) {
                    for (int d = 0; d <= 9; d++) {
                        for (int x = 1; x <= 10; x++) {
                            for (int y = 1; y <= 10; y++) {
                                if((a == b && a == c && a == d) || //CAaaaaXY
                                    (a != b && b == c && b == d) || //CAabbbXY
                                    (a == b && b == c && a != d) || //CAaaabXY
                                    (a == b && c == d && a != c) || //CAaabbXY
                                    (a == c && b == d && a != b) || //CAababXY
                                    (a == d && b == c && a != b)) {//CAabbaXY
                                    int xWeight = getWeight(x);
                                    int yWeight = getWeight(y);
                                    weight = 40 + a + b + c + d + xWeight + yWeight;
                                    if(weight == targetSum) {
                                        counter++;
                                        //System.out.println("" + a+b+c+d+xWeight+yWeight);
                                    }

                                }
                            }
                        }
                    }
                }
            }
        }

        System.out.println(counter);
    }

    private static int getWeight(int number) {
        if(number == 1) return 10;
        if(number == 2) return 20;
        if(number == 3) return 30;
        if(number == 4) return 50;
        if(number == 5) return 80;
        if(number == 6) return 110;
        if(number == 7) return 130;
        if(number == 8) return 160;
        if(number == 9) return 200;
        if(number == 10) return 240;
        return -1;
    }
}
