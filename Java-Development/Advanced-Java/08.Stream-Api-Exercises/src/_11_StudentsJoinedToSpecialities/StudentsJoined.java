package _11_StudentsJoinedToSpecialities;

import java.util.*;
import java.util.stream.Collectors;

public class StudentsJoined {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        List<StudentSpeciality> specialities = new ArrayList<>();
        String line = null;
        while (!(Objects.equals(line = scanner.nextLine(), "Students:"))) {
            String[] data = line.split(" ");
            String specialityName = data[0] + " " + data[1];
            String facultyNumber = data[2];

            StudentSpeciality studentSpeciality = new StudentSpeciality(specialityName, facultyNumber);
            specialities.add(studentSpeciality);
        }

        List<Student> students = new ArrayList<>();
        while (!(Objects.equals(line = scanner.nextLine(), "END"))) {
            String[] data = line.split(" ");
            String facultyNumber = data[0];
            String name = data[1] + " " + data[2];

            Student student = new Student(name, facultyNumber);
            students.add(student);
        }

        students
                .stream()
                .flatMap(v1 -> specialities.stream()
                        .filter(v2 -> v1.getFacultyNumber().equals(v2.getFacultyNumber()))
                        .map(v2 -> new Triple(v1.getName(), v1.getFacultyNumber(), v2.getSpecialityName())))
                .sorted((a, b) -> a.getItem1().compareTo(b.getItem1()))
                .collect(Collectors.toList()).forEach(System.out::println);

    }
}

class Triple {

    private String item1;
    private String item2;
    private String item3;

    public Triple(String item1, String item2, String item3) {
        this.item1 = item1;
        this.item2 = item2;
        this.item3 = item3;
    }

    public String getItem1() {
        return item1;
    }

    public String getItem2() {
        return item2;
    }

    public String getItem3() {
        return item3;
    }

    @Override
    public String toString() {
        return String.format("%s %s %s", item1, item2, item3);
    }
}

class StudentSpeciality {

    private String specialityName;
    private String facultyNumber;

    public StudentSpeciality(String specialityName, String facultyNumber) {
        this.specialityName = specialityName;
        this.facultyNumber = facultyNumber;
    }

    public String getSpecialityName() {
        return specialityName;
    }

    public String getFacultyNumber() {
        return facultyNumber;
    }
}

class Student {

    private String name;
    private String facultyNumber;

    public Student(String name, String facultyNumber) {
        this.name = name;
        this.facultyNumber = facultyNumber;
    }

    public String getName() {
        return name;
    }

    public String getFacultyNumber() {
        return facultyNumber;
    }
}