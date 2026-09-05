


// using System;

// // Value Types
// int age = 24;
// int copy = age;

// age = 30;

// Console.WriteLine($"Age: {age}");
// Console.WriteLine($"Copy: {copy}");


// // Reference Types
// Student s1 = new Student();
// s1.Name = "Shashank";

// Student s2 = s1;

// s1.Name = "Rahul";


// Console.WriteLine(s2.Name);

// class Student
// {
//     public string Name { get; set; }
// }



int s = 100;
int y = s;
y = 999;
Console.WriteLine($"x = {s}"); // What will print?
Console.WriteLine($"y = {y}");


// Reference Type test
int[] arr1 = { 1, 2, 3 };
int[] arr2 = arr1;        // reference copy!
arr2[0] = 999;
Console.WriteLine($"arr1[0] = {arr1[0]}"); // What will print?
Console.WriteLine($"arr2[0] = {arr2[0]}"); // What will print?

// String immutability test
string str1 = "TCS";
string str2 = str1;
str2 = "Deloitte";
Console.WriteLine($"str1 = {str1}"); // What will print?
Console.WriteLine($"str2 = {str2}"); // What will print?