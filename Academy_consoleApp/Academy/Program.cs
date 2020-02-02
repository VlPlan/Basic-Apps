using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace Academy
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> student1Subjects = new Dictionary<string, int>() { { "Biology", 3 }, { "History", 5 }, { "Informatics", 5 } };
            Dictionary<string, int> student2Subjects = new Dictionary<string, int>() { { "Biology", 4 }, { "History", 3 }, { "Chemistry", 3 }, { "Physics", 2 }, { "Informatics", 4 } };
            Dictionary<string, int> student3Subjects = new Dictionary<string, int>() { { "Biology", 5 }, { "History", 5 }, { "Physics", 5 }, { "Informatics", 4 } };
            Dictionary<string, int> student4Subjects = new Dictionary<string, int>() { { "History", 4 }, { "Chemistry", 5 }, { "Physics", 3 }, { "Informatics", 5 } };


            User user1 = new User() { FirstName = "Vladimir", LastName = "Planojevic", UserName = "VladP", password = 12345, Role = Role.Student, Subjects = student1Subjects };
            User user2 = new User() { FirstName = "Cveta", LastName = "Geroska", UserName = "CvGer", password = 8765, Role = Role.Trainer };
            User user3 = new User() { FirstName = "Mimi", LastName = "Petkova", UserName = "MimP", password = 3333, Role = Role.Student, Subjects = student2Subjects };
            User user4 = new User() { FirstName = "Dejan", LastName = "Krstevski", UserName = "DekoK", password = 24321, Role = Role.Student, Subjects = student3Subjects };
            User user5 = new User() { FirstName = "Goran", LastName = "Stevkovski", UserName = "gokStev", password = 41235, Role = Role.Trainer };
            User user6 = new User() { FirstName = "Darko", LastName = "Mihailovski", UserName = "darMih", password = 8392, Role = Role.Student, Subjects = student4Subjects };
            User user7 = new User() { FirstName = "Martina", LastName = "Miteva", UserName = "marceM", password = 9999, Role = Role.Admin };
            User user8 = new User() { FirstName = "Mihaela", LastName = "Dimitrova", UserName = "mihaelaD", password = 34543, Role = Role.Trainer };
            User user9 = new User() { FirstName = "Dejan", LastName = "Mitev", UserName = "deksoM", password = 3321, Role = Role.Admin };

            List<User> Students = new List<User>() { user1, user3, user4, user6 };
            List<User> Trainers = new List<User>() { user2, user5, user8 };
            List<User> Admins = new List<User>() { user7, user9 };



            Console.WriteLine("Please select your role: 1. Admin   2. Trainer   3. Student");
            int selection = int.Parse(Console.ReadLine());
            if (selection == 1)
            {
                Console.WriteLine("Insert username");
                string userCheck = Console.ReadLine();

                Console.WriteLine("Insert password");
                int passCheck = int.Parse(Console.ReadLine());
                bool check = false;
                while (!check)
                {
                    foreach (User admin in Admins)
                    {

                        if (userCheck == admin.UserName && passCheck == admin.password)

                        {
                            Console.WriteLine("You are logged");
                            check = true;
                            break;

                        }
                        else if (userCheck != admin.UserName || passCheck != admin.password)
                        {
                            Console.WriteLine("Invalid username or password, please try again!");
                            continue;

                        }

                    }

                    if (!check)
                    {
                        Console.WriteLine("Invalid username or password, please try again!");

                    }

                }

                Console.WriteLine("You are logged as admin, select option you would like to do:  1.Add Student   2.Add Trainer   3. Remove Student   4.Remove Trainer   5.Add Admin   6.Remove Admin");
                int selection2 = int.Parse(Console.ReadLine());
                if (selection2 == 1)
                {
                    Console.WriteLine("Insert Students Name");
                    string AddStudentName = Console.ReadLine();
                    Console.WriteLine("Insert Students Lastname");
                    string AddStudentLastName = Console.ReadLine();
                    Console.WriteLine("Insert Students age");
                    int AddStudentAge = int.Parse(Console.ReadLine());
                    Console.WriteLine("Insert student Username");
                    string AddStudentUser = Console.ReadLine();
                    Console.WriteLine("Insert Student password");
                    int AddStudentPassword = int.Parse(Console.ReadLine());

                    User AddStudent = new User() { FirstName = AddStudentName, LastName = AddStudentLastName, UserName = AddStudentUser, password = AddStudentPassword, Role = Role.Student };
                    Students.Add(AddStudent);
                    Console.WriteLine("Current students are:");
                    for (var st = 0; st < Students.Count; st++)
                    {
                        Console.WriteLine($"{Students[st].FirstName} {Students[st].LastName}");
                    }

                }
                if (selection2 == 2)
                {
                    Console.WriteLine("Insert Trainer Name");
                    string AddTrainerName = Console.ReadLine();
                    Console.WriteLine("Insert Trainer Lastname");
                    string AddTrainerLastName = Console.ReadLine();
                    Console.WriteLine("Insert Trainer age");
                    int AddTrainerAge = int.Parse(Console.ReadLine());
                    Console.WriteLine("Insert Trainer Username");
                    string AddTrainerUser = Console.ReadLine();
                    Console.WriteLine("Insert Trainer password");
                    int AddTrainerPassword = int.Parse(Console.ReadLine());



                    User AddTrainer = new User() { FirstName = AddTrainerName, LastName = AddTrainerLastName, UserName = AddTrainerUser, password = AddTrainerPassword, Role = Role.Trainer };
                    Trainers.Add(AddTrainer);
                    Console.WriteLine("Current trainers are:");
                    for (var tr = 0; tr < Trainers.Count; tr++)
                    {
                        Console.WriteLine($"{Trainers[tr].FirstName} {Trainers[tr].LastName}");
                    }

                }

                if (selection2 == 3)
                {
                   
                    
                    for (var i=0;i<Students.Count;i++)
                    {
                        Console.WriteLine(Students[i].FirstName + " " + Students[i].LastName);
                       
                    }
                    Console.ReadLine();

                    for (var s = 0; s < Students.Count; s++)
                    {
                        Console.WriteLine("Select student name that you want to remove");
                        string removeStudent = Console.ReadLine();
                        if (removeStudent == Students[s].FirstName)
                        {
                            Students.Remove(Students[s]);

                            Console.WriteLine(Students[s].FirstName + " " + Students[s].LastName + " is removed.");
                            Console.WriteLine("Here are our current students:");
                            Console.WriteLine(Students[s].FirstName + " " + Students[s].LastName);
                            Console.ReadLine();
                        }

                    else
                            Console.WriteLine("That name is not in the list of students");
                        
                    }
                    Console.ReadLine();
                }
                   
                
               
                if (selection2 == 4)
                {
                    Console.WriteLine("Select trainer name that you want to remove");
                    string removeTrainer = Console.ReadLine();
                    foreach (User trainer in Trainers)
                    {

                        Console.WriteLine(trainer.FirstName + " " + trainer.LastName);
                    }
                        for (var i = 0; i < Trainers.Count; i++)
                        {
                            if (removeTrainer == Trainers[i].FirstName)
                        {

                            Trainers.Remove(Trainers[i]);
                            Console.WriteLine(Trainers[i].FirstName + " " + Trainers[i].LastName + " is removed.");
                            Console.WriteLine("Here are our current trainers:");
                            Console.WriteLine(Trainers[i].FirstName + " " + Trainers[i].LastName);

                        }
                        else if (removeTrainer != Trainers[i].FirstName)
                        {
                            Console.WriteLine("That name is not in the list of trainers");
                        }
                        
                    }
                    Console.ReadLine();

                }
                if (selection2 == 5)
                {
                    Console.WriteLine("Insert Admin Name");
                    string AddAdminName = Console.ReadLine();
                    Console.WriteLine("Insert Admin Lastname");
                    string AddAdminLastName = Console.ReadLine();
                    Console.WriteLine("Insert Admin age");
                    int AddAdminAge = int.Parse(Console.ReadLine());
                    Console.WriteLine("Insert Admin Username");
                    string AddAdminUser = Console.ReadLine();
                    Console.WriteLine("Insert Admin password");
                    int AddAdminPassword = int.Parse(Console.ReadLine());



                    User AddAdmin = new User() { FirstName = AddAdminName, LastName = AddAdminLastName, UserName = AddAdminUser, password = AddAdminPassword, Role = Role.Admin };
                    Admins.Add(AddAdmin);
                    Console.WriteLine("Current admins are:");
                    for (var adm = 0; adm < Admins.Count; adm++)
                    {
                        Console.WriteLine($"{Admins[adm].FirstName} {Admins[adm].LastName}");
                    }


                }

                if (selection2 == 6)
                {

                    Console.WriteLine("Select admin name that you want to remove");
                    string removeAdmin = Console.ReadLine();
                    foreach (var admin in Admins)
                    {
                        Console.WriteLine(admin.FirstName + " " + admin.LastName);
                    }
                    for (var admin = 0; admin < Admins.Count; admin++)
                    {
                        if (removeAdmin == Admins[admin].FirstName)
                        {
                            Admins.Remove(Admins[admin]);

                            Console.WriteLine(Admins[admin].FirstName + " " + Admins[admin].LastName + " is removed.");
                            Console.WriteLine("Here are our current admins:");
                            Console.WriteLine(Admins[admin].FirstName + " " + Admins[admin].LastName);
                        }
                        else if (removeAdmin != Admins[admin].FirstName)
                        {
                            Console.WriteLine("That name is not in the list of admins");
                        }
                       
                    }
                    Console.ReadLine();
                }

            }


            if (selection == 2)
            {
                Console.WriteLine("Insert username");
                string userCheck1 = Console.ReadLine();

                Console.WriteLine("Insert password");
                int passCheck1 = int.Parse(Console.ReadLine());
                bool check1 = false;
                while (!check1)
                {
                    foreach (User trainer in Trainers)
                    {

                        if (userCheck1 != trainer.UserName || passCheck1 != trainer.password)
                        {
                            continue;
                        }
                        else if (userCheck1 == trainer.UserName && passCheck1 == trainer.password)
                        {
                            Console.WriteLine("You are logged");
                            check1 = true;
                            break;
                        }

                    }

                    if (!check1)
                    {
                        Console.WriteLine("Invalid username or password, please try again!");
                    }

                }


                Console.WriteLine("You are logged as trainer, select option you would like to do:  1.Select student  2. Select subject");
                int selection3 = int.Parse(Console.ReadLine());
                if (selection3 == 1)
                {
                    foreach (var student in Students)
                        Console.WriteLine(student.FirstName + " " + student.LastName);

                    Console.WriteLine("Insert student name to see subjects");
                    string checkStudentGrades = Console.ReadLine();
                    foreach (var student in Students)
                    {
                        if (checkStudentGrades == student.FirstName)
                        {
                            foreach (var i in student.Subjects)
                                Console.WriteLine(i);
                        }

                    }
                    Console.ReadLine();
                }
                if (selection3 == 2)
                {
                    Console.WriteLine("Select subject: 1.Biology  2.History  3.Informatics  4.Physics   5.Chemistry");
                    int selectSubject = int.Parse(Console.ReadLine());
                    foreach (var stud in Students)
                    {
                        foreach (var val in stud.Subjects)
                        {


                            if (selectSubject == 1)
                            {
                                if (val.Key == "Biology")
                                {
                                    Console.WriteLine($"Biology is visited by {stud.FirstName} {stud.LastName} and grade is {val.Value}");

                                }

                            }

                            if (selectSubject == 2)
                            {
                                if (val.Key == "History")
                                {
                                    Console.WriteLine($"History is visited by {stud.FirstName} {stud.LastName} and grade is {val.Value}");
                                }

                            }
                            if (selectSubject == 3)
                            {
                                if (val.Key == "Informatics")
                                {
                                    Console.WriteLine($"Informatics is visited by {stud.FirstName} {stud.LastName} and grade is {val.Value}");
                                }

                            }

                            if (selectSubject == 4)
                            {
                                if (val.Key == "Physics")
                                {
                                    Console.WriteLine($"Physics is visited by {stud.FirstName} {stud.LastName} and grade is {val.Value}");
                                };
                            }
                            if (selectSubject == 5)
                            {
                                if (val.Key == "Chemistry")
                                {
                                    Console.WriteLine($"Chemistry is visited by {stud.FirstName} {stud.LastName} and grade is {val.Value}");
                                };
                            }
                        }
                    }
                    Console.ReadLine();
                }
            }

            if (selection == 3)
            {
                Console.WriteLine("Insert username");
                string userCheck2 = Console.ReadLine();

                Console.WriteLine("Insert password");
                int passCheck2 = int.Parse(Console.ReadLine());
                bool check2 = false;
                while (!check2)
                {
                    foreach (User student in Students)
                    {

                        if (userCheck2 != student.UserName || passCheck2 != student.password)
                        {
                            continue;
                        }
                        else if (userCheck2 == student.UserName && passCheck2 == student.password)
                        {
                            Console.WriteLine("You are logged");
                            check2 = true;
                            break;
                        }

                    }

                    if (!check2)
                    {
                        Console.WriteLine("Invalid username or password, please try again!");
                    }

                }


                Console.WriteLine("You are logged as student, here are the list of subjects you are listening");

                foreach (var s in Students)
                {
                    foreach (var subj in s.Subjects)
                    {
                        if (userCheck2 == s.UserName)
                        {
                            Console.WriteLine(subj.Key + " " + subj.Value);
                        }
                    }

                }

                Console.ReadLine();

            }


        }
    }
}
