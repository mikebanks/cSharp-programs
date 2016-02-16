using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  
 *  Homework #1: Michael Banks
 *  This application demostrates accessor and mutator properties as well as testing each method and property.
 *  This application also verifies each method and property works by checking the result using an if statement. 
 */

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Student1 = new Student("Michael Banks", false, 0);
            
            Console.WriteLine(Student1.name);
            Console.WriteLine(Student1.currStudent);
            Console.WriteLine(Student1.classification);

            Student1.name = "Michael Jackson";            
            if(Student1.name != "Michael Jackson")
                Console.WriteLine("Error! Name is incorrect!");
            else
                Console.WriteLine(Student1.name);
            
            Student1.currStudent = true;
            if(Student1.currStudent != true)
                Console.WriteLine("Error! Current Student information is incorrect!");
            else
                Console.WriteLine(Student1.currStudent);

            Student1.classification = 1;
            if(Student1.classification != 1)
                Console.WriteLine("Error! Classification is incorrect!");
            else                      
                Console.WriteLine(Student1.classification);

            Console.WriteLine(Student1.ToString());

            Console.ReadKey();
        }
    }
}
