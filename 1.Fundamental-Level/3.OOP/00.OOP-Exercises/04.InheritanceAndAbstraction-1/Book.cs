using System;
using System.Text;

public class Book
{
    string title;
    string author;
    decimal price;

    public Book(string title, string author, decimal price)
    {
        this.Title = title;
        this.Author = author;
        this.Price = price;
    }

    public string Title
    {
        get
        {
            return this.title;
        }

        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("title", "Title cannot be null");
            }

            this.title = value;
        }
    }

    public string Author
    {
        get
        {
            return this.author;
        }

        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("author", "Author cannot be null");
            }

            this.author = value;
        }
    }

    public virtual decimal Price
    {
        get
        {
            return this.price;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("The price cannot be negative.");
            }

            this.price = value;
        }
    }

    public override string ToString()
    {
        StringBuilder output = new StringBuilder();

        output.AppendFormat("- Type: {0}{1}", this.GetType().Name, Environment.NewLine);
        output.AppendFormat("- Title: {0}{1}", this.Title, Environment.NewLine);
        output.AppendFormat("- Author {0}{1}", this.Author, Environment.NewLine);
        output.AppendFormat("- Price: {0:F2}{1}", this.Price, Environment.NewLine);

        return output.ToString();
    }
}

