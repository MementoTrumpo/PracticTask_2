using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracnicTask_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student_1 = new Student("Гарик Бульдог Харламов", 40, "garik_kharlamov@gmail.com", 98, 100, 97);
            Student student_2 = new Student("Джим Керри", 60, "Jim_Kerry@gmail.com", 99, 97, 100);
            List<Student> students = new List<Student>();
            students.Add(student_1);
            students.Add(student_2);

            foreach(var st in students)
            {
                Student.PrintingInformation(st);
                Console.WriteLine();
            }


            Console.WriteLine(Student.ArithmeticMeanCounting(student_1));
         

            Console.ReadKey();

        }

   
        /// <summary>
        /// Класс студента, обучающегося в SkillBox
        /// </summary>
        class Student
        {
            public string FullName { get; set; }//Полное имя

            public short Age { get; set; }//Возраст

            public string eMail { get; set; }//eMail студента

            public int ProgrammingScores { get; set; }//Баллы по программированию

            public int MathematicScores { get; set; }//Баллы по математике

            public int PhysicScores { get; set; }//Баллы по физике

            public int OtherSubjectScores { get; set; }//Баллы по какому-то другому предмету

            

            public Student() { } //Пустой конструктор

            public Student(string fullName, short age) //Известны Ф.И.О. и возраст
            { 
                FullName = fullName;
                Age = age;
                eMail = "No Information!";
                ProgrammingScores = 0;
                MathematicScores = 0;
                PhysicScores = 0;
                OtherSubjectScores = 0;

            }

            public Student(string fullName, short age, string email)//Известны Ф.И.О., возраст и eMail
            {
                FullName = fullName;
                Age = age;
                eMail = email;
                ProgrammingScores = 0;
                MathematicScores = 0;
                PhysicScores = 0;
                OtherSubjectScores = 0;

            }

            public Student(string fullName, short age, string email, int programmingScores, int mathematicScores, int physicScores)//Известны Ф.И.О., возраст и eMail и все баллы за основные предметы
            {
                FullName = fullName;
                Age = age;
                eMail = email;
                ProgrammingScores = programmingScores;
                MathematicScores = mathematicScores;
                PhysicScores = physicScores;
                OtherSubjectScores = 0;

            }

            public Student(string fullName, short age, string email, int programmingScores, int mathematicScores, int physicScores, int otherSubjectScores)//Известно всё
            {
                FullName = FullName;
                Age = age;
                eMail = email;
                ProgrammingScores = programmingScores;
                MathematicScores = mathematicScores;
                PhysicScores = physicScores;
                OtherSubjectScores = otherSubjectScores;

            }

            /// <summary>
            /// Вывод информации о студенте в консоль
            /// </summary>
            /// <param name="student"></param>
            public static  void PrintingInformation(Student student)
            {
                Console.WriteLine("-------------- Данные о студенте -------------- ");

                Console.WriteLine($"Ф.И.О. - {student.FullName}"); ;

                Console.WriteLine($"Возраст - {student.Age}");

                Console.WriteLine($"eMail - {student.eMail}");

                Console.WriteLine($"Баллы по программированию - {student.ProgrammingScores}");

                Console.WriteLine($"Баллы по математике - {student.MathematicScores}");

                Console.WriteLine($"Баллы по физике - {student.PhysicScores}");

                Console.WriteLine($"Баллы по другому предмету - {student.OtherSubjectScores}");
            }

            public static double ArithmeticMeanCounting(Student student)
            {
                double Sum = student.ProgrammingScores + student.MathematicScores + student.PhysicScores;
                int COUNT = 3;

                return Sum / COUNT;
            }

        }
    }
}
