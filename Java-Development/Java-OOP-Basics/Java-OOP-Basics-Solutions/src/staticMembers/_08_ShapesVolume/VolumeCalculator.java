package staticMembers._08_ShapesVolume;

public class VolumeCalculator {
    public static double calculateTriangularPrismVolume(TriangularPrism triangularPrism) {
        return triangularPrism.getBaseSide()
                * triangularPrism.getHeight()
                * triangularPrism.getLength() / 2;
    }

    public static double calculateCubeVolume(Cube cube) {
        return Math.pow(cube.getSideLength(), 3);
    }

    public static double calculateCylinderVolume(Cylinder cylinder) {
        return Math.PI * Math.pow(cylinder.getRadius(), 2) * cylinder.getHeight();
    }
}
