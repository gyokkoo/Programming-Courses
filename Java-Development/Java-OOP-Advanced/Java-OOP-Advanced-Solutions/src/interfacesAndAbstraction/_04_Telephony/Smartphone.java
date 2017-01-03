package interfacesAndAbstraction._04_Telephony;

public class Smartphone implements CellPhone, Browsable {

    @Override
    public void browseInWeb(String url) {
        if (url.matches(".*\\d+.*")) {
            throw new IllegalArgumentException("Invalid URL!");
        }

        System.out.println("Browsing: " + url + "!");
    }

    @Override
    public void callOtherPhone(String number) {
        if (!number.matches("^\\d+$")) {
            throw new IllegalArgumentException("Invalid number!");
        }

        System.out.println("Calling... " + number);
    }
}
