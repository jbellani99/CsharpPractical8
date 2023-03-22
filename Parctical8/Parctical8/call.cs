using Employee1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Parctical8
{
    class call
    {



        /// <summary>
        /// It's for display the choices.
        /// </summary>
        /// <returns>
        /// void
        /// </returns>
        public void details()
        {

            Console.WriteLine("************************************ Employee Management System ************************************");
            Console.WriteLine("Press 1 For Add Employee");
            Console.WriteLine("Press 2 For View All Employee Details");
            Console.WriteLine("Press 3 For View Specific Employee Details");
            Console.WriteLine("Press 4 For Update an Employee Details");
            Console.WriteLine("Press 5 For Delete Employee");
            Console.WriteLine("Press 6 For Exit");


        }

        public static void Main(string[] args)
        {


            int choice = 0, Id, age;
            string name;
            decimal salary;


            List<Employee> emp = new List<Employee>();
            //Hr obj1 = new Hr();
            //ADD obj = new ADD();
            //View objView = new View();
            call obj= new call();

            IADD addobj = Callable.getcall();
            IHr htobj = Callable.getobj();
            IView viewobj = Callable.GetView();

            while (true)
            {
                obj.details();
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                   
                    case 1:

                        Console.WriteLine("Enter ID of Employee");
                        Id = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("Enter Name of Employee");
                        name = Console.ReadLine();

                        Console.WriteLine("Enter Salary of Employee");
                        salary = Convert.ToDecimal(Console.ReadLine());

                        Console.WriteLine("Enter Age of Employee");
                        age = Convert.ToInt16(Console.ReadLine());

                        addobj.Add(Id, name, salary, age, emp);

                        Console.WriteLine("User Added Sucessfully!!!");

                        break;


                    case 2:
                       
                        viewobj.display(emp);

                        break;



                    case 3:

                        Console.WriteLine("Please Enter ID you want to search");
                        Id = Convert.ToInt16(Console.ReadLine());

                        viewobj.display(emp, Id);

                        break;

                    case 4:

                        Console.WriteLine("Please Enter ID you want to Update");
                        Id = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("Enter Name of Employee");
                        name = Console.ReadLine();

                        Console.WriteLine("Enter Salary of Employee");
                        salary = Convert.ToDecimal(Console.ReadLine());

                        Console.WriteLine("Enter Age of Employee");
                        age = Convert.ToInt16(Console.ReadLine());

                        htobj.UpdateEmp(Id, name, salary, age, emp);

                        Console.WriteLine("Updated Sucessfully!!!!");

                        break;

                    case 5:

                        Console.WriteLine("Please Enter ID you want to search");
                        Id = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("Are you sure you want to delete Y|N");

                        char DelChoice;

                        DelChoice = Convert.ToChar(Console.ReadLine());

                        DelChoice.ToString().ToLower();

                        if (DelChoice == 'y')
                        {
                            htobj.DeleteEmp(Id, emp);
                        }

                        else
                        {
                            break;
                        }

                        break;

                    case 6:

                        Environment.Exit(0);

                        break;

                    default:

                        Console.WriteLine("Please Enter Valid Choice");

                        break;

                }
            }

        }

    }
}
