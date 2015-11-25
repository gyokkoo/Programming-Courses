using System;

public class Person
{
    public string name;
    public int age;
    public string email;

    public Person(string name, int age)
        : this(name, age, null)
    {
    }

    public Person(string name, int age, string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public string Name
    {
        get
        {
            return this.name;
        }

        set
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("The name cannot be empty string!", "name");
            }

            this.name = value;
        }
    }

    public int Age
    {
        get { return this.age; }
        set
        {
            if (value < 1 || value > 100)
            {
                throw new ArgumentException("The age should be in the range [1... 100]!", "age");
            }

            this.age = value;
        }
    }

    public string Email
    {
        get { return this.email; }
        set
        {
            if (!String.IsNullOrEmpty(value) && !value.Contains("@"))
            {
                throw new ArgumentException("Invalid email!", "email");
            }

            this.email = value;
        }
    }

    public override string ToString()
    {
        string result;

        if (this.Email != null)
        {
            result = string.Format(
            "1.Name -> {0} \n2.Age -> {1} \n3.Email -> {2}",
            this.Name, this.Age, this.Email);
        }
        else
        {
            result = string.Format(
            "1.Name -> {0} \n2.Age -> {1}",
            this.Name, this.Age);
        }

        return result;
    }
}
