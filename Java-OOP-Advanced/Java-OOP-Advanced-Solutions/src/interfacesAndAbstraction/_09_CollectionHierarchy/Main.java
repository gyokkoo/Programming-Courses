package interfacesAndAbstraction._09_CollectionHierarchy;

import interfacesAndAbstraction._09_CollectionHierarchy.interfaces.AddCollection;
import interfacesAndAbstraction._09_CollectionHierarchy.interfaces.AddRemoveCollection;
import interfacesAndAbstraction._09_CollectionHierarchy.interfaces.MyList;
import interfacesAndAbstraction._09_CollectionHierarchy.models.AddCollectionImpl;
import interfacesAndAbstraction._09_CollectionHierarchy.models.AddRemoveCollectionImpl;
import interfacesAndAbstraction._09_CollectionHierarchy.models.MyListImpl;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        AddCollection<String> addCollection = new AddCollectionImpl<>();
        AddRemoveCollection<String> addRemoveCollection = new AddRemoveCollectionImpl<>();
        MyList<String> myList = new MyListImpl<String>();

        String[] elementsToAdd = reader.readLine().split(" ");

        addElementsToCollection(addCollection, elementsToAdd);
        addElementsToCollection(addRemoveCollection, elementsToAdd);
        addElementsToCollection(myList, elementsToAdd);

        int amountOfRemoveOperations = Integer.parseInt(reader.readLine());
        removeFromCollection(addRemoveCollection, amountOfRemoveOperations);
        removeFromCollection(myList, amountOfRemoveOperations);
    }

    private static void addElementsToCollection(AddCollection<String> collection, String[] elementsToAdd) {
        for (String element : elementsToAdd) {
            System.out.print(collection.add(element) + " ");
        }

        System.out.println();
    }

    private static void removeFromCollection(AddRemoveCollection<String> collection, int n) {
        for (int i = 0; i < n; i++) {
            System.out.print(collection.remove() + " ");
        }

        System.out.println();
    }
}
