HashSet<int> studentsCourseA = new HashSet<int>();
HashSet<int> studentsCourseB = new HashSet<int>();
HashSet<int> studentsCourseC = new HashSet<int>();

Console.Write("How many students for course A: ");
int numberStudentsCourseA = int.Parse(Console.ReadLine());

for (int i = 1; i <= numberStudentsCourseA; i++)
{
    Console.Write($"Enter code student #{i}: ");
    studentsCourseA.Add(int.Parse(Console.ReadLine()));
}

Console.Write("How many students for course B: ");
int numberStudentsCourseB = int.Parse(Console.ReadLine());

for (int i = 1; i <= numberStudentsCourseB; i++)
{
    Console.Write($"Enter code student #{i}: ");
    studentsCourseB.Add(int.Parse(Console.ReadLine()));
}

Console.Write("How many students for course C: ");
int numberStudentsCourseC = int.Parse(Console.ReadLine());

for (int i = 1; i <= numberStudentsCourseC; i++)
{
    Console.Write($"Enter code student #{i}: ");
    studentsCourseC.Add(int.Parse(Console.ReadLine()));
}

HashSet<int> allStudents = new HashSet<int>(studentsCourseA);
allStudents.UnionWith(studentsCourseB);
allStudents.UnionWith(studentsCourseC);
Console.Write("Total students: " + allStudents.Count);