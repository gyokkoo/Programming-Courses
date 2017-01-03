package methodsHomework._01_MethodSayHello;

public class Person {
    private String name;

    public Person(String name) {
        this.name = name;
    }

    public void printHello() {
        System.out.println(this.name + " says \"Hello\"!");
    }
}
