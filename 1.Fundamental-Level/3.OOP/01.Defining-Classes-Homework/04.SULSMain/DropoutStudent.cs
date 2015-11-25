using System;

public class DropoutStudent : Student
{
    private string dropoutReason;

    public DropoutStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, string droputReason)
        : base(firstName, lastName, age, studentNumber, averageGrade)
    {
        this.DropoutReason = dropoutReason;
    }

    public string DropoutReason
    {
        get
        {
            return this.dropoutReason;
        }

        set
        {
            this.dropoutReason = value;
        }
    }

    public string Reaply()
    {
        string result = base.ToString() + Environment.NewLine + "Dropout reason: " + this.DropoutReason;

        return result;
    }
}
