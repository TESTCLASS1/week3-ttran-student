using System;
using static System.Console;

namespace ConsoleWorkWithData
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables:
            //========================================================================================================
            string FirstName = "Tuan"; //string data type - you declare variable "FirstName" and assign a value "Tuan"
            // Your Task: do the same as above: declare avariable "LastName" of string data type and assign a value 
            // (your last name - remember to have it within double quote) 
            
            int StudentID = 12345; //you declare a variable of StudentID of int data type and assign a value of "12345"
            //note: there is no quote for numbers
            
            DateTime BirthDate = new DateTime(1991, 03, 04); //date time data type 
            
            decimal Grade = 95m; //decimal data type 
            
            //display information on the console:
            //========================================================================================================
            //use WriteLine() command to display information
            // the following command will display "a. --- --- ------------------ ---------- ------------- -------- ----"
            //on console and move cursor to the next line
            WriteLine("a. --- --- ------------------ ---------- ------------- -------- ----");
            
            //If you want to display fixed text with variables, we can use "+" as below
            //display fixed string "b.  My name is " with values of the variables of FirstName and LastName
            WriteLine("b.  My name is " + FirstName + ' ' + LastName);
            
            //Your Task: using WriteLine() to display information of
            1. "c. I am a new student and this is my first program."
            2. "d. *** *** ****************** ********** ************* ******** ****"
            3. "e. My StudentID number is " with information stored in variable StudentID (hint: you should use "+")
            4. "f. My birthdate is " with information stored in variable BirthDate of DateTime data type
            //here we use a convertion function to convert a DateTime value to string: BirthDate.ToString("MM/dd/yyyy")); 
            // use "+" to combine fixed string with converted value 
            
            5. "g.        My current grade in the course is a " with value of grade stored in Grade variable
            6. "h. ___ ___ _________________ _________ _____________ _________ ____"
            
            7. Finally, we use Read() command to freeze the console so we can see the output of WriteLine() commands above

        }
    }
}
