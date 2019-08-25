using System;
using System.Collections.Generic;

namespace _0070_SetsTotalStudents {
    class Program {
        static void Main(string[] args) {

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();
            int totalStudents;

            Console.WriteLine("How many students to Course A have?");
            totalStudents = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter student codes for course A: ");
            for (int i = 0; i < totalStudents; i++) {
                A.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("How many students to Course B have?");
            totalStudents = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter student codes for course B:");
            for (int i = 0; i < totalStudents; i++) {
                B.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("How many students to Course C have?");
            totalStudents = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter student codes for course C:");
            for (int i = 0; i < totalStudents; i++) {
                C.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> newSet = new HashSet<int>();
            newSet.UnionWith(A);
            newSet.UnionWith(B);
            newSet.UnionWith(C);
            Console.WriteLine("Total Students: " + newSet.Count);
            Console.ReadLine();
        }
    }
}
