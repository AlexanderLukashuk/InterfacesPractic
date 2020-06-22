using System;

namespace InterFacesPracticalWork
{
    public interface IStudent
    {
        string Name { get; set; }
        string FullName { get; set; }
        int[] Grades { get; set; }

        string GetName();
        string GetFullname();
        double GetAvgGrade();
    }
}