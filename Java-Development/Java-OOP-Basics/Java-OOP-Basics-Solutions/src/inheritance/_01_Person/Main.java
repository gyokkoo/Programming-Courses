package inheritance._01_Person;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String name = scanner.nextLine();
        Integer age = Integer.valueOf(scanner.nextLine());

        try {
            Child child = new Child(name, age);
            System.out.println(child.toString());
            String personClassName = Person.class.getSimpleName();
            String childClassName = Child.class.getSimpleName();
        } catch (IllegalArgumentException error) {
            System.out.println(error.getMessage());
        }
    }
}