package generics._04_GenericSwapMethodIntegers;

public class Box<T> {

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
}
