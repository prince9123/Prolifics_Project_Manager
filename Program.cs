using System;

namespace Prolifics_P_M
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: Add Project");
            Console.WriteLine("2: View Project");
            Console.WriteLine("3: Add Employee");
            Console.WriteLine("4: View Employee");
            Console.WriteLine("5: Add Role");
            Console.WriteLine("6: View Role");
            Console.WriteLine("7: Exit");
            string[] project = new string[5];
            string[] role = new string[5];
            string[] employee = new string[4];
            Program p = new Program();
            bool j = true;
            while (j)
            {
                Console.WriteLine("Choose Your Option: ");
                int i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Add Project:\n");
                        p.AddProject(project);
                        break;
                    case 2:
                        Console.WriteLine("Project Details:\n");
                        p.ViewProject(project);
                        break;
                    case 3:
                        p.AddEmployee(employee);
                        break;
                    case 4:
                        Console.WriteLine("Employee Details:\n");
                        p.ViewEmployee(employee);
                        break;
                    case 5:
                        p.AddRole(role);
                        break;
                    case 6:
                        Console.WriteLine("Role Details:\n");
                        p.ViewRole(role);
                        break;
                    case 7:
                        j = false;
                        break;
                    default:
                        Console.WriteLine("Option is not in the list!");
                        break;
                }

            }
        }

        public String[] AddProject(string[] pro)
        {
            Console.Write("Enter Project Name: ");
            string ProjectName = Console.ReadLine();
            Console.Write("Enter Project Budget: ");
            string Budget = Console.ReadLine();
            Console.Write("Enter Project Starting Date: ");
            string StartingDate = Console.ReadLine();
            Console.Write("Enter Project End date: ");
            string EndDate = Console.ReadLine();
            Console.Write("Enter Project Manager: ");
            string Manager = Console.ReadLine();

            pro[0] = ProjectName;
            pro[1] = Budget;
            pro[2] = StartingDate;
            pro[3] = EndDate;
            pro[4] = Manager;

            return pro;
        }

        public void ViewProject(string[] pro)
        {
            foreach (string e in pro)
            {
                Console.WriteLine(e);
                Console.WriteLine();
            }
        }

        public string[] AddEmployee(string[] arr)
        {
            Console.Write("Enter Employee FirstName: ");
            string FirstName = Console.ReadLine();
            Console.Write("Enter Employee LastName: ");
            string LastName = Console.ReadLine();
            string EmployeeName = String.Concat(FirstName, LastName);
            Console.Write("Enter Employee DOB: ");
            string DOB = Console.ReadLine();
            Console.Write("Enter Employee Contact: ");
            string Contact = Console.ReadLine();
            Console.Write("Enter Employee Role: ");
            string Role = Console.ReadLine();

            arr[0] = EmployeeName;
            arr[1] = DOB;
            arr[2] = Contact;
            arr[3] = Role;

            return arr;
        }
        public void ViewEmployee(string[] arr1)
        {
            foreach (string e in arr1)
            {
                Console.WriteLine(e);
                Console.WriteLine();
            }
        }

        public void AddRole(string[] arr)
        {
            Console.Write("Enter Role1 Name: ");
            string Role1 = Console.ReadLine();
            Console.Write("Enter Role2 Name: ");
            string Role2 = Console.ReadLine();
            Console.Write("Enter Role3 Name: ");
            string Role3 = Console.ReadLine();
            Console.Write("Enter Role4 Name: ");
            string Role4 = Console.ReadLine();
            Console.Write("Enter Role5 Name: ");
            string Role5 = Console.ReadLine();

            arr[0] = Role1;
            arr[1] = Role2;
            arr[2] = Role3;
            arr[3] = Role4;
            arr[4] = Role5;
        }
        public void ViewRole(string[] arr)
        {
            foreach (string e in arr)
            {
                Console.WriteLine(e);
                Console.WriteLine();
            }
        }
    }
}
