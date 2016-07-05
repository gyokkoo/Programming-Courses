package inheritance._03_Mankind;

import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Student extends Human {
    private String facultyNumber;

    public Student(String firstName, String lastName, String facultyNumber) {
        super(firstName, lastName);
        this.setFacultyNumber(facultyNumber);
    }

    private void setFacultyNumber(String facultyNumber) {
        Pattern pattern = Pattern.compile("^[a-zA-Z0-9]{5,10}$");
        Matcher matcher = pattern.matcher(facultyNumber);
        if (!matcher.find()) {
            throw new IllegalArgumentException("Invalid faculty number!");
        }

        this.facultyNumber = facultyNumber;
    }

    private String getFacultyNumber() {
        return facultyNumber;
    }

    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder();
        sb.append(super.toString());
        sb.append("Faculty number: ").append(this.getFacultyNumber());

        return sb.toString();
    }
}
