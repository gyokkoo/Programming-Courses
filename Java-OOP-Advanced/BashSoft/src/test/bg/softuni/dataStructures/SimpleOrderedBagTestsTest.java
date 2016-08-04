package test.bg.softuni.dataStructures;

import main.bg.softuni.contracts.SimpleOrderedBag;
import main.bg.softuni.dataStructures.SimpleSortedList;
import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;

import java.util.ArrayList;
import java.util.List;

public class SimpleOrderedBagTestsTest {

    private SimpleOrderedBag<String> names;

    @Before
    public void setUp() {
        this.names = new SimpleSortedList<>(String.class);
    }

    @Test
    public void testEmptyConstructor() {
        this.names = new SimpleSortedList<>(String.class);
        Assert.assertEquals(16, this.names.capacity());
        Assert.assertEquals(0, this.names.size());
    }

    @Test
    public void testConstructorWithInitialCapacity() {
        this.names = new SimpleSortedList<>(String.class, 20);
        Assert.assertEquals(20, this.names.capacity());
        Assert.assertEquals(0, this.names.size());
    }

    @Test
    public void testConstructorWithInnitialComparer() {
        this.names = new SimpleSortedList<String>(String.class, String.CASE_INSENSITIVE_ORDER);
        Assert.assertEquals(16, this.names.capacity());
        Assert.assertEquals(0, this.names.size());
    }

    @Test
    public void testConstructorWithAllParams() {
        this.names = new SimpleSortedList<>(String.class, String.CASE_INSENSITIVE_ORDER, 30);
        Assert.assertEquals(30, this.names.capacity());
        Assert.assertEquals(0, this.names.size());
    }

    @Test
    public void testAddIncreaseSize() {
        this.names.add("George");

        int expected = 1;
        int actual = this.names.size();
        Assert.assertEquals(expected, actual);
    }

    @Test(expected = IllegalArgumentException.class)
    public void testAddNullThrowsException() {
        this.names.add(null);
    }

    @Test
    public void testAddUnsortedDataIsHeldSorted() {
        this.names.add("Rosen");
        this.names.add("Georgi");
        this.names.add("Balkan");

        String[] expected = {"Balkan", "Georgi", "Rosen"};
        String[] actual = new String[3];
        int index = 0;
        for (String name : names) {
            actual[index++] = name;
        }

        Assert.assertArrayEquals(expected, actual);
    }

    @Test
    public void testAddingMoreThanInitialCapacity() {
        int addElementsCount = 17;
        for (int i = 0; i < addElementsCount; i++) {
            this.names.add("Ivan");
        }

        Assert.assertEquals(addElementsCount, this.names.size());
        Assert.assertNotEquals(16, this.names.capacity());
    }

    @Test
    public void testAddingAllFromCollectionIncreaseSize() {
        List<String> namesToAdd = new ArrayList<>();
        namesToAdd.add("Alex");
        namesToAdd.add("Boris");

        this.names.addAll(namesToAdd);

        Assert.assertEquals(2, this.names.size());
    }

    @Test(expected = IllegalArgumentException.class)
    public void testAddingAllFromNullThrowsException() {
        this.names.addAll(null);
    }

    @Test
    public void testAddAllKeepsSorted() {
        List<String> unsortedNames = new ArrayList<>();
        unsortedNames.add("Gringo");
        unsortedNames.add("Zeus");
        unsortedNames.add("Antony");

        this.names.addAll(unsortedNames);

        String[] expectedSortedNames = {"Antony", "Gringo", "Zeus"};
        String[] actual = new String[3];
        int index = 0;
        for (String name : this.names) {
            actual[index++] = name;
        }

        Assert.assertArrayEquals(expectedSortedNames, actual);
    }

    @Test
    public void testRemoveValidElementsDecreaseSize() {
        int count = 100;
        for (int i = 0; i < count; i++) {
            this.names.add("Gosho " + i);
        }
        for (int i = 0; i < count; i++) {
            this.names.remove("Gosho " + i);
        }

        Assert.assertEquals(0, this.names.size());
    }

    @Test
    public void testRemoveValidElementRemovesSelectedOne() {
        String firstElement = "Ivan";
        String secondElement = "Nasko";
        this.names.add(firstElement);
        this.names.add(secondElement);

        this.names.remove(firstElement);
        boolean isFirstElementInCollection = false;
        for (String name : names) {
            if (firstElement.equals(name)) {
                isFirstElementInCollection = true;
            }
        }

        Assert.assertFalse(isFirstElementInCollection);
    }

    @Test(expected = IllegalArgumentException.class)
    public void testRemoveNullThrowsException() {
        this.names.remove(null);
    }

    @Test(expected = IllegalArgumentException.class)
    public void testJoinWithNull() {
        this.names.add("Peter");
        this.names.add("George");

        this.names.joinWith(null);
    }
}