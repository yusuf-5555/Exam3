var student = new Student("Yusuf", "Mayak", "Math", 15, 1500);
student.SetYear(25);
System.Console.WriteLine(student.GetProgram());
System.Console.WriteLine(student.ToString());

var staff = new Staff("Behruz", "Sino","67", 2000);
staff.SetPay(560);
System.Console.WriteLine(staff.GetSchool());
System.Console.WriteLine(staff.ToString());