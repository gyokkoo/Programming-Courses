import java.util.Scanner;

public class _2_InstructionSet {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        String opCode = input.nextLine();

        while (!opCode.equals("END")) {
            String[] codeArgs = opCode.split(" ");

            long result = 0;
            switch (codeArgs[0]) {
                case "INC": {
                    long operandOne = Long.parseLong(codeArgs[1]);
                    result = operandOne + 1;
                    break;
                }
                case "DEC": {
                    long operandOne = Long.parseLong(codeArgs[1]);
                    result = operandOne - 1;
                    break;
                }
                case "ADD": {
                    long operandOne  = Long.parseLong(codeArgs[1]);
                    long operandTwo = Long.parseLong(codeArgs[2]);
                    result = operandOne + operandTwo;
                    break;
                }
                case "MLA": {
                    long operandOne  = Long.parseLong(codeArgs[1]);
                    long operandTwo = Long.parseLong(codeArgs[2]);
                    result = operandOne * operandTwo;
                    break;
                }
                default:
                    break;
            }
            opCode = input.nextLine();
            System.out.println(result);
        }
    }
}
