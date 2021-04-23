using System;
using first_space;
using second_space;

namespace first_space{
    class xyz{
        public void function(){
            Console.WriteLine("Inside first_space");
        }
    }
}
namespace second_space{
    class dfgh{
        public void function(){
            Console.WriteLine("Inside second_space");
        }
    }
}
class Testclass{
     static void Main(string[] args){
         xyz fc = new xyz();
         dfgh sc = new dfgh();
         fc.function();
         sc.function();
         Console.ReadKey();
    }
}
