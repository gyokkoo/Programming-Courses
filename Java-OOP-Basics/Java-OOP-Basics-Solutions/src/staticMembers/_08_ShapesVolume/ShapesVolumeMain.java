package staticMembers._08_ShapesVolume;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class ShapesVolumeMain {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        while (true) {
            String[] tokens = reader.readLine().split(" ");
            if (tokens[0].equals("End")) {
                break;
            }

            String shapeType = tokens[0];
            double shapeVolume = 0;
            switch (shapeType) {
                case "TrianglePrism":
                    double baseSide = Double.parseDouble(tokens[1]);
                    double heightFromBase = Double.parseDouble(tokens[2]);
                    double length = Double.parseDouble(tokens[3]);
                    TriangularPrism triangularPrism = new TriangularPrism(baseSide, heightFromBase, length);
                    shapeVolume = VolumeCalculator.calculateTriangularPrismVolume(triangularPrism);
                    break;
                case "Cube":
                    double sideLength = Double.parseDouble(tokens[1]);
                    Cube cube = new Cube(sideLength);
                    shapeVolume = VolumeCalculator.calculateCubeVolume(cube);
                    break;
                case "Cylinder":
                    double radius = Double.parseDouble(tokens[1]);
                    double height = Double.parseDouble(tokens[2]);
                    Cylinder cylinder = new Cylinder(radius, height);
                    shapeVolume = VolumeCalculator.calculateCylinderVolume(cylinder);
                    break;
            }
            System.out.printf("%.3f%n", shapeVolume);
        }
    }
}
