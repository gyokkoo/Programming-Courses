package interfacesAndAbstraction._09_CollectionHierarchy.models;

import interfacesAndAbstraction._09_CollectionHierarchy.interfaces.AddCollection;

import java.util.ArrayList;
import java.util.List;

public class AddCollectionImpl<T> implements AddCollection<T> {

    private List<T> list;

    public AddCollectionImpl() {
        this.list = new ArrayList<T>();
    }

    public int add(T item) {
        this.list.add(item);

        return this.list.size() - 1;
    }
}
