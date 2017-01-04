package _07_ExcellentStudents;

import java.util.*;

public class ExcellentStudents {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        List<Student> students = new ArrayList<>();
        String line = null;
        while (!Objects.equals(line = scanner.nextLine(), "END")) {
            String[] data = line.split(" ");
            String firstName = data[0];
            String lastName = data[1];
            List<Integer> grades = new ArrayList<>();
            for (int i = 2; i < data.length; i++) {
                grades.add(Integer.parseInt(data[i]));
            }

            Student student = new Student(firstName, lastName, grades);
            students.add(student);
        }

        students.stream()
                .filter(s -> s.getGrades().contains(6))
                .forEach(System.out::println);
    }
}

class Student {

    private String firstName;
    private String lastName;
    private List<Integer> grades;

    public Student(String firstName, String lastName, List<Integer> grades) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.grades = grades;
    }

    public List<Integer> getGrades() {
        return Collections.unmodifiableList(grades);
    }

    @Override
    public String toString() {
        return firstName + " " + lastName;
    }
}
