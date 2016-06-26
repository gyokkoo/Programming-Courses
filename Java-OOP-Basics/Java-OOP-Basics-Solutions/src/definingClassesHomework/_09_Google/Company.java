package definingClassesHomework._09_Google;

public class Company {
    private String name;
    private String department;
    private Double salary;

    public Company(String name, String department, Double salary) {
        this.name = name;
        this.department = department;
        this.salary = salary;
    }

    @Override
    public String toString() {
        return String.format("%s %s %.2f", this.name, this.department, this.salary);
    }
}
