package generics._08_CustomListSorter.interfaces;

public interface Sorter<T extends Comparable<T>> {

    void sort(CustomList<T> elements);
}
