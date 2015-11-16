import java.util.Scanner;

public class _1_SoftuniPalatkaConf {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int people = Integer.parseInt(scanner.nextLine());
        int peopleNeedBed = people;
        int peopleNeedFood = people;
        int n = Integer.parseInt(scanner.nextLine());
        for (int i = 0; i < n; i++) {
            String[] lineArgs = scanner.nextLine().split(" ");
            String option = lineArgs[0];
            int quantity = Integer.parseInt(lineArgs[1]);
            String type = lineArgs[2];

            if (option.equals("tents")) {
                if (type.equals("normal")) { //for 2 people
                    peopleNeedBed -= (2 * quantity);
                } else if (type.equals("firstClass")) { //for 3 people
                    peopleNeedBed -= (3 * quantity);
                }
            } else if (option.equals("food")) {
                if(type.equals("musaka")) {
                    peopleNeedFood -= (2 * quantity);
                } else if(type.equals("zakuska")) {
                    peopleNeedFood -= 0;
                }
            } else if (option.equals("rooms")) {
                if(type.equals("single")) {
                    peopleNeedBed -= quantity;
                } else if(type.equals("double")) {
                    peopleNeedBed -= (2 * quantity);
                } else if(type.equals("triple")) {
                    peopleNeedBed -= (3 * quantity);
                }
            }
        }

        if(peopleNeedBed <= 0) {
            System.out.println("Everyone is happy and sleeping well. Beds left: " + Math.abs(peopleNeedBed));
            if(peopleNeedFood <= 0) {
                System.out.println("Nobody left hungry. Meals left: " + Math.abs(peopleNeedFood));
            } else {
                System.out.println("People are starving. Meals needed: " +  Math.abs(peopleNeedFood));
            }
        } else if(peopleNeedBed > 0){
            System.out.println("Some people are freezing cold. Beds needed: " + Math.abs(peopleNeedBed));
            if (peopleNeedFood <= 0) {
                System.out.println("Nobody left hungry. Meals left: " + Math.abs(peopleNeedFood));
            } else {
                System.out.println("People are starving. Meals needed: " + Math.abs(peopleNeedFood));
            }
        }
    }
}
