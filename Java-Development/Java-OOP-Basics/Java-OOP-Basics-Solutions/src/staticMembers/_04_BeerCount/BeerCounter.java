package staticMembers._04_BeerCount;

public class BeerCounter {
    private static long beerInStock;
    private static long beersDrankCount;

    static {
        beerInStock = 0;
        beersDrankCount = 0;
    }

    public static void buyBeer(long bottlesCount) {
        beerInStock += bottlesCount;
    }

    public static void drinkBeer(long bottlesCount) {
        beerInStock -= bottlesCount;
        beersDrankCount += bottlesCount;
    }

    public static long getBeerInStock() {
        return beerInStock;
    }

    public static long getBeersDrankCount() {
        return beersDrankCount;
    }
}
