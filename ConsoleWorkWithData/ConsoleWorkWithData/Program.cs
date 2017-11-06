using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleWorkWithData
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName = "Tuan"; //string data type - i don't know if this is correct - no, add value to the string
            string LastName = ; //string data type - same here
            int StudentID = 8079; //int data type
            DateTime BirthDate = new DateTime(1991, 03, 04); //date time data type 
            decimal Grade = 95m; //decimal data type 
            WriteLine("a. --- --- ------------------ ---------- ------------- -------- ----");
            WriteLine("b.  My name is "+LastName+' '+FirstName); //string data type 
            WriteLine("c.     I am a new student and this is my first program.");
            WriteLine("d. *** *** ****************** ********** ************* ******** ****");
            WriteLine("e.  My StudentID number is " + StudentID); //int data type
            WriteLine("f.     My birthdate is " +BirthDate.ToString("MM/dd/yyyy")); //date time data type 
            WriteLine("g.        My current grade in the course is a " + Grade); //decimal data type
            WriteLine("h. ___ ___ _________________ _________ _____________ _________ ____");
            Read();
        }
    }
}
