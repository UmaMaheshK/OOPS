using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Indexers
{
    class IndexerExp1
    {
        class Indexer1
        {

            private string[] dayNames = new string[] { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };

            public string this[int index]
            {
                get
                {
                    return dayNames[index];
                }
                set
                {
                    dayNames[index] = value;
                }
            }
            public void AllDays()
            {
                for (int i = 0; i < dayNames.Length; i++)
                {
                    Console.WriteLine("dayNames[{0}] = {1}", i, dayNames[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            Indexer1 indexer = new Indexer1();
            Console.WriteLine("Display all day names");
            indexer.AllDays();            
            //get second element
            Console.WriteLine("day");
        }

        /*  OUTPUT
                Display all day names
                dayNames[0] = SUNDAY
                dayNames[1] = MONDAY
                dayNames[2] = TUESDAY
                dayNames[3] = WEDNESDAY
                dayNames[4] = THURSDAY
                dayNames[5] = FRIDAY
                dayNames[6] = SATURDAY
         */
    }
}
