package methodsHomework._04_NumberInReversedOrder;

public class DecimalNumber {
    private Double number;

    public DecimalNumber(Double number) {
        this.number = number;
    }

    public void printDigitsInReversedOrder() {
        StringBuilder builder = new StringBuilder();
        if (this.number % 1 == 0) {
            builder.append(this.number.intValue());
        } else {
            builder.append(this.number);
        }

        System.out.println(builder.reverse());
    }
}
