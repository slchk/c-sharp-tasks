using System;
class Student {
    //Fields
    public string Name {get; set;}
    public string Group {get; set;} 
    public int DiplomaGrade {get; set;}

    //Constructor
    public Student(string name, string group, int diplomaGrade)
    {
        Name = name;
        Group = group;
        DiplomaGrade = diplomaGrade;
    }
    
    public void PrintInfo()
    {
        Console.WriteLine($"Student: {this.Name}, Group: {this.Group}, Diploma Grade: {this.DiplomaGrade}");
    }
}

class Program
{
    static void Main()
    {
        // Creating an array of 14 students
        Student[] students = new Student[14];

        // Filling the array in a loop
        for (int i = 0; i < students.Length; i++)
        {
            // For simplicity, using generic names and groups
            string studentName = $"Student｛i + 1｝";
            string studentGroup = $"GroupA";
            int studentDiplomaGrade = new Random().Next(60, 101); // Random grade between 60 and 100

            // Creating a new student and adding it to the array
            students[i] = new Student(studentName, studentGroup, studentDiplomaGrade);
        }
        
        // Outputting the student information
        // Excelent students only
        foreach (var student in students)
        {
            if (student.DiplomaGrade  >= 90)
            {
                student.PrintInfo();
            }
        }
    }
}