using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        private List<Student> students;

        public Classroom(int capacity)
        {
            Capacity = capacity;
            students = new List<Student>();
        }

        public int Capacity { get; set; }
        public int Count => students.Count;

        public string RegisterStudent(Student student)
        {
            if (Count<Capacity)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }

            return "No seats in the classroom";
        }

        public string DismissStudent(string firstName, string lastName)
        {
            Student student = students.FirstOrDefault(n=> n.FirstName==firstName && n.LastName==lastName);
            if (student==null)
            {
                return "Student not found";
            }

            students.Remove(student);
            return $"Dismissed student {firstName} {lastName}";
        }

        public string GetSubjectInfo(string subject)
        {
            var student = this.students.Where(s => s.Subject == subject).ToList();
            if (student.Count==0)
            {
                return "No students enrolled for the subject";
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Subject: {subject}")
                .AppendLine("Students:");

            foreach (var item in students)
            {
                sb.AppendLine($"{item.FirstName} {item.LastName}");
            }

            return sb.ToString().TrimEnd();
        }

        public int GetStudentsCount()
        {
            return Count;
        }

        public Student GetStudent(string firstName, string lastName)
        {
            Student student = students.FirstOrDefault(n => n.FirstName ==firstName && n.LastName==lastName);
            return student;
        }

    }
}