using System;

public class SeniorTrainer : Trainer
{
    public SeniorTrainer(string firstName, string lastName, int age)
        : base(firstName, lastName, age)
    {
    }

    public string DeleteCourse(string courseName)
    {
        string result = "The course " + courseName + " has been deleted.";

        return result;
    }
}
