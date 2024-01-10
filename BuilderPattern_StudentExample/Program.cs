using BuilderPattern_StudentExample;

Console.WriteLine("Enter Student Name");
string Name = Console.ReadLine();
Console.WriteLine("Enter Student Gender");
string Gender = Console.ReadLine();
Console.WriteLine("Enter Student Roll No.");
string RollNo = Console.ReadLine();

IStudentBuilder builder = new NewStudentBuilder();
StudentDirector director = new StudentDirector(builder);
director.BuildStudent(Name,Gender,RollNo);
Student student = builder.GetStudent();
student.Display();

