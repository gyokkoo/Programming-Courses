package definingClassesHomework._04_CompanyRoster;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.HashMap;
import java.util.Map;
import java.util.TreeSet;

public class CompanyRosterMain {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        HashMap<String, Double> departmentsWithSalary = new HashMap<>();
        HashMap<String, TreeSet<Employee>> departmentsWithEmployees = new HashMap<>();

        int countOfEmployees = Integer.parseInt(reader.readLine());
        for (int i = 0; i < countOfEmployees; i++) {
            String[] tokens = reader.readLine().split("\\s+");
            String name = tokens[0];
            double salary = Double.valueOf(tokens[1]);
            String position = tokens[2];
            String department = tokens[3];

            Employee employee = null;
            if (tokens.length == 4) {
                employee = new Employee(name, salary, position, department);
            } else if (tokens.length == 5) {
                if (isDigit(tokens[4])) {
                    employee = new Employee(name, salary, position, department, Integer.valueOf(tokens[4]));
                } else {
                    employee = new Employee(name, salary, position, department, tokens[4]);
                }
            } else if (tokens.length == 6) {
                employee = new Employee(name, salary, position, department, tokens[4], Integer.valueOf(tokens[5]));
            }

            if (!departmentsWithEmployees.containsKey(department)) {
                departmentsWithSalary.put(department, 0.0);
                departmentsWithEmployees.put(department, new TreeSet<>());
            }

            departmentsWithEmployees.get(department).add(employee);
            departmentsWithSalary.put(department, departmentsWithSalary.get(department) + salary);
        }

        Map.Entry<String, TreeSet<Employee>> best = departmentsWithEmployees.entrySet()
                .stream()
                .sorted((e1, e2) -> Double.compare(departmentsWithSalary.get(e2.getKey()), departmentsWithSalary.get(e1.getKey())))
                .findFirst().get();

        System.out.println("Highest Average Salary: " + best.getKey());
        best.getValue().forEach(System.out::println);
    }

    private static boolean isDigit(String str) {
        try {
            Integer.parseInt(str);
            return true;
        } catch (NumberFormatException e) {
            return false;
        }
    }
}
