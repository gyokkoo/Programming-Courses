package inheritance._02_BookShop;

import java.lang.instrument.IllegalClassFormatException;
import java.lang.reflect.Method;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) throws IllegalClassFormatException {
        try {
            Scanner scanner = new Scanner(System.in);
            String author = scanner.nextLine();
            String title = scanner.nextLine();
            Double price = Double.valueOf(scanner.nextLine());
            Book book = new Book(author,
                    title,
                    price);

            GoldenEditionBook goldenEditionBook = new GoldenEditionBook(author,
                    title,
                    price);

            Method[] bookDeclaredMethods = Book.class.getDeclaredMethods();
            Method[] goldenBookDeclaredMethods = GoldenEditionBook.class.getDeclaredMethods();
            if (goldenBookDeclaredMethods.length > 1) {
                throw new IllegalClassFormatException("Code duplication in GoldenEditionBook!");
            }
            System.out.println(book.toString());
            System.out.println(goldenEditionBook.toString());
        } catch (IllegalArgumentException error) {
            System.out.println(error.getMessage());
        }
    }
}
