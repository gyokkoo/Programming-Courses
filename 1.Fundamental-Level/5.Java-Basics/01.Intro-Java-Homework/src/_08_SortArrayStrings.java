import java.util.Scanner;

public class _08_SortArrayStrings {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int numberOfItems = input.nextInt();

		input.nextLine(); // Clear a line

		String[] items = new String[numberOfItems];
		for (int i = 0; i < numberOfItems; i++) {
			items[i] = input.nextLine();
		}

		ArraySort(items);

		for (String element : items) {
			System.out.println(element);
		}
	}

	private static void ArraySort(String[] items) {
		for (int i = 0; i < items.length; i++) {
			for (int j = 0; j < items.length; j++) {
				if (items[i].compareTo(items[j]) < 0) {
					String temp = items[j];
					items[j] = items[i];
					items[i] = temp;
				}
			}
		}
	}
}
