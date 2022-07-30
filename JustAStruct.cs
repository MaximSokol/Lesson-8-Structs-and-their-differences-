using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8__Structs_and_their_differences_
{
    struct JustAStruct
    {
        string model;
        string producer;
        double cost;
        //--------------------

        public JustAStruct(string model, string producer, double cost)
        {
            this.model = model;
            this.producer = producer;
            this.cost = cost;
        }
        //----------------------------------------------------------------

        public void ShowDate()
        {
            Console.WriteLine($"Model:\t\t{model}\n" +
                $"Produced:\t{producer}\n" +
                $"Cost:\t\t{cost}\n");
        }
        //----------------------------
    }
}
