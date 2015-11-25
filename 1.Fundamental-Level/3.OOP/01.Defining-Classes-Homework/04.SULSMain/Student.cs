using System;

public class Student : Person
{
    private int studentNumber;
    private double averageGrade;

    public Student(string firstName, string lastName, int age, int studentNumber, double averageGrade)
        : base(firstName, lastName, age)
    {
        this.StudentNumber = studentNumber;
        this.AverageGrade = averageGrade;
    }

    public int StudentNumber
    {
        get
        {
            return this.studentNumber;
        }

        set
        {
            this.studentNumber = value;
        }
    }

    public double AverageGrade
    {
        get
        {
            return this.averageGrade;
        }

        set
        {
            this.averageGrade = value;
        }
    }

    public override string ToString()
    {
        string result = String.Format(
            "{0} {1} -> {2}",
            this.FirstName, this.LastName, this.AverageGrade);

        return result;
    }
}
