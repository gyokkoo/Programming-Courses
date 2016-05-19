package _07_BalancedParentheses;

import java.util.Scanner;
import java.util.Stack;

public class BalancedParentheses {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String parentheses = scanner.nextLine();
        Stack<Character> stack = new Stack<>();
        for (int i = 0; i < parentheses.length(); i++) {
            char currentBracket = parentheses.charAt(i);
            if (currentBracket == '(' || currentBracket == '{' || currentBracket == '[') {
                stack.push(currentBracket);
            } else {
                if (stack.size() == 0) {
                    System.out.println("NO");
                    return;
                }

                char lastBracket = stack.pop();
                if ((lastBracket != '(' || currentBracket != ')') &&
                        (lastBracket != '[' || currentBracket != ']') &&
                        (lastBracket != '{' || currentBracket != '}')) {
                    System.out.println("NO");
                    return;
                }
            }
        }

        System.out.println("YES");
    }
}