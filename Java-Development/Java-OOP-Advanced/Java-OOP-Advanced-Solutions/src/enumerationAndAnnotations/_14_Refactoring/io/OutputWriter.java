package enumerationAndAnnotations._14_Refactoring.io;

import enumerationAndAnnotations._14_Refactoring.interfaces.Writer;

public class OutputWriter implements Writer {

    @Override
    public void writeLine(String message) {
        System.out.println(message);
    }
}
