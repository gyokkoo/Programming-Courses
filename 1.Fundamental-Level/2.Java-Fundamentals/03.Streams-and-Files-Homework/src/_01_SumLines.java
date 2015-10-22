import java.io.*;

public class _01_SumLines {

    public static void main(String[] args) {
        try (
            BufferedReader bfr = new BufferedReader(
                                      new FileReader("resources/_01_SumLines/lines.txt"))
        ) {
            String line;
            while((line = bfr.readLine())!= null) {
                int asciiSum = 0;
                for (int i = 0; i < line.length(); i++) {
                    asciiSum += line.charAt(i);
                }
                System.out.println(asciiSum);
            }
        } catch (IOException ioe) {
            System.out.println(ioe.toString());
        }
    }
}
