using System;

namespace OOPS.Indexers
{
    class Indexer2
    {
        private string[] names = new string[5];

        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; }
        }
    }

    class IndexerExp2
    {
        static void Main(string[] args)
        {
            Indexer2 ind = new Indexer2();
            Console.WriteLine("Befor Change the Indexer\n");

            for (int i = 0; i < 5; i++)
                Console.WriteLine("ind[{0}] = {1}", i, ind[i]);

            //Assigning values to indexer
            ind[0] = "AAA";
            ind[1] = "BBB";
            ind[2] = "CCC";
            ind[3] = "DDD";
            ind[4] = "EEE";

            Console.WriteLine("After Changed the Indexer values\n");

            for (int i = 0; i < 5; i++)
                Console.WriteLine("ind[{0}] = {1}", i, ind[i]);
        }
    }
}
