package _06_FilterStudentsByPhone;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class FilterStudents {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        List<Student> students = new ArrayList<>();
        String line;
        while (!(line = scanner.nextLine()).equals("END")) {
            String[] data = line.split(" ");
            String firstName = data[0];
            String lastName = data[1];
            String phone = data[2];

            Student student = new Student(firstName, lastName, phone);
            students.add(student);
        }

        students.stream()
                .filter(p -> p.getPhone().startsWith("02") || p.getPhone().startsWith("+3592"))
                .forEach(System.out::println);
    }
}

class Student {

    private String firstName;
    private String lastName;
    private String phone;

    public Student(String firstName, String lastName, String phone) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.phone = phone;
    }

    public String getPhone() {
        return phone;
    }

    @Override
    public String toString() {
        return firstName + " " + lastName;
    }
}