using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using microsoftefcore.Models;

namespace microsoftefcore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create or get context
            using var context = new LoginSystemContext();

            // Ensure database exists
            context.Database.EnsureCreated();

            // List all students
            Console.WriteLine("List of Students:");
            List<Student> students = context.Students.ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"Roll No: {student.RollNo}, Name: {student.Name}, Email: {student.Email}");
            }

            // Add a new student
            Console.WriteLine("\nAddng a new student...");
            Student newStudent = new Student();
            Console.WriteLine("Enter the roll no.");
            newStudent.RollNo = Console.ReadLine();
            Console.WriteLine("Enter the student Name");
            newStudent.Name = Console.ReadLine();
            Console.WriteLine("Enter the student Address");
            newStudent.Address = Console.ReadLine();
            Console.WriteLine("Enter the student Gender");
            newStudent.Gender = Console.ReadLine() === "1" ? "MALE" : "FEMALE";
            Console.WriteLine("Enter the student Phone");
            newStudent.Phone = Console.ReadLine

            context.Students.Add(newStudent);
            context.SaveChanges();

            Console.WriteLine(" New student added successfully!\n");

            //Print updated list
            Console.WriteLine("Updated list of students:");
            students = context.Students.ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"Roll No: {student.RollNo}, Name: {student.Name}, Email: {student.Email}");
            }
        }
    }
}
