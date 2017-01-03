package inheritance._02_BookShop;

public class Book {
    private String title;
    private String author;
    private Double price;

    public Book(String author, String title, Double price) {
        this.setAuthor(author);
        this.setTitle(title);
        this.setPrice(price);
    }

    private void setAuthor(String author) {
        String[] names = author.split("\\s+");
        if (names.length > 1 && Character.isDigit(names[1].charAt(0))) {
            throw new IllegalArgumentException("Author not valid!");
        }

        this.author = author;
    }

    private void setTitle(String title) {
        if (title == null || title.length() < 3) {
            throw new IllegalArgumentException("Title not valid!");
        }

        this.title = title;
    }

    private void setPrice(Double price) {
        if (price < 1) {
            throw new IllegalArgumentException("Price not valid!");
        }

        this.price = price;
    }

    public String getTitle() {
        return title;
    }

    public String getAuthor() {
        return author;
    }

    public Double getPrice() {
        return price;
    }

    @Override
    public String toString() {
        final StringBuilder sb = new StringBuilder();
        sb.append("Type: ").append(this.getClass().getSimpleName())
                .append(System.lineSeparator())
                .append("Title: ").append(this.getTitle())
                .append(System.lineSeparator())
                .append("Author: ").append(this.getAuthor())
                .append(System.lineSeparator())
                .append("Price: ").append(this.getPrice())
                .append(System.lineSeparator());

        return sb.toString();
    }
}
