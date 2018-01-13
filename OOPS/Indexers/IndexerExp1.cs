using System;

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
                int index = default(int);
                Array.ForEach(dayNames, dady => Console.WriteLine("dayNames[{0}] = {1}", index++, dady));
            }
        }

        static void Main(string[] args)
        {
            Indexer1 indexer = new Indexer1();
            Console.WriteLine("Befor display all day names\n");
            indexer.AllDays();
            indexer[0] = "Uma mahesh";
            Console.WriteLine("\nAfter changed indexer display all day names\n");
            indexer.AllDays();
        }

        /*  OUTPUT
              Befor display all day names

                dayNames[0] = SUNDAY
                dayNames[1] = MONDAY
                dayNames[2] = TUESDAY
                dayNames[3] = WEDNESDAY
                dayNames[4] = THURSDAY
                dayNames[5] = FRIDAY
                dayNames[6] = SATURDAY

                After changed indexer display all day names

                dayNames[0] = Uma mahesh
                dayNames[1] = MONDAY
                dayNames[2] = TUESDAY
                dayNames[3] = WEDNESDAY
                dayNames[4] = THURSDAY
                dayNames[5] = FRIDAY
                dayNames[6] = SATURDAY
         */
    }
}
