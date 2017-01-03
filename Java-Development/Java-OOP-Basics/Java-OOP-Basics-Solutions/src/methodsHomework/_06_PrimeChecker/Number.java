package methodsHomework._06_PrimeChecker;

public class Number {
    private Integer number;
    private Boolean prime;

    public Number(Integer number, Boolean prime) {
        this.number = number;
        this.prime = this.checkPrime(number);
    }

    public Boolean getPrime() {
        return prime;
    }

    public Integer getNumber() {
        return number;
    }

    public Number nextPrimeNumber() {
        Integer nextPrime = this.number + 1;
        for (int i = this.number + 1; i < this.number * 2; i++) {
            if (this.checkPrime(i)) {
                nextPrime = i;
                break;
            }
        }

        return new Number(nextPrime, true);
    }

    public boolean checkPrime(int n) {
        for (int i = 2; i <= Math.sqrt(n); i++) {
            if (n % i == 0) {
                return false;
            }
        }

        return true;
    }

    @Override
    public String toString() {
        return this.number + ", " + this.prime;
    }
}
