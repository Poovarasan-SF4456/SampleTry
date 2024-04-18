using System;

namespace IfAssignment{

    class Program{

        public static void Main(){

            // See https://aka.ms/new-console-template for more information
            //Console.WriteLine("Hello, World!");

           Console.WriteLine("Enter a Mark: ");
                int mark=int.Parse(Console.ReadLine());
                if(mark<=100 && mark>80){
                    Console.WriteLine("Grade A");
                }
                else if(mark<=80 && mark>60){
                    Console.WriteLine("Grade B");
                }
                else if(mark<=60 && mark=>36){
                    Console.WriteLine("Grade C");
                }
                else if(mark<36 && mark>=0){
                    Console.WriteLine("Grade D");
                }
                else{
                    Console.WriteLine("Invalid Input");
                }


        }
    }
}
