package generics._09_CustomListIterator.models;

import generics._09_CustomListIterator.interfaces.CustomList;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Iterator;
import java.util.List;

public class CustomListImpl<T extends Comparable<T>> implements CustomList<T> {

    private List<T> elements;

    public CustomListImpl() {
        this.elements = new ArrayList<T>();
    }

    @Override
    public void add(T element) {
        this.elements.add(element);
    }

    @Override
    public T remove(int index) {
        return this.elements.remove(index);
    }

    @Override
    public boolean contains(T element) {
        return this.elements.contains(element);
    }

    @Override
    public void swap(int firstIndex, int secondIndex) {
        Collections.swap(this.elements, firstIndex, secondIndex);
    }

    @Override
    public int countGreaterThat(T element) {
        int counter = 0;
        for (T currentElement : elements) {
            if (currentElement.compareTo(element) > 0) {
                counter++;
            }
        }

        return counter;
    }

    @Override
    public T getMax() {
        T maxElement = this.elements.get(0);
        for (int i = 1; i < this.elements.size(); i++) {
            if (this.elements.get(i).compareTo(maxElement) > 0) {
                maxElement = this.elements.get(i);
            }
        }

        return maxElement;
    }

    @Override
    public T getMin() {
        T minElement = this.elements.get(0);
        for (int i = 1; i < this.elements.size(); i++) {
            if (this.elements.get(i).compareTo(minElement) < 0) {
                minElement = this.elements.get(i);
            }
        }

        return minElement;
    }

    public int getSize() {
        return this.elements.size();
    }

    @Override
    public T get(int index) {
        return this.elements.get(index);
    }

    @Override
    public String toString() {
        StringBuilder builder = new StringBuilder();
        for (T element : elements) {
            builder.append(element).append(System.lineSeparator());
        }

        return builder.toString();
    }

    @Override
    public Iterator<T> iterator() {
        return new Iterator<T>() {
            private int index = 0;

            @Override
            public boolean hasNext() {
                return index < elements.size();
            }

            @Override
            public T next() {
                return elements.get(index++);
            }
        };
    }
}
