using System;
using System.Text.RegularExpressions;

namespace struct_lab_student
{
    struct Student
    {
        const char SEPARATOR = ' ';

        public string surName;
        public string firstName;
        public string patronymic;
        public char sex;
        public string dateOfBirth;
        public char mathematicsMark;
        public char physicsMark;
        public char informaticsMark;
        public int scholarship;

        public Student(string lineWithAllData)
        {
            var regex = new Regex(@"\s+");
            lineWithAllData = regex.Replace(lineWithAllData, SEPARATOR.ToString());
            var splited = lineWithAllData.Split(SEPARATOR);

            surName = splited[0];
            firstName = splited[1];
            patronymic = splited[2];
            sex = splited[3][0];
            dateOfBirth = splited[4];
            mathematicsMark = splited[5][0];
            physicsMark = splited[6][0];
            informaticsMark = splited[7][0];
            scholarship = Convert.ToInt32(splited[8]);
        }

        public int MathematicsMark => ParseMark(mathematicsMark);
        public int PhysicsMark => ParseMark(physicsMark);
        public int InformaticsMark => ParseMark(informaticsMark);
        public double AverageMark => (MathematicsMark + PhysicsMark + InformaticsMark) / 3.0;
        

        private static int ParseMark(char mark)
        {
            bool result = int.TryParse(mark.ToString(), out var intMark);
            return result ? intMark : 2;
        }
    }
}
