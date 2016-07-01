package staticMembers._06_PlankConstant;

public class Calculation {
    private static double planckConstant;
    private static double pi;

    static {
        planckConstant = 6.62606896e-34;
        pi = 3.14159;
    }

    public static double getReducedPlanckConstant() {
        return planckConstant / (2 * pi);
    }
}
