package enumerationAndAnnotations._09_TrafficLights.models;

import enumerationAndAnnotations._09_TrafficLights.enums.TrafficLight;

import java.util.List;
import java.util.stream.Collectors;

public class StateMachine {

    private List<TrafficLight> trafficLights;

    public StateMachine(List<TrafficLight> trafficLights) {
        this.setTrafficLights(trafficLights);
    }

    public List<TrafficLight> getTrafficLights() {
        return trafficLights;
    }

    private void setTrafficLights(List<TrafficLight> trafficLights) {
        TrafficLight.GREEN.setNextSignal(TrafficLight.YELLOW);
        TrafficLight.RED.setNextSignal(TrafficLight.GREEN);
        TrafficLight.YELLOW.setNextSignal(TrafficLight.RED);

        this.trafficLights = trafficLights;
    }

    public void update() {
        List<TrafficLight> newSignals = trafficLights.stream()
                .map(TrafficLight::getNextSignal)
                .collect(Collectors.toList());

        this.trafficLights = newSignals;
    }

    @Override
    public String toString() {
        StringBuilder builder = new StringBuilder();
        for (TrafficLight trafficLight : trafficLights) {
            builder.append(trafficLight).append(" ");
        }

        return builder.toString();
    }
}
