package enumerationAndAnnotations._14_Refactoring;

import enumerationAndAnnotations._14_Refactoring.core.Engine;
import enumerationAndAnnotations._14_Refactoring.core.WeaponFactory;
import enumerationAndAnnotations._14_Refactoring.core.WeaponsRepository;
import enumerationAndAnnotations._14_Refactoring.interfaces.Reader;
import enumerationAndAnnotations._14_Refactoring.interfaces.Repository;
import enumerationAndAnnotations._14_Refactoring.interfaces.Runnable;
import enumerationAndAnnotations._14_Refactoring.interfaces.Writer;
import enumerationAndAnnotations._14_Refactoring.io.InputReader;
import enumerationAndAnnotations._14_Refactoring.io.OutputWriter;

import java.io.IOException;

public class Main {

    public static void main(String[] args) throws IOException {

        Reader reader = new InputReader();
        Writer writer = new OutputWriter();
        Repository weaponsRepository = new WeaponsRepository();
        WeaponFactory factory = new WeaponFactory();

        Runnable engine = new Engine(weaponsRepository, factory, reader, writer);
        engine.run();
    }
}