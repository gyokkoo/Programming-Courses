package softuni.people;

public class Person {
    double income;

    public Person(double income) {
        this.setIncome(income);
    }

    public double getIncome() {
        return income;
    }

    private void setIncome(double income) {
        this.income = income;
    }
}
