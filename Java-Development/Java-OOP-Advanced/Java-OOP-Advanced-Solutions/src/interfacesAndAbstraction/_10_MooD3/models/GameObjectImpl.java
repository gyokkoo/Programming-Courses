package interfacesAndAbstraction._10_MooD3.models;

import interfacesAndAbstraction._10_MooD3.interfaces.GameObject;

public abstract class GameObjectImpl<T> implements GameObject<T> {

    private String username;
    private String hashedPassword;
    private int level;
    private T specialPoints;
    private String characterType;

    protected GameObjectImpl(String username, String characterType, int level, T specialPoints) {
        this.setUsername(username);
        this.setCharacterType(characterType);
        this.setHashedPassword();
        this.setLevel(level);
        this.setSpecialPoints(specialPoints);
    }

    @Override
    public String getUsername() {
        return username;
    }

    @Override
    public String getHashedPassword() {
        return hashedPassword;
    }

    @Override
    public int getLevel() {
        return level;
    }

    @Override
    public T getSpecialPoints() {
        return specialPoints;
    }

    @Override
    public String getCharacterType() {
        return characterType;
    }

    @Override
    public String toString() {

        return String.format("\"%s\" | \"%s\" -> %s",
                this.getUsername(),
                this.getHashedPassword(),
                this.getCharacterType());
    }

    private void setUsername(String username) {
        this.username = username;
    }

    private void setHashedPassword() {
        if (this.characterType.equals("Demon")) {
            this.hashedPassword = Integer.toString(this.getUsername().length() * 217);
        } else if (this.characterType.equals("Archangel")) {
            this.hashedPassword = new StringBuilder(this.getUsername()).reverse().toString()
                    + Integer.toString(this.getUsername().length() * 21);
        } else {
            throw new IllegalArgumentException("Invalid character type");
        }
    }

    private void setLevel(int level) {
        this.level = level;
    }

    private void setSpecialPoints(T specialPoints) {
        this.specialPoints = specialPoints;
    }

    private void setCharacterType(String characterType) {
        this.characterType = characterType;
    }
}