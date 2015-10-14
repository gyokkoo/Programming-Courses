import java.util.Scanner;

public class _06_SumNumbers {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("N = ");
        int numberN = scanner.nextInt();

        int sum = 0;
        for(int i = 1; i <= numberN; i ++)
        {
            if(i != numberN){
                System.out.print(i + " + ");
                sum += i;
            }
            else {
                sum += i;
                System.out.println(i + " = " + sum);
            }
        }
    }

}
