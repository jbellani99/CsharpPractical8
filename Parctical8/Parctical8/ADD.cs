using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee1;

namespace Parctical8
{
    sealed class ADD : Employee, IADD
    {
        //private int Id;
        //private string Name;
        //private int Age;
        //private decimal Salary;
        public void Add(int Id, string Name, decimal Salary, int Age, List<Employee> emp)
        {

            //  List<Employee> list = new List<Employee>();
            Employee obj = new Employee();
            try
            {
                //emp.Add();
                obj.Id = Id;
                obj.Name = Name;
                obj.Age = Age;
                obj.Salary = Salary;
                emp.Add(obj);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }



        }



    }
}
