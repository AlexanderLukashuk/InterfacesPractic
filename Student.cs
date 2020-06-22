namespace InterFacesPracticalWork
{
    public class Student : IStudent
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public int[] Grades { get; set; }

        public string GetName()
        {
            return Name;
        }
        public string GetFullname()
        {
            return FullName;
        }
        public double GetAvgGrade()
        {
            double result = 0;
            for (int i = 0; i < Grades.Length; i++)
            {
                result += Grades[i];
            }
            result /= Grades.Length;

            return result;
        }
    }
}