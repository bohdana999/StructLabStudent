using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace struct_lab_student
{
    partial class Program
    {
        static Student[] ReadData(string fileName)
        {
            string[] lines = File.Exists(fileName) ? File.ReadAllLines(fileName) : new string[0];
            var students = new Student[lines.Length];
            for (var i = 0; i < students.Length; i++)
            {
                students[i] = new Student(lines[i]);
            }
            return students;
        }

        static void runMenu(Student[] studs)
        {
            for (var i = 0; i < studs.Length; i++)
            {
                if (studs[i].InformaticsMark == 5)
                {
                    Console.WriteLine(studs[i].surName + " " + studs[i].AverageMark);
                }
            }
        }

        static void Main(string[] args)
        {
            Student[] studs = ReadData("input.txt");
            runMenu(studs);
        }
    }
}
