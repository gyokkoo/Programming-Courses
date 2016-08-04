package main.bg.softuni.contracts;

import java.util.Map;

public interface Student extends Comparable<Student> {

    String getUserName();

    Map<String, Course> getEnrolledCourses();

    Map<String, Double> getMarksByCourseName();

    void enrollInCourse(Course course);

    void setMarkOnCourse(String courseName, int[] scores);

    String getMarkForCourse(String courseName);
}
