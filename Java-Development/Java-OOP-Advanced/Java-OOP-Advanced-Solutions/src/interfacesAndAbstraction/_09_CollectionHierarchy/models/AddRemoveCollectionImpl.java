package interfacesAndAbstraction._09_CollectionHierarchy.models;

import interfacesAndAbstraction._09_CollectionHierarchy.interfaces.AddRemoveCollection;

import java.util.ArrayList;
import java.util.List;

public class AddRemoveCollectionImpl<T> implements AddRemoveCollection<T> {

    private List<T> list;

    public AddRemoveCollectionImpl() {
        this.list = new ArrayList<T>();
    }

    @Override
    public int add(T item) {
        this.list.add(0, item);

        return 0;
    }

    @Override
    public T remove() {
        int lastIndex = this.list.size() - 1;

        return this.list.remove(lastIndex);
    }
}
