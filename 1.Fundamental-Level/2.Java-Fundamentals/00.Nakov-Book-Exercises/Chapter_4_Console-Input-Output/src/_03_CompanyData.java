import java.util.Scanner;

public class _03_CompanyData {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter company's name: ");
        String companyName = scanner.nextLine();
        System.out.print("Enter company's address: ");
        String companyAddress = scanner.nextLine();
        System.out.print("Enter company's phone: ");
        String companyPhone = scanner.nextLine();
        System.out.print("Enter company's fax number: ");
        String companyFaxNumber = scanner.nextLine();
        System.out.print("Enter company's website: ");
        String companyWebSite = scanner.nextLine();
        System.out.print("Enter manager's first name: ");
        String managerFirstName = scanner.nextLine();
        System.out.print("Enter manager's last name: ");
        String managerLastName = scanner.nextLine();

        System.out.printf("Company name %s \n", companyName);
        System.out.printf("Company address %s \n", companyAddress);
        System.out.printf("Company phone %s \n", companyPhone);
        System.out.printf("Company fax number %s \n", companyFaxNumber);
        System.out.printf("Company website %s \n", companyWebSite);
        System.out.printf("Manager first name %s \n", managerFirstName);
        System.out.printf("Manager last name %s \n", managerLastName);
    }
}
