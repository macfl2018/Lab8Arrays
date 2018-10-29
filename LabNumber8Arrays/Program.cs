using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber8Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var yesOrNo = "yes";
            int convFirstStudentNameResponse = 0;
            int convFirstStudentNameReponseMinusOne = 0;
            var studentNumber = new[] { 1, 2, 3, 4 };
            var students = new[] { "Jerry", "Sam", "Becky", "Lisa" };
            var studentHomeTown = new[] { "Lakeland Fl", "Orlando Fl", "Toronto CA", "Miami FL" };
            var favoritFood = new[] { "Pizza", "Burgers", "Salad", "Tacos" };
            bool convertOrNot = false;
            string firstStudentNameResponse;
            string foodOrHomeResponse = "";
            string foodResponse = "";
            string homeTownResponse = "";
            string forceStop = "";


             while (yesOrNo == "yes")
                {

                do
                {
                    Console.WriteLine("Which student would you like to learn more about? (enter a number 1-4)");
                    firstStudentNameResponse = Console.ReadLine();
                    convertOrNot = Int32.TryParse(firstStudentNameResponse, out convFirstStudentNameResponse);
                    convFirstStudentNameReponseMinusOne = (convFirstStudentNameResponse - 1);
                }
                while (convertOrNot == false & (convFirstStudentNameReponseMinusOne <= 0 & convFirstStudentNameReponseMinusOne > 4))
                
                do
                {
              

                    Console.WriteLine("Student number " + convFirstStudentNameResponse +
                           " belongs to " + students[convFirstStudentNameReponseMinusOne] + " Type Home Town or favorite food, Which category would you like  know about? Or none if you don't want to continue type neither");



                    foodOrHomeResponse = Console.ReadLine();

                    if (foodOrHomeResponse == "Home Town")
                    {
                        homeTownResponse = foodOrHomeResponse;
                    }
                    else if (foodOrHomeResponse == "favorite food")
                    {
                        foodResponse = foodOrHomeResponse;
                    }
                    else if (foodOrHomeResponse == "none")
                    {
                        forceStop = foodOrHomeResponse;
                    }
                    else
                    {
                        forceStop = "";
                    }

                    if (homeTownResponse != "")

                    {
                        Console.WriteLine(students[convFirstStudentNameReponseMinusOne] + " comes from the home town of " + studentHomeTown[convFirstStudentNameReponseMinusOne]);

                    }
                    else if (foodResponse != "")
                    {
                        Console.WriteLine(students[convFirstStudentNameReponseMinusOne] + " has a favorite food of  " + favoritFood[convFirstStudentNameReponseMinusOne]);
                    }
                    else if (forceStop == "none")
                    {
                        forceStop = "none"; 
                    }

                }
                while (forceStop ==""); 

                  


                }



            Console.ReadLine();







        }
    }
}
