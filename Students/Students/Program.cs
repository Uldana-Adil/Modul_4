using System;
using System.Linq;

struct Students
{
    public string Name;
    public string GroupNumber;
    public int[] Grades;

    public double AverageGrade
    {
        get { return Grades.Average(); }
    }

    public Students(string name, string groupNumber, int[] grades)
    {
        Name = name;
        GroupNumber = groupNumber;
        Grades = grades;
    }
}

class Program
{
    static void Main()
    {
        Students[] students = new Students[10];
        students[0] = new Students("Уалихан Ерасыл", "Группа 1", new int[] { 5, 4, 4, 5, 5 });
        students[1] = new Students("Нусуп Дамир", "Группа 2", new int[] { 4, 3, 4, 3, 4 });
        students[2] = new Students("Наширов Жаксыбек", "Группа 1", new int[] { 5, 5, 5, 4, 5 });
        students[3] = new Students("Оразов Асхат", "Группа 2", new int[] { 4, 4, 4, 4, 3 });
        students[4] = new Students("Константин Иван", "Группа 1", new int[] { 5, 5, 5, 5, 5 });
        students[5] = new Students("Кошек Аружан", "Группа 2", new int[] { 3, 3, 4, 4, 3 });
        students[6] = new Students("Нурпеисова Каракат", "Группа 1", new int[] { 4, 4, 5, 4, 5 });
        students[7] = new Students("Ахметова Дильназ", "Группа 2", new int[] { 5, 5, 4, 5, 4 });
        students[8] = new Students("Жумагалым Бауыржан", "Группа 1", new int[] { 4, 4, 3, 4, 3 });
        students[9] = new Students("Тажиев Бекзат", "Группа 2", new int[] { 5, 5, 5, 5, 5 });

        Array.Sort(students, (s1, s2) => s1.AverageGrade.CompareTo(s2.AverageGrade));

        Console.WriteLine("Студенты с оценками 4 или 5:");
        foreach (var student in students)
        {
            if (student.Grades.All(grade => grade >= 4))
            {
                Console.WriteLine($"{student.Name}, {student.GroupNumber}");
            }
        }
    }
}
