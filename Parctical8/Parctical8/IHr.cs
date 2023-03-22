using Employee1;

namespace Parctical8
{
    internal interface IHr
    {
        void DeleteEmp(int Id, List<Employee> emp1);
        void UpdateEmp(int Id, string name, decimal salary, int age, List<Employee> emp1);
    }
}