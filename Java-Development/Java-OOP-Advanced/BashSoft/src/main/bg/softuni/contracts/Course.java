package main.bg.softuni.contracts;

import java.util.Map;

public interface Course extends Comparable<Course> {

    String getName();

    Map<String, Student> getStudentsByName();

    void enrollStudent(Student student);
}
