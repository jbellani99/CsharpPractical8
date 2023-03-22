using Employee1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parctical8
{
    abstract class HrAbstract

    {
        public abstract void DeleteEmp(int Id,  List<Employee> emp1); 
        public abstract void UpdateEmp(int Id, string name, decimal salary, int age, List<Employee> emp1);

    }
}
