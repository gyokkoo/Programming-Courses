package staticMembers._02_UniqueStudentNames;

import java.util.HashSet;

public class StudentGroup {
    private static int studentsCount;
    private HashSet<String> students;

    static {
        studentsCount = 0;
    }

    public StudentGroup() {
        this.students = new HashSet<>();
    }

    public void addStudents(String name) {
        if (this.students.add(name)) {
            studentsCount++;
        }
    }

    public static int getStudentsCount() {
        return studentsCount;
    }
}
