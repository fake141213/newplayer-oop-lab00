using System;
using System.Collections.Generic;
using System.Linq;

public class Item
{
    private static List<double> allGrades = new List<double>();
    private List<double> personalGrades = new List<double>();

    public Item(string subject, double grade)
    {
        personalGrades.Add(grade);
        allGrades.Add(grade);
    }

    public static double GetGPA()
    {
        return allGrades.Count > 0 ? allGrades.Average() : 0.00;
    }

    public static int GetTotalStudents()
    {
        return allGrades.Count;
    }

    public static double GetMaxScore()
    {
        return allGrades.Count > 0 ? allGrades.Max() : 0.00;
    }

    public static double GetMinScore()
    {
        return allGrades.Count > 0 ? allGrades.Min() : 4.00;
    }
}
