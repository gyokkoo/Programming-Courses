package reflection._01_HarvestingFields;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.lang.reflect.Field;
import java.lang.reflect.Modifier;

public class Main {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        Field[] fields = RichSoilLand.class.getDeclaredFields();
        while (true) {
            String command = reader.readLine();
            if (command.equals("HARVEST")) {
                break;
            }

            for (Field field : fields) {
                int mod = field.getModifiers();
                String modString = Modifier.toString(mod);

                if (modString.equals(command) || command.equals("all")) {
                    System.out.printf("%s %s %s%n",
                            Modifier.toString(mod), field.getType().getSimpleName(), field.getName());
                }
            }
        }
    }
}
