using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Indexers
{
    class IndexerExp5
    {
        private string[] names;
        private int arrSize;
        public IndexerExp5(int size)
        {
            names = new string[size];
            arrSize = size;
            int index = 0;
            Array.ForEach(names, element => { names[index++] = "Empty"; Console.WriteLine("name[{0}] = {1}", index - 1, names[index - 1]); });
        }

        public string this[int index]
        {
            get
            {
                return names[index];
            }
            set
            {
                names[index] = value;
            }
        }

        public string this[string data]
        {
            get
            {
                int count = 0;
                for (int i = 0; i < arrSize; i++)
                {
                    if (names[i] == data)
                        count++;
                }

                return count.ToString();
            }

            set
            {
                //for (int i = 0; i < arrSize; i++)
                //{
                //    if (names[i] == data)
                //        names[i] = value;
                //}
                int index = 0;
                Array.ForEach(names, name => { if (name == data) names[index] = value; index++; });
            }
        }

        static void Main(string[] args)
        {
            int size = 10;
            IndexerExp5 index = new IndexerExp5(size);

            index[9] = "Some Value";
            index[3] = "Another Value";
            index[5] = "Any Value";

            index["Empty"] = "no value";

            Console.WriteLine("\nAfter change values\n");
            for (int i = 0; i < size; i++)
                Console.WriteLine("index[{0}]: {1}", i, index[i]);

            Console.WriteLine("\nNumber of \"no value\" entries: {0}", index["no value"]);
        }
    }
}
/*
 OUTPUT

    name[0] = Empty
    name[1] = Empty
    name[2] = Empty
    name[3] = Empty
    name[4] = Empty
    name[5] = Empty
    name[6] = Empty
    name[7] = Empty
    name[8] = Empty
    name[9] = Empty

    After change values

    index[0]: no value
    index[1]: no value
    index[2]: no value
    index[3]: Another Value
    index[4]: no value
    index[5]: Any Value
    index[6]: no value
    index[7]: no value
    index[8]: no value
    index[9]: Some Value

    Number of "no value" entries: 7
 */
