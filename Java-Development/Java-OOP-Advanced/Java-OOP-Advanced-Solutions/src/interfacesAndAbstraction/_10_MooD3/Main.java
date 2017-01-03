package interfacesAndAbstraction._10_MooD3;

import interfacesAndAbstraction._10_MooD3.interfaces.GameObject;
import interfacesAndAbstraction._10_MooD3.models.Archangel;
import interfacesAndAbstraction._10_MooD3.models.Demon;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;


public class Main {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String[] lineTokens = reader.readLine().split(" \\| ");

        String userName = lineTokens[0];
        String characterType = lineTokens[1];
        int level = Integer.parseInt(lineTokens[3]);

        switch (characterType) {
            case "Demon":
                Double demonSpecialPoints = Double.valueOf(lineTokens[2]);
                GameObject demon = new Demon(userName, level, demonSpecialPoints);
                System.out.println(demon);
                break;
            case "Archangel":
                Integer archangelSpecialPoints = Integer.valueOf(lineTokens[2]);
                GameObject archangel = new Archangel(userName, level, archangelSpecialPoints);
                System.out.println(archangel);
                break;
            default:
                throw new IllegalArgumentException("Invalid character type");
        }
    }
}
