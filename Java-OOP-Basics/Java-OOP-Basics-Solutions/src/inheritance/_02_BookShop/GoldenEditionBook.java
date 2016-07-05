package inheritance._02_BookShop;

public class GoldenEditionBook extends Book {

    public GoldenEditionBook(String title, String author, Double price) {
        super(title, author, price);
    }

    @Override
    public Double getPrice() {
        return super.getPrice() + super.getPrice() * 0.3;
    }
}
