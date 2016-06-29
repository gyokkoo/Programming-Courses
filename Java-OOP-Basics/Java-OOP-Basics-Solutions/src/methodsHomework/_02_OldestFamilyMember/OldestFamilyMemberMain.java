package methodsHomework._02_OldestFamilyMember;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.lang.reflect.Method;

public class OldestFamilyMemberMain {

    public static void main(String[] args) throws NoSuchMethodException, IOException {
        Method getOldestMethod = Family.class.getMethod("getOldestMember");
        Method addMemberMethod = Family.class.getMethod("addFamilyMember", Person.class);

        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        Family family = new Family();
        int n = Integer.parseInt(reader.readLine());
        for (int i = 0; i < n; i++) {
            String[] tokens = reader.readLine().split(" ");
            String personName = tokens[0];
            int personAge = Integer.parseInt(tokens[1]);
            Person person = new Person(personName, personAge);
            family.addFamilyMember(person);
        }

        System.out.println(family.getOldestMember());
    }
}
