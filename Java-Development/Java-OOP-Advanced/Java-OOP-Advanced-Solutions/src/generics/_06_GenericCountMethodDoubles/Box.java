package generics._06_GenericCountMethodDoubles;

public class Box<T extends Comparable<T>> implements Comparable<Box<T>> {

    private T value;

    public Box(T value) {
        this.setValue(value);
    }

    public T getValue() {
        return value;
    }

    private void setValue(T value) {
        this.value = value;
    }

    @Override
    public String toString() {
        return String.format("%s: %s", this.getValue().getClass().getTypeName(), this.getValue());
    }

    @Override
    public int compareTo(Box<T> o) {
        return this.compareTo(o);
    }
}