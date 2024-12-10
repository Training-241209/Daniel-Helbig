namespace GPA;

class Program
{
    static void Main(string[] args)
    {
        string student = "Sophia Johnson";
        string course1 = "English 101";
        string course2 = "Algebra 101";
        string course3 = "Biology 101";
        string course4 = "Computer Science I";
        string course5 = "Psychology 101";

        int course1Credit = 3;
        int course2Credit = 3;
        int course3Credit = 4;
        int course4Credit = 4;
        int course5Credit = 3;

        int gradeA = 4;
        int gradeB = 3;

        int course1Grade = gradeA;
        int course2Grade = gradeB;
        int course3Grade = gradeB;
        int course4Grade = gradeB;
        int course5Grade = gradeA;

        int totalCreditHours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;

        int totalGradePoints = course1Credit * course1Grade + course2Credit * course2Grade + course3Credit * course3Grade + course4Credit * course4Grade + course5Credit * course5Grade;

        decimal gradePointAverage = (decimal)totalGradePoints/totalCreditHours;
        string gpaString = string.Format("{0:0.##}", gradePointAverage);

        Console.WriteLine($"Student: {student}\n");
        Console.WriteLine("Course\t\t\tGrade\tCredit Hours");

        Console.WriteLine($"{course1}\t\t{course1Grade}\t{course1Credit}");
        Console.WriteLine($"{course2}\t\t{course2Grade}\t{course2Credit}");
        Console.WriteLine($"{course3}\t\t{course3Grade}\t{course3Credit}");
        Console.WriteLine($"{course4}\t{course4Grade}\t{course4Credit}");
        Console.WriteLine($"{course5}\t\t{course5Grade}\t{course5Credit}");

        Console.WriteLine($"\nFinal GPA:\t\t{gpaString}");
    }
}
