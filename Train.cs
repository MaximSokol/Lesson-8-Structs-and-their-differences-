using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8__Structs_and_their_differences_
{
    struct Train
    {
        string theDestinationPlace;
        int numberOfATrain;
        DateTime theDateOfLeaving;
        //------------------------------

        public Train(string destination, int number, DateTime date)
        {
            this.theDestinationPlace = destination;
            this.numberOfATrain = number;
            this.theDateOfLeaving = date;
        }
        //-------------------------------------------------------------

        public string Destination { get { return theDestinationPlace; } }
        public int Number { get { return numberOfATrain; } }
        public DateTime DateOFLeaving { get { return theDateOfLeaving; } }
    }
}
