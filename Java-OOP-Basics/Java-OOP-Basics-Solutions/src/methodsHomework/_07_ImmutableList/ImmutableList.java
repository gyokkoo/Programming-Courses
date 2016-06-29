package methodsHomework._07_ImmutableList;

import java.util.List;

public class ImmutableList {
    private List<Integer> numbers;

    public ImmutableList(List<Integer> numbers) {
        this.numbers = numbers;
    }

    public ImmutableList getNumbers() {
        return new ImmutableList(this.numbers);
    }
}
