package _10_SimpleTextEditor;

import java.util.Scanner;
import java.util.Stack;

public class TextEditor {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int numberOfOperations = scanner.nextInt();

        Stack<String> texts = new Stack<>();
        for (int i = 0; i < numberOfOperations; i++) {
            int commandType = scanner.nextInt();
            String text = texts.size() > 0 ? texts.peek() : "";

            switch (commandType) {
                case 1:
                    String str = scanner.next();
                    texts.push(text + str);
                    break;
                case 2:
                    int count = scanner.nextInt();
                    String newStr = text.substring(0, text.length() - count);
                    texts.push(newStr);
                    break;
                case 3:
                    int index = scanner.nextInt() - 1;
                    System.out.println(text.charAt(index));
                    break;
                case 4:
                    texts.pop();
                    break;
            }
        }
    }
}
