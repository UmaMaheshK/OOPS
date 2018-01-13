using System;

namespace OOPS.Indexers
{
    class IndexerExp3
    {
        private string[] namelist = new string[size];
        static public int size = 10;

        public IndexerExp3()
        {
            for (int i = 0; i < size; i++)
                namelist[i] = "N. A.";
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index <= size - 1)
                    return namelist[index];
                else
                    return string.Empty;
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                    namelist[index] = value;
            }
        }

        static void Main(string[] args)
        {
            IndexerExp3 names = new IndexerExp3();
            names[0] = "Zara";
            names[1] = "Riz";
            names[2] = "Nuha";
            names[3] = "Asif";
            names[4] = "Davinder";
            names[5] = "Sunil";
            names[6] = "Rubic";

            for (int i = 0; i < size; i++)
                Console.WriteLine(names[i]);
            Console.ReadKey();
        }       
    }
}
/*  OUTPUT
            Zara
            Riz
            Nuha
            Asif
            Davinder
            Sunil
            Rubic
            N. A.
            N. A.
            N. A.
*/
