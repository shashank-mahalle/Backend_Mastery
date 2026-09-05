// int x = 10;
// int y = x;

// x = 50;

// Console.WriteLine($"x = {x}");
// Console.WriteLine($"y = {y}");

Student s1 = new Student();
s1.Name = "ALEX";

Student s2 = s1;

s2.Name = "John";

Console.WriteLine(s1.Name);

Console.WriteLine(s2.Name);


class Student
{

    public String Name { get; set; }
}



