package staticMembers._01_Students;

public class Student {
    private static Integer studentsCount;
    private String name;

    static {
        studentsCount = 0;
    }

    public Student(String name) {
        this.name = name;
        studentsCount++;
    }

    public static Integer getStudentsCount() {
        return studentsCount;
    }
}
