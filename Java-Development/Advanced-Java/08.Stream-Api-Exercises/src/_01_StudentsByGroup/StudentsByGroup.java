package _01_StudentsByGroup;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class StudentsByGroup {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        List<Student> students = new ArrayList<>();
        String line;
        while (!(line = scanner.nextLine()).equals("END")) {
            String[] data = line.split(" ");
            String firstName = data[0];
            String lastName = data[1];
            int groupNumber = Integer.parseInt(data[2]);
            Student student = new Student(firstName, lastName, groupNumber);
            students.add(student);
        }

        students.stream()
                .filter(s -> s.getGroup() == 2)
                .sorted((s1, s2) -> s1.getFirstName().compareTo(s2.getFirstName()))
                .forEach(System.out::println);
    }
}

class Student {

    private String firstName;
    private String lastName;
    private int group;

    public Student(String firstName, String lastName, int group) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.group = group;
    }

    public String getFirstName() {
        return firstName;
    }

    public int getGroup() {
        return group;
    }

    @Override
    public String toString() {
        return String.format("%s %s", firstName, lastName);
    }
}