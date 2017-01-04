package _09_StudentsEnrolled;

import java.util.*;
import java.util.stream.Collectors;

public class StudentsEnrolled {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        List<Student> students = new ArrayList<>();
        String line = null;
        while (!(Objects.equals(line = scanner.nextLine(), "END"))) {
            String[] data = line.split(" ");
            String facultyNumber = data[0];
            List<Integer> marks = new ArrayList<>();
            for (int i = 1; i < data.length; i++) {
                marks.add(Integer.parseInt(data[i]));
            }

            Student student = new Student(facultyNumber, marks);
            students.add(student);
        }

        students.stream()
                .filter(f -> f.getFacultyNumber().endsWith("14") || f.getFacultyNumber().endsWith("15"))
                .forEach(System.out::println);
    }
}

class Student {

    private String facultyNumber;
    private List<Integer> marks;

    public Student(String facultyNumber, List<Integer> marks) {
        this.facultyNumber = facultyNumber;
        this.marks = marks;
    }

    public String getFacultyNumber() {
        return facultyNumber;
    }

    @Override
    public String toString() {
        return marks.stream().map(Object::toString).collect(Collectors.joining(" "));
    }
}
