using System;

public class OnsiteStudent : CurrentStudent
{
    private int numberOfVisits;

    public OnsiteStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, int numberOfVisists)
        : base(firstName, lastName, age, studentNumber, averageGrade)
    {
        this.NumberOfVisits = numberOfVisits;
    }

    public int NumberOfVisits
    {
        get
        {
            return this.numberOfVisits;
        }

        set
        {
            this.numberOfVisits = value;
        }
    }
}
