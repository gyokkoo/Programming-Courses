package inheritance._03_Mankind;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        try {
            String[] studentArgs = reader.readLine().split("\\s+");
            String studentFirstName = studentArgs[0];
            String studentLastName = studentArgs[1];
            String facultyNumber = studentArgs[2];

            String[] workerArgs = reader.readLine().split("\\s+");
            String workerFirstName = workerArgs[0];
            String workerLastName = workerArgs[1];
            Double weekSalary = Double.valueOf(workerArgs[2]);
            Double workHoursPerDay = Double.valueOf(workerArgs[3]);

            Student student = new Student(studentFirstName, studentLastName, facultyNumber);
            Worker worker = new Worker(workerFirstName, workerLastName, weekSalary, workHoursPerDay);
            System.out.println(student);
            System.out.println();
            System.out.println(worker);
        } catch (IllegalArgumentException iae) {
            System.out.println(iae.getMessage());
        }
    }
}
