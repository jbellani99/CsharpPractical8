using Employee1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parctical8
{
     static class Callable
    {

         public static  ADD getcall() { 
        
                return new ADD();   
        
        
        }

        public static View GetView() { 
        
        
            return new View();
        
        }
        public static Hr getobj(){

            return new Hr();
        }

        public static Employee getcallable() { 
        
        return new Employee();    

        }



    }
}
