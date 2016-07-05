package inheritance._03_Mankind;

public class Worker extends Human {
    private double weekSalary;
    private double workHours;

    public Worker(String firstName, String lastName, double weekSalary, double hoursPerDay) {
        super(firstName, lastName);
        this.setWeekSalary(weekSalary);
        this.setWorkHours(hoursPerDay);
    }

    private void setWeekSalary(double salary) {
        if (salary < 10) {
            throw new IllegalArgumentException("Expected value mismatch! Argument: weekSalary");
        }

        this.weekSalary = salary;
    }

    private void setWorkHours(double workHours) {
        if (workHours < 1 || 12 < workHours) {
            throw new IllegalArgumentException("Expected value mismatch! Argument: workHoursPerDay");
        }

        this.workHours = workHours;
    }

    public double getWeekSalary() {
        return weekSalary;
    }

    public double getWorkHours() {
        return workHours;
    }

    private double calculateSalaryPerHour() {
        return this.weekSalary / (7 * this.workHours);
    }

    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder();
        sb.append(super.toString());
        sb.append(String.format("Week Salary: %.2f%n", this.getWeekSalary()));
        sb.append(String.format("Hours per day: %.2f%n", this.getWorkHours()));
        sb.append(String.format("Salary per hour: %.2f", this.calculateSalaryPerHour()));

        return sb.toString();
    }
}