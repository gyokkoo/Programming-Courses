package generics._09_CustomListIterator.interfaces;

public interface Sorter<T extends Comparable<T>> {

    void sort(CustomList<T> elements);
}
