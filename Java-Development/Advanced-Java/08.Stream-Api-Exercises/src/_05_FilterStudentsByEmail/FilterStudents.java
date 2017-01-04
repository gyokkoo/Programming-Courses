package _05_FilterStudentsByEmail;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class FilterStudents {

    private static final String DOMAIN = "@gmail.com";

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        List<Student> students = new ArrayList<>();
        String line;
        while (!(line = scanner.nextLine()).equals("END")) {
            String[] data = line.split(" ");
            String firstName = data[0];
            String lastName = data[1];
            String email = data[2];
            Student student = new Student(firstName, lastName, email);
            students.add(student);
        }

        students.stream()
                .filter(s -> s.getEmail().contains(DOMAIN))
                .forEach(System.out::println);
    }
}

class Student {

    private String firstName;
    private String lastName;
    private String email;

    public Student(String firstName, String lastName, String email) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.email = email;
    }

    public String getFirstName() {
        return firstName;
    }

    public String getEmail() {
        return email;
    }

    public String getLastName() {
        return lastName;
    }

    @Override
    public String toString() {
        return firstName + " " + lastName;
    }
}

