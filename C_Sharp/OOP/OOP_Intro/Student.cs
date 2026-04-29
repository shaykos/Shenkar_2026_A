using System;

namespace OOP_Intro;

public class Student
{
    #region תכונות

    private string fullName;
    private int age;
    private double[] grades;

    #endregion

    #region פעולות Set/Get

    public void SetName(string fullName)
    {
        // בדיקה אם השם מכיל לפחות שתי מילים
        if (fullName.Split(' ').Length >= 2)
            this.fullName = fullName;
        else
        {
            Console.WriteLine("full name must contain at least two words");
            this.fullName = "Unknown";
        }
    }

    public string GetName()
    {
        return fullName;
    }

    public void SetAge(int age)
    {
        // בדיקה אם הגיל הוא מספר חיובי
        if (age > 0 && age < 120)
            this.age = age;
        else
        {
            Console.WriteLine("age must be a positive number and less than 120");
            this.age = 0;
        }
    }

    public int GetAge()
    {
        return age;
    }

    public void SetGrades(double[] grades)
    {
        this.grades = grades;
    }

    public double[] GetGrades()
    {
        return grades;
    }

    #endregion

    #region בנאים

    public Student(string fullName, int age) : this(fullName, age, 0)
    {
        
    }

    public Student(string fullName, int age, int gradeCount)
    {
        SetName(fullName);
        SetAge(age);
        grades = new double[gradeCount];
    }

    public Student(string fullName, int age, double[] grades)
    {
        SetName(fullName);
        SetAge(age);
        SetGrades(grades);
    }

    #endregion

    #region פעולות נוספות   

    public double GetAverageGrade()
    {
        if (grades == null || grades.Length == 0)
            return 0;

        double sum = 0;
        foreach (double grade in grades)
            sum += grade;

        return sum / grades.Length;
    }

    #endregion
}
