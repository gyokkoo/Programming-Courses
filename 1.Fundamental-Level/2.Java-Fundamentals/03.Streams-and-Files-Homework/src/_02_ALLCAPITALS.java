import java.io.*;
import java.util.ArrayList;

public class _02_ALLCAPITALS {

    public static void main(String[] args) {
        ArrayList<String> upperCaseLines = new ArrayList<>();

        try (BufferedReader bfr = new BufferedReader(
                                    new FileReader("resources/_02_ALLCAPITALS/lines.txt"))
        ) {
            String line;
            while((line = bfr.readLine()) != null) {
                upperCaseLines.add(line.toUpperCase());
            }
        } catch (IOException ex) {
            System.out.println(ex.toString());
        }

        try(PrintWriter pw = new PrintWriter(
                                new FileWriter("resources/_02_ALLCAPITALS/lines-output.txt"))
        ) {
            for (int i = 0; i < upperCaseLines.size(); i++) {
                pw.write(upperCaseLines.get(i) + "\n");
                System.out.println(upperCaseLines.get(i));
            }
        } catch (IOException ex) {
            System.out.println(ex.toString());
        }
    }
}
