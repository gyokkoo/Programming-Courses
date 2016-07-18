package interfacesAndAbstraction._07_FoodShortage.models;

import interfacesAndAbstraction._07_FoodShortage.interfaces.Identifiable;

public class Robot implements Identifiable {

    private String model;
    private String id;

    public Robot(String model, String id) {
        this.setModel(model);
        this.setId(id);
    }

    private String getModel() {
        return model;
    }

    private void setModel(String model) {
        this.model = model;
    }

    private void setId(String id) {
        this.id = id;
    }

    public String getId() {
        return id;
    }

    public Boolean checkId(String lastDigits) {
        return this.getId().endsWith(lastDigits);
    }
}
