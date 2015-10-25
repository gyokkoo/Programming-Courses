import java.util.Scanner;
//http://cs-fundamentals.com/tech-interview/dsa/recursive-binary-search.php

public class _15_RecursiveBinarySearch {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter a number and array of sorted numbers on the next line.");
        int key = Integer.parseInt(scanner.nextLine());
        String[] inputLine = scanner.nextLine().split(" ");

        int[] arrayOfNumbers = new int[inputLine.length];
        for (int i = 0; i < inputLine.length; i++) {
            arrayOfNumbers[i] = Integer.parseInt(inputLine[i]);
        }
        //Arrays.sort(arrayOfNumbers);

        int index = recursiveBinarySearch(arrayOfNumbers, key, 0, arrayOfNumbers.length - 1);

        System.out.println(index);
    }

    private static int recursiveBinarySearch(int[] arr, int key, int low, int high) {
        if(high < low) {
            return -1;
        }

        int mid = (low + high) / 2;

        if(arr[mid] < key) {
            return recursiveBinarySearch(arr, key, mid + 1, high);
        } else if(arr[mid] > key) {
            return recursiveBinarySearch(arr, key, low, mid - 1);
        } else {
            return mid;
        }
    }
}
