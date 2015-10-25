import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class _09_CombineLists {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter two lists of characters separated by a space");

        String[] firstLine = scanner.nextLine().split(" ");
        List<Character> firstList = new ArrayList<>();
        for (String chStr : firstLine) {
            firstList.add(chStr.charAt(0));
        }

        String[] secondLine = scanner.nextLine().split(" ");
        List<Character> secondList = new ArrayList<>();
        for (String chStr : secondLine) {
            secondList.add(chStr.charAt(0));
        }

        List<Character> resultList = new ArrayList<>();
        for (int i = 0; i < firstList.size(); i++) {
           resultList.add(firstList.get(i));
        }
        for (int i = 0; i < secondList.size(); i++) {
            if(!firstList.contains(secondList.get(i))) {
                resultList.add(secondList.get(i));
            }
        }

        for (Character character : resultList) {
            System.out.print(character + " ");
        }
    }
}
