using Parctical8;
using System;
using System.ComponentModel;

namespace Employee1
{

    public class Employee:IEmployee
    {


        private int _id;
        private string _name;
        private int _age;
        private decimal _salary;

        public string Name { get { return _name; } set { _name=value; } }
        public decimal Salary { get { return _salary; } set { _salary= value; } }
        public int Age { get { return _age; } set { _age= value; } }
        public int Id { get { return _id; } set { _id= value; } }
   
    
    
    
    }

  

}