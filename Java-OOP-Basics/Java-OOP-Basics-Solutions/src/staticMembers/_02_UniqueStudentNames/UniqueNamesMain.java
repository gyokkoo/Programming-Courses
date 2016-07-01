package staticMembers._02_UniqueStudentNames;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class UniqueNamesMain {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        StudentGroup studentGroup = new StudentGroup();
        while (true) {
            String studentName = reader.readLine();
            if (studentName.equals("End")) {
                break;
            }

            Student student = new Student(studentName);
            studentGroup.addStudents(studentName);
        }

        System.out.println(StudentGroup.getStudentsCount());
    }
}
