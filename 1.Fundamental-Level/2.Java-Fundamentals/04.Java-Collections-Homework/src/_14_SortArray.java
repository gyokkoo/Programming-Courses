import java.util.*;

public class _14_SortArray {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter an array of integers on a single line and the sorting order.");
        String[] inputLine = scanner.nextLine().split(" ");
        String sortingOrder = scanner.nextLine();

        List<Integer> numbersList = new ArrayList<>();
        for (String number : inputLine) {
            numbersList.add(Integer.parseInt(number));
        }

        if (sortingOrder.equals("Ascending")) {
        numbersList.stream()
                    .sorted((a, b) -> a.compareTo(b))
                    .forEach(number -> System.out.print(number + " "));
        } else if (sortingOrder.equals("Descending")) {
            numbersList.stream()
                    .sorted((a, b) -> b.compareTo(a))
                    .forEach(number -> System.out.print(number + " "));
        }
    }
}
