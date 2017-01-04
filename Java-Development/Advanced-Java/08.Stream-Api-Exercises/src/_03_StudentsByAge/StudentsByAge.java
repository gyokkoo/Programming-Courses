package _03_StudentsByAge;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class StudentsByAge {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        List<Student> students = new ArrayList<>();
        String line;
        while (!(line = scanner.nextLine()).equals("END")) {
            String[] data = line.split(" ");
            String firstName = data[0];
            String lastName = data[1];
            int age = Integer.parseInt(data[2]);
            Student student = new Student(firstName, lastName, age);
            students.add(student);
        }

        students.stream()
                .filter(s -> 18 <= s.getAge() && s.getAge() <= 24)
                .forEach(System.out::println);
    }
}

class Student {

    private String firstName;
    private String lastName;
    private int age;

    public Student(String firstName, String lastName, int age) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }

    public String getFirstName() {
        return firstName;
    }

    public String getLastName() {
        return lastName;
    }

    public int getAge() {
        return age;
    }

    @Override
    public String toString() {
        return String.format("%s %s %d", firstName, lastName, age);
    }
}