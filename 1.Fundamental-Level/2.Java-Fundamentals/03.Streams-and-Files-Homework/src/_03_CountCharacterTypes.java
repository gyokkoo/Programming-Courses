import java.io.*;
import java.io.IOException;

public class _03_CountCharacterTypes {

    public static void main(String[] args) {
        int vowelsCount = 0;
        int consonantsCount = 0;
        int puncutationCount = 0;

        try(
            BufferedReader bfr = new BufferedReader(
                                    new FileReader("resources/_03_CountCharacterTypes/words.txt"))
        ) {
            String line;
            while((line = bfr.readLine()) != null) {
                line = line.toLowerCase().replace(" ", "");
                for (int i = 0; i < line.length(); i++) {
                    if(line.charAt(i) == 'a' || line.charAt(i) == 'e' || line.charAt(i) == 'i' ||
                            line.charAt(i) == 'o' ||  line.charAt(i) == 'u') {
                        vowelsCount++;
                    } else if(line.charAt(i) == '!' || line.charAt(i) == ',' ||
                            line.charAt(i) == '.' || line.charAt(i) == '?') {
                        puncutationCount++;
                    } else {
                        consonantsCount++;
                    }
                }
            }
        } catch(IOException ex) {
            System.out.println(ex.toString());
        }

        try(PrintWriter pw = new PrintWriter(
                                new FileWriter("resources/_03_CountCharacterTypes/count-chars.txt"))
        ) {
            pw.write(String.format("Vowels:%d%n", vowelsCount));
            pw.write(String.format("Consonants:%d%n", consonantsCount));
            pw.write(String.format("Punctuation:%d%n", puncutationCount));

            System.out.println("Vowels:" + vowelsCount);
            System.out.println("Consonants:" + consonantsCount);
            System.out.println("Punctuation:" + puncutationCount);

        } catch(IOException ex) {
            System.out.println(ex.toString());
        }
    }
}
