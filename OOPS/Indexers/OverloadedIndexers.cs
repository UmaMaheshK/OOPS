using System;

namespace OOPS.Indexers
{
    class OverloadedIndexers
    {
        private string[] namelist = new string[size];
        static public int size = 10;

        public OverloadedIndexers()
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

        public int this[string name]
        {
            get
            {
                int index = 0;

                while (index < size)
                {
                    if (namelist[index] == name)
                        return index;
                    index++;
                }
                return index;
            }
        }

        static void Main(string[] args)
        {
            OverloadedIndexers names = new OverloadedIndexers();
            names[0] = "Zara";
            names[1] = "Riz";
            names[2] = "Nuha";
            names[3] = "Asif";
            names[4] = "Davinder";
            names[5] = "Sunil";
            names[6] = "Rubic";

            //using the first indexer with int parameter
            for (int i = 0; i < size; i++)
                Console.WriteLine(names[i]);

            //using the second indexer with the string parameter
            Console.WriteLine("names[\"Nuha\"] = {0}",names["Nuha"]);
            Console.ReadKey();
        }
    }
}
/* OUTPUT
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
        2
 */
