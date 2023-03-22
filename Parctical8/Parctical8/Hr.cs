using Employee1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Parctical8
{
    class Hr : HrAbstract, IHr
    {
        public override void DeleteEmp(int Id, List<Employee> emp1)
        {

            foreach (Employee temp in emp1)
            {

                if (temp.Id == Id)
                {

                    emp1.Remove(temp);
                    break;

                }
            }





        }
        public override void UpdateEmp(int Id, string name, decimal salary, int age, List<Employee> emp1)
        {
            foreach (Employee temp in emp1)
            {

                if (temp.Id == Id)
                {


                    temp.Id = Id;
                    temp.Name = name;
                    temp.Age = age;
                    temp.Salary = salary;





                }
            }


        }

    }
}          
