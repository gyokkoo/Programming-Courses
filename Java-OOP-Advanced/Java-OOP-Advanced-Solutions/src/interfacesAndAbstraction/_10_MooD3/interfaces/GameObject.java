package interfacesAndAbstraction._10_MooD3.interfaces;

public interface GameObject<T> {

    String getUsername();

    String getHashedPassword();

    int getLevel();

    T getSpecialPoints();

    String getCharacterType();
}
