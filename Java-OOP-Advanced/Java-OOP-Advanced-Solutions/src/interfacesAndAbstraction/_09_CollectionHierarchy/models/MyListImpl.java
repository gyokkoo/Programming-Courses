package interfacesAndAbstraction._09_CollectionHierarchy.models;

import interfacesAndAbstraction._09_CollectionHierarchy.interfaces.MyList;

import java.util.ArrayList;
import java.util.List;

public class MyListImpl<T> implements MyList<T> {

    private List<T> list;

    public MyListImpl() {
        this.list = new ArrayList<T>();
    }

    @Override
    public int add(T item) {
        this.list.add(0, item);
        return 0;
    }

    @Override
    public int getUsed() {
        return this.list.size();
    }

    @Override
    public T remove() {
        return this.list.remove(0);
    }
}
