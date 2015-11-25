using System;

public class OnlineStudent : CurrentStudent
{
    public OnlineStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade)
        : base(firstName, lastName, age, studentNumber, averageGrade)
    {
    }
}