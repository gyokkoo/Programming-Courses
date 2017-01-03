package staticMembers._01_Students;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class StudentsMain {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        while (true) {
            String studentName = reader.readLine();
            if (studentName.equals("End")) {
                break;
            }

            Student student = new Student(studentName);
        }

        System.out.println(Student.getStudentsCount());
    }
}
