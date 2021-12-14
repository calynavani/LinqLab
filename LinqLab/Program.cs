using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqLab
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("_________________________________________________");
            Console.WriteLine("Numbers");
            Console.WriteLine("_________________________________________________");
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };

            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));


            Console.WriteLine("Find the min value");
            int minNum = nums.Min(x => x);
            int[] smallestNums = nums.Where(x => x == minNum).ToArray();

            foreach(int num in smallestNums)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();


            Console.WriteLine("Find the max value");
            int maxNum = nums.Max(x => x);
            int[] biggestNums = nums.Where(x => x == maxNum).ToArray();

            foreach(int num in biggestNums)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();


            Console.WriteLine("Find the max value less than 1000");
            int maxNumUnder1000 = nums.Where(x => x < 1000).Max();
            Console.WriteLine(maxNumUnder1000);
            Console.WriteLine();


            Console.WriteLine("Find all values between 10 and 100");
            int[] numsInRange = nums.Where(x => 10 <= x && x <= 100).ToArray();

            foreach (int num in numsInRange)
            {
                Console.WriteLine(num);
            }


            Console.WriteLine();
            Console.WriteLine("Find all the values between 100000 and 999999 inclusive");
            int[] numsInRange2 = nums.Where(x => 100000 <= x && x <= 999999).ToArray();

            foreach (int num in numsInRange2)
            {
                Console.WriteLine(num);
            }


            Console.WriteLine();
            Console.WriteLine("Count all the even numbers");
            int evenNums = nums.Where(x => x % 2 == 0).Count();
            Console.WriteLine(evenNums);
            Console.WriteLine();


            Console.WriteLine("_________________________________________________");
            Console.WriteLine("Students");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine();


            Console.WriteLine("Find all students age 21 and over");
            List<Student> studentsOver21 = students.Where(x => x.Age >= 21).ToList();
            
            foreach( Student stu in studentsOver21)
            {
                Console.WriteLine(stu.Name);
            }


            Console.WriteLine();
            Console.WriteLine("Find the oldest student");

            int oldestAge = students.Max(x => x.Age);
            List<Student> oldestStudents = students.Where(x => x.Age == oldestAge).ToList();
            foreach(Student stu in oldestStudents)
            {
                Console.WriteLine($"The oldest student is {stu.Name}");
            }


            Console.WriteLine();
            Console.WriteLine("Find the youngest student");

            int youngestAge = students.Min(x => x.Age);
            List<Student> youngestStudents = students.Where(x => x.Age == youngestAge).ToList();
            foreach (Student stu in youngestStudents)
            {
                Console.WriteLine($"The youngest student is {stu.Name}");
            }


            Console.WriteLine();
            Console.WriteLine("Find the oldest student under the age of 25");
            //create a list of students that are under 25
            //sort thru that list and print the older student from that list
            List<Student> studentsUnder25 = students.Where(x => x.Age < 25).ToList();


            foreach (Student stu in studentsUnder25)
            {
                int oldestAge2 = studentsUnder25.Max(x => x.Age);
                List<Student> oldestStudent = studentsUnder25.Where(x => x.Age == oldestAge2).ToList();        
                foreach(Student s in oldestStudent)
                {
                    Console.WriteLine(s.Name);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Find all students over 21 that are an even age");
            //make a list of students under 21
            //sort thru that list, make another list of students with even ages using the first list
       
            List<Student> studentsOver212 = students.Where(x => x.Age > 21).ToList();

            foreach(Student stu in studentsOver212)
            {
                List<Student> evenAges = studentsOver212.Where(x => x.Age % 2 == 0).ToList();
                foreach(Student s in evenAges)
                {
                    Console.WriteLine(s.Name);
                }
            }


            Console.WriteLine();
            Console.WriteLine("Find all teenage students between 13 and 19 inclusive");

            List<Student> studentsBetween13And19 = students.Where(x => x.Age >= 13 && x.Age <= 19).ToList();
            foreach(Student s in studentsBetween13And19)
            {
                Console.WriteLine(s.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Find all students whose name starts with a vowel");
            string vowels = "aeiou";
            //List<Student> studentNamesThatStartWithVowels = students.Where(x => x.Name.StartsWith(vowels.Any(x.Name.))).ToList();
          


        }
    }
}
