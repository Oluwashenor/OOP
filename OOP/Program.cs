// See https://aka.ms/new-console-template for more information
using OOP.Models;

Console.WriteLine("Hello, World!");

Point point = new Point();
point.X = 5;
point.Y = 4;
Console.WriteLine(point.X);
Console.WriteLine(point.Y);

User user = new();
user.UserName = "Test";
user.Password = "Password";
Console.WriteLine(user.id);

User userB = new();
user.UserName = "Test B";
user.Password = "Password B";
Console.WriteLine(userB.id);

User userC = new();
user.UserName = "Test C";
user.Password = "Password C";
Console.WriteLine(userC.id);