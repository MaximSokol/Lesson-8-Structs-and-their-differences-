using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8__Structs_and_their_differences_
{
  static class Manipulator
  { 
        public static void Sort(Train[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length; j++)
                {
                    if(arr[i].Number <= arr[j].Number)
                    {
                        Train tr = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tr;
                    }
                }
            }
        }
        //------------------------------------------------------------

        public static void SearchByNumber(Train[] arr, int poisk)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i].Number == poisk)
                {
                    Console.WriteLine($"Destination\t{arr[i].Destination}\n" +
                        $"Number\t{arr[i].Number}\n" +
                        $"Date\t{arr[i].DateOFLeaving}\n");
                }
            }
        }
        //------------------------------------------------------------

        public static void FillInTheTrain(Train[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("Введите пункт назначения поезда:");
                string punkt = Console.ReadLine();

                Console.Write("Введите номер поезда:");
                string d = Console.ReadLine();
                int nomer = int.Parse(d);

                Console.Write("Введите дату отправления:");
                d = Console.ReadLine();
                DateTime date = DateTime.Parse(d);

                arr[i] = new Train(punkt, nomer, date);
            }
        }
        //------------------------------------------------------------

        public static void ShowTheDate(Train[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Destination:\t{arr[i].Destination}\n" +
                    $"Number:\t{arr[i].Number}\n" +
                    $"Date:\t{arr[i].DateOFLeaving}\n");
            }
        }
        //------------------------------------------------------------

    }
}
