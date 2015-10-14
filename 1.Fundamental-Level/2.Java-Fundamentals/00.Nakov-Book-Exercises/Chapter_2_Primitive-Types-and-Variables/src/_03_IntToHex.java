public class _03_IntToHex {

    public static void main(String[] args) {
        int integerNum = 256;
        String hexNum = Integer.toHexString(integerNum);

        System.out.println(hexNum);
    }
}