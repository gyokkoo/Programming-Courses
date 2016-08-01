package enumerationAndAnnotations._09_TrafficLights;

import enumerationAndAnnotations._09_TrafficLights.enums.TrafficLight;
import enumerationAndAnnotations._09_TrafficLights.models.StateMachine;

import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class Main {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] lineTokens = scanner.nextLine().split("[\\s]+");
        List<TrafficLight> trafficLights = Arrays.stream(lineTokens)
                .map(TrafficLight::valueOf)
                .collect(Collectors.toList());

        StateMachine stateMachine = new StateMachine(trafficLights);

        int numberOfLines = Integer.parseInt(scanner.nextLine());
        for (int i = 0; i < numberOfLines; i++) {
            stateMachine.update();
            System.out.println(stateMachine);
        }
    }
}
