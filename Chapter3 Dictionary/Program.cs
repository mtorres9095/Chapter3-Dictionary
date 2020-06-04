using System;
using System.Collections.Generic;

namespace Chapter3_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
                    Dictionary<int, string> students = new Dictionary<int, string>();
                    string newStudent;
                    Console.WriteLine("Enter students' names and IDs (or Enter to finish):");

            do
            {
                Console.Write("Student Name: ");
                newStudent = Console.ReadLine();

                if (newStudent != "")
                {
                    Console.Write("ID Number: ");
                    int newID = Int32.Parse(Console.ReadLine());
                    students.Add(newID, newStudent);
                }
            } while (newStudent != "");

                    Console.WriteLine("\nThe class list:");
                    foreach (KeyValuePair<int, string> student in students)
                    {
                      Console.WriteLine($"{student.Value}'s ID: {student.Key}");
                    }
                }
            }
        }

