import java.io.*;

public class _04_CopyJpgFile {

    public static void main(String[] args) {
        try(BufferedInputStream bfr = new BufferedInputStream(
                                    new FileInputStream("resources/_04_CopyJpgFile/rules.jpg"));
            BufferedOutputStream bfw = new BufferedOutputStream(
                                    new FileOutputStream("resources/_04_CopyJpgFile/my-copied-picture.jpg"))
        ){
            int i;
            while((i = bfr.read()) != -1) {
                bfw.write(i);
            }
        } catch(IOException ex) {
            System.out.println(ex.toString());
        }
    }
}