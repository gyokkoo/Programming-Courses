package staticMembers._08_ShapesVolume;

public class TriangularPrism {
    private double baseSide;
    private double height;
    private double length;

    public TriangularPrism(double baseSide, double height, double length) {
        this.baseSide = baseSide;
        this.height = height;
        this.length = length;
    }

    public double getBaseSide() {
        return baseSide;
    }

    public double getHeight() {
        return height;
    }

    public double getLength() {
        return length;
    }
}
