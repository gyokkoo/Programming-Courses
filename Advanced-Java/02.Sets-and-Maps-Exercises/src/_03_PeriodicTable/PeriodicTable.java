package _03_PeriodicTable;

import java.util.*;

public class PeriodicTable {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int countOfLines = Integer.parseInt(scanner.nextLine());
        TreeSet<String> chemicalCompounds = new TreeSet<>();
        for (int i = 0; i < countOfLines; i++) {
            String[] lineArgs = scanner.nextLine().split("\\s+");
            Collections.addAll(chemicalCompounds, lineArgs);
        }

        for (String chemicalCompound : chemicalCompounds) {
            System.out.print(chemicalCompound + " ");
        }
    }
}