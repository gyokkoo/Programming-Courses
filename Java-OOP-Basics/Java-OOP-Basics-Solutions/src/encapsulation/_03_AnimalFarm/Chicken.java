package encapsulation._03_AnimalFarm;

public class Chicken {
    private final int MIN_AGE = 0;
    private final int MAX_AGE = 15;

    private String name;
    private int age;

    public Chicken(String name, int age) {
        this.setName(name);
        this.setAge(age);
    }

    public void setAge(int age) {
        if (age < MIN_AGE || MAX_AGE < age) {
            throw new IllegalArgumentException("Age should be between 0 and 15.");
        }

        this.age = age;
    }

    public void setName(String name) {
        if (name == null || name.isEmpty() || name.trim().length() == 0) {
            throw new IllegalArgumentException("Name cannot be empty.");
        }

        this.name = name;
    }

    public String getName() {
        return this.name;
    }

    public int getAge() {
        return this.age;
    }

    public double getProductPerDay() {
        return this.calculateProductPerDay();
    }

    private double calculateProductPerDay() {
        switch (this.age) {
            case 0:
            case 1:
            case 2:
            case 3:
                return 2;
            case 4:
            case 5:
            case 6:
            case 7:
                return 3;
            case 8:
            case 9:
            case 10:
            case 11:
                return 2;
            default:
                return 1;
        }
    }
}