import java.io.*;
import java.util.ArrayList;
import java.util.List;

public class _05_SaveArrayList {

    public static void main(String[] args) {
        List<Double> numbers = new ArrayList<>();
        for (double i = 1.5; i <= 10; i++) {
            numbers.add(i*i);
        }

        saveList(numbers);

        loadList();
    }

    private static void saveList(List<Double> numbers) {
        try (ObjectOutputStream oos = new ObjectOutputStream(
                                        new FileOutputStream(
                                            new File("resources/_05_SaveArrayList/doubles.list")))
        ) {
            oos.writeObject(numbers);
        } catch(IOException ex) {
            System.out.println(ex.toString());
        }
    }

    private static void loadList() {
        try(ObjectInputStream ois = new ObjectInputStream(
                new FileInputStream("resources/_05_SaveArrayList/doubles.list"))
        ) {
            List<Double> loadedList = (List<Double>) ois.readObject();
            for (int i = 0; i < loadedList.size(); i++) {
                System.out.print(loadedList.get(i) + " ");
            }
        } catch(IOException | ClassNotFoundException ex) {
            System.out.println(ex.toString());
        }
    }
}
