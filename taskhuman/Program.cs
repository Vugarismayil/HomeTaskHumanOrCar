using System;

namespace taskhuman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[0];
            string choice;
            do
            {
                Console.WriteLine("Secim edin: ");
                Console.WriteLine("1. Butun telebelere bax");
                Console.WriteLine("2. Telebeler uzre axtaris et");
                Console.WriteLine("3. Telebe elave et");
                Console.WriteLine("0. cixis");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        if (students.Length == 0)
                        {
                            Console.WriteLine("Qeydiyyatda olan telebe yoxdur");
                        }
                        else
                        {
                            foreach (var item in students)
                            {
                                Console.WriteLine($"Ad Soyad: {item.FullName} Qrup No: {item.GroupNo}");
                            }
                        }
                        break;
                    case "2":
                        Console.WriteLine("Axtaris deyerini daxil edin: ");
                        string inputdata = Console.ReadLine();
                        if (students.Length == 0)
                        {
                            Console.WriteLine("Qeydiyyatda olan telebe yoxudr");
                        }
                        else
                        {
                            int count = 0;
                            foreach (var item in students)
                            {
                                if (item.FullName.Contains(inputdata) || item.GroupNo.Contains(inputdata))
                                {
                                    Console.WriteLine($"Ad Soyad: {item.FullName} Qrup No: {item.GroupNo}");
                                    count++;
                                }
                            }
                            if (count == 0)
                            {
                                Console.WriteLine("Axtardiginiz deyerle elaqeli melumat tapilmadi");
                            }
                        }
                        break;
                    case "3":
                        //do
                        //{
                            Console.WriteLine("Telebenin adini ve soyadini daxil edin: ");
                            string fullname = Console.ReadLine();
                            Console.WriteLine("QrupNo daxil edin ");
                            string groupno = Console.ReadLine();
                            var student = new Student
                            {
                                FullName = fullname,
                                GroupNo = groupno
                            };
                            Array.Resize(ref students, students.Length + 1);
                            students[students.Length - 1] = student;
                        //} while (CheckUpperorCorrect());



                        break;
                    case "0":

                        Console.WriteLine("Cixmaq istediyinizden Eminsinizmi? \nb\nX");
                        var Confrim = Console.ReadLine();
                        choice = Confrim;
                        break;
                    default:
                        Console.WriteLine("Secim Yalnisdir");
                        break;
                }
            } while (choice != "b");
        }
        static bool CheckUpperorCorrect(string student)
        {
            if (student.Length > 5)
            {
                return false;
            }
            if (string.IsNullOrEmpty(student))
            {
                return false;
            }
            if (char.IsLower(student[0]))
            {
                return false;
            }
            for (int i = 0; i < student.Length; i++)
            {
                if (!char.IsDigit(student[0]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
