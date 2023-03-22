using Employee1;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parctical8
{
    sealed class View : Employee, IView
    {

        public void display(List<Employee> emp)
        {



            if (emp.Count == 0)
            {
                Console.WriteLine("Please Add employee");

            }
            foreach (Employee temp in emp)
            {

                Console.WriteLine($"{temp.Id} {temp.Name} {temp.Salary} {temp.Age}");

            }



        }
        /// <summary>
        /// To show with specific id overloding with parameters
        /// </summary>
        /// <param name="emp"></param>
        /// <param name="Id"></param>
        public void display(List<Employee> emp, int Id)
        {



            foreach (var temp in emp)
            {
                if (temp.Id == Id)
                {
                    Console.WriteLine($"{temp.Id} {temp.Name} {temp.Salary} {temp.Age}");
                }
            }


        }



    }
}
