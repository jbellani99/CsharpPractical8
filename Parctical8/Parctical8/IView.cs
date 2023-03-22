using Employee1;

namespace Parctical8
{
    internal interface IView
    {
        void display(List<Employee> emp);
        void display(List<Employee> emp, int Id);
    }
}