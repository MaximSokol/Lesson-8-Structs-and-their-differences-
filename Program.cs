using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8__Structs_and_their_differences_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Additional Task

            //JustAStruct just = new JustAStruct("PowerOfPaper GT-2012", "LegacyOfLegend", 28.50);
            //just.ShowDate();


            // Task 2

            //var train = new Train[2];

            //Manipulator.FillInTheTrain(train);
            //Manipulator.SearchByNumber(train, 1);
            //Manipulator.ShowTheDate(train);


            // Task 3

            var myClass = new MyClass();
            Console.WriteLine(myClass.change);
            Program.MyClassMethod(myClass);

            var myStruct = new MyStruct("Classic MyStruct");
            Console.WriteLine(myStruct.change);
            Program.MyStrcutMethod(myStruct);
        }

        public static void MyClassMethod(MyClass mClass)
        {
            mClass.change = "Class have changed the value!";
        }

        public static void MyStrcutMethod(MyStruct mStruct)
        {
            mStruct.change = "Struct have changed the value!";
        }
    }
}
